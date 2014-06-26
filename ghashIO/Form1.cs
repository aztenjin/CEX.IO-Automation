using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using Nextmethod.Cex;
using Nextmethod.Cex.Exceptions;


namespace ghashIO
{
	public partial class Form1 : Form
	{
		private string _hashIoKey;
		private string _hashIoSecret;
		private string _cexUserName;
		private ApiCredentials _cexApiCredentials;
		private CexApi _cexClient;
		private Balance _balance;
		private int _apiCallCount;
		private Stopwatch _stopwatch;
		private decimal _previousBtcValue;
		private decimal _previousNmcValue;
		private decimal _previousIxcValue;
		private decimal _previousGhsValue;
		private double _elapsedHours;
		private int _orderCount;
		private double _callsPerHour;
		private decimal _ghsPurchased;
		private decimal _btcEarned;
		private bool _firstRun;


		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			_firstRun = true;
			_apiCallCount = 0;
			_hashIoKey = "IB448l8aZIeYbtVOQUwA4EctWEU";
			_hashIoSecret = "QjO5Ll0ZKBPQgecq7sPQBGRPTI";
			_cexUserName = "tenjin";
			_cexApiCredentials = new ApiCredentials(_cexUserName, _hashIoKey, _hashIoSecret);
			_cexClient = new CexApi(_cexApiCredentials);

			richTextBox1.Text = @"Started @ " + DateTime.Now + Environment.NewLine;
			_stopwatch = new Stopwatch();
			_stopwatch.Start();
			_balance = new Balance();

			udMaintanMinBalance.Value = (decimal) Properties.Settings.Default["MaintainBalance"];

			button1_Click(null, null);
		}

		private async void button1_Click(object sender, EventArgs e)
		{
			try
			{

				_balance = await _cexClient.AccountBalance();

				_apiCallCount = ++_apiCallCount;


				if (Convert.ToDecimal(lblBtcValue.Text) == _previousBtcValue)
					lblBtcValue.ForeColor = System.Drawing.Color.Black;

				if (Convert.ToDecimal(lblNmcValue.Text) == _previousNmcValue)
					lblNmcValue.ForeColor = System.Drawing.Color.Black;

				if (Convert.ToDecimal(lblIXCValue.Text) == _previousIxcValue)
					lblIXCValue.ForeColor = System.Drawing.Color.Black;

				if (Convert.ToDecimal(lblGhsValue.Text) == _previousGhsValue)
					lblGhsValue.ForeColor = System.Drawing.Color.Black;


			}
			catch (CexNonceException)
			{
				Console.WriteLine(@"nonce exception");
			}
			catch (Exception ex)
			{

				richTextBox1.Text += ex.ToString();
			}
			richTextBox1.SelectionStart = richTextBox1.Text.Length;
			richTextBox1.ScrollToCaret();
			UpdateUi();
		}

		private async void PlaceOrder(SymbolPair pair, Balance balance, OrderType orderType)
		{
			Order order = new Order();
			OrderBook orderBook = await _cexClient.OrderBook(pair);
			_apiCallCount = ++_apiCallCount;
			IEnumerable<OrderBookOrder> bids = orderBook.Bids;
			order.Price = ((OrderBookOrder[]) (bids))[0].Price;

			decimal amount = 0;
			decimal availableBalance;
			if (orderType == OrderType.Buy)
			{
				if (pair.To == Symbol.NMC)
				{
					availableBalance = balance.NMC.Available;
					amount = PurchaseAmount(order.Price, availableBalance);
				}


				if (pair.To == Symbol.BTC)
				{
					availableBalance = balance.BTC.Available - udMaintanMinBalance.Value;
					amount = PurchaseAmount(order.Price, availableBalance);
				}

				if (amount <= (decimal) 0.00000001)
					return;
			}

			if (orderType == OrderType.Sell)
			{
				if (pair.From == Symbol.IXC)
				{
					availableBalance = balance.IXC.Available;

					if (availableBalance < (decimal) .00000001)
						return;
					decimal saleValue = order.Price*availableBalance;
					if (saleValue < (decimal) .00000001)
						return;
				}
			}

			order.Type = orderType;
			order.Amount = amount;

			try
			{
				OpenOrder orderDetails = await _cexClient.PlaceOrder(pair, order);
				_apiCallCount = ++_apiCallCount;

				decimal totalOrder = order.Price*order.Amount;
				decimal totalOrderCostRounded = Math.Round(totalOrder, 8);

				richTextBox1.AppendText(string.Format(@"Sold:{8} {1} @ {2} for {0} {7}: Total: {3} @ {4} -- Order #{5}{6}",
				                                      order.Amount,
				                                      pair.To,
				                                      order.Price,
				                                      totalOrderCostRounded,
				                                      DateTime.Now,
				                                      orderDetails.Id,
				                                      Environment.NewLine, pair.From,
				                                      Math.Round(orderDetails.Price*order.Amount, 8)));
				_ghsPurchased = _ghsPurchased + order.Amount;
				_orderCount = ++_orderCount;
				UpdateUi();
			}
			catch
			{
				Console.WriteLine(@"oops");

			}

		}


		private decimal PurchaseAmount(decimal bid, decimal currentBalance)
		{
			decimal amountToBuy = 0;
			decimal pricePer = bid;
			decimal fee = (amountToBuy*pricePer)*(decimal) .02;
			decimal total = pricePer*amountToBuy + fee;

			while (total < currentBalance)
			{
				amountToBuy = amountToBuy + (decimal) .00000001;
				fee = (amountToBuy*pricePer)*(decimal) .02;
				total = pricePer*amountToBuy + fee;
			}
			amountToBuy = amountToBuy - (decimal) .00000001;
			return amountToBuy;
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			button1_Click(null, null);
		}

		private void lblApiCallCount_TextChanged(object sender, EventArgs e)
		{
			_elapsedHours = _stopwatch.Elapsed.TotalHours;
			_callsPerHour = _apiCallCount/_elapsedHours;

			if (_callsPerHour > 500)
				timer1.Interval = timer1.Interval + 100;

			if (_callsPerHour < 500 && timer1.Interval > 8000)
				timer1.Interval = timer1.Interval = 8000;

			UpdateUi();

		}

		private void UpdateUi()
		{
			lblTmrInverval.Text = string.Format("Refresh Rate: {0} seconds", ((decimal) timer1.Interval/1000));
			lblOrderCount.Text = string.Format("Orders: {0}", _orderCount);
			lblOrdersPerHour.Text = string.Format("Orders Per Hour: {0}", Math.Round(_orderCount/_elapsedHours, 2));

			label3.Text = string.Format("Hours: {0} Calls Per Hour: {1}", Math.Round(_elapsedHours, 2),
			                            Math.Round(_callsPerHour, 2));

			if (_elapsedHours > 0)
			{
				lblBtcPerHour.Text = string.Format("BTC Per Hour: {0}", Math.Round(_btcEarned / (decimal)_elapsedHours, 8));
				lblBtcPerDay.Text = string.Format("BTC Per Day: {0}", Math.Round((_btcEarned / (decimal)_elapsedHours) * 24, 8));
				lblBtcPerWeek.Text = string.Format("BTC Per Week: {0}", Math.Round(((_btcEarned / (decimal)_elapsedHours) * 24)*7, 8));
				lblBtcPerMonth.Text = string.Format("BTC Per Month: {0}", Math.Round((((_btcEarned / (decimal)_elapsedHours) * 24)*7)*30, 8));
			}

			lblBtcEarned.Text = string.Format("BTC Earned: {0}", Math.Round(_btcEarned, 8));
				
			lblBtcValue.Text = _balance.BTC.Available.ToString();
			lblNmcValue.Text = _balance.NMC.Available.ToString();
			lblIXCValue.Text = _balance.IXC.Available.ToString();
			lblDvcValue.Text = _balance.DVC.Available.ToString();
			lblGhsValue.Text = _balance.GHS.Available.ToString();
			lblApiCallCount.Text = string.Format("Api Calls: {0}", _apiCallCount);
			lblPurchasedBtc.Text = string.Format("GHS Purchased: {0}", _ghsPurchased);
			if (_elapsedHours > 0)
			{
			lblghsPerHour.Text = string.Format("GHS Per Hour: {0}", Math.Round((_ghsPurchased/(decimal) _elapsedHours), 8));
			}
			lblLastUpdated.Text = @"Last update: " + DateTime.Now;
			richTextBox1.ScrollToCaret();

		}

		private void button2_Click(object sender, EventArgs e)
		{
			richTextBox1.Clear();
		}

		private void lblBtcValue_TextChanged(object sender, EventArgs e)
		{
			if (_balance.BTC.Available >= (decimal) 0.000001)
				PlaceOrder(SymbolPair.GHS_BTC, _balance, OrderType.Buy);


			if (Convert.ToDecimal(lblBtcValue.Text) > _previousBtcValue)
			{
				lblBtcValue.ForeColor = System.Drawing.Color.Green;
				
				if(!_firstRun)
					_btcEarned = (_btcEarned+(Convert.ToDecimal(lblBtcValue.Text)-_previousBtcValue));
				
				_firstRun = false;
			}
				

			if (Convert.ToDecimal(lblNmcValue.Text) == _previousBtcValue)
				lblBtcValue.ForeColor = System.Drawing.Color.Black;

			if (Convert.ToDecimal(lblBtcValue.Text) < _previousBtcValue)
				lblBtcValue.ForeColor = System.Drawing.Color.Red;
			

			_previousBtcValue = Convert.ToDecimal(lblBtcValue.Text);



		}

		private void lblNmcValue_TextChanged(object sender, EventArgs e)
		{
			if (_balance.NMC.Available >= (decimal) 0.000001)
				PlaceOrder(SymbolPair.GHS_NMC, _balance, OrderType.Buy);

			if (Convert.ToDecimal(lblNmcValue.Text) > _previousNmcValue)
				lblNmcValue.ForeColor = System.Drawing.Color.Green;

			if (Convert.ToDecimal(lblNmcValue.Text) == _previousNmcValue)
				lblNmcValue.ForeColor = System.Drawing.Color.Black;

			if (Convert.ToDecimal(lblNmcValue.Text) < _previousNmcValue)
				lblNmcValue.ForeColor = System.Drawing.Color.Red;

			_previousNmcValue = Convert.ToDecimal(lblNmcValue.Text);
		}



		private void lblIXCValue_TextChanged(object sender, EventArgs e)
		{
			if (_balance.IXC.Available >= (decimal) 0.000001)
				PlaceOrder(SymbolPair.IXC_BTC, _balance, OrderType.Sell);

			if (Convert.ToDecimal(lblIXCValue.Text) > _previousIxcValue)
				lblIXCValue.ForeColor = System.Drawing.Color.Green;

			if (Convert.ToDecimal(lblIXCValue.Text) == _previousIxcValue)
				lblIXCValue.ForeColor = System.Drawing.Color.Black;

			if (Convert.ToDecimal(lblIXCValue.Text) < _previousIxcValue)
				lblIXCValue.ForeColor = System.Drawing.Color.Red;

			_previousIxcValue = Convert.ToDecimal(lblIXCValue.Text);
		}

		private void lblGhsValue_TextChanged(object sender, EventArgs e)
		{
			if (Convert.ToDecimal(lblGhsValue.Text) > _previousGhsValue)
				lblGhsValue.ForeColor = System.Drawing.Color.Green;

			if (Convert.ToDecimal(lblGhsValue.Text) == _previousGhsValue)
				lblGhsValue.ForeColor = System.Drawing.Color.Black;

			if (Convert.ToDecimal(lblGhsValue.Text) < _previousGhsValue)
				lblGhsValue.ForeColor = System.Drawing.Color.Red;

			_previousGhsValue = Convert.ToDecimal(lblGhsValue.Text);
		}

		private void lblOrderCount_TextChanged(object sender, EventArgs e)
		{
			lblOrdersPerHour.Text = string.Format("Orders Per Hour: {0}", Math.Round(_orderCount/_elapsedHours, 2));
		}


		private void timer2_Tick_1(object sender, EventArgs e)
		{

		}

		private void udMaintanMinBalance_ValueChanged(object sender, EventArgs e)
		{
			Properties.Settings.Default["MaintainBalance"] = udMaintanMinBalance.Value;
			Properties.Settings.Default.Save();
		}
	}
}