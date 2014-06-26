namespace ghashIO
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.button2 = new System.Windows.Forms.Button();
			this.timer2 = new System.Windows.Forms.Timer(this.components);
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.tabPage4 = new System.Windows.Forms.TabPage();
			this.tabPage5 = new System.Windows.Forms.TabPage();
			this.label2 = new System.Windows.Forms.Label();
			this.lblBtcValue = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.lblNmcValue = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.lblIXCValue = new System.Windows.Forms.Label();
			this.lblDvcValueLabel = new System.Windows.Forms.Label();
			this.lblDvcValue = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.lblGhsValue = new System.Windows.Forms.Label();
			this.lblLastUpdated = new System.Windows.Forms.Label();
			this.lblTmrInverval = new System.Windows.Forms.Label();
			this.lblApiCallCount = new System.Windows.Forms.Label();
			this.lblOrderCount = new System.Windows.Forms.Label();
			this.lblOrdersPerHour = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.lblghsPerHour = new System.Windows.Forms.Label();
			this.lblPurchasedBtc = new System.Windows.Forms.Label();
			this.lblBtcEarned = new System.Windows.Forms.Label();
			this.lblBtcPerHour = new System.Windows.Forms.Label();
			this.lblBtcPerDay = new System.Windows.Forms.Label();
			this.lblBtcPerWeek = new System.Windows.Forms.Label();
			this.lblBtcPerMonth = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.udMaintanMinBalance = new System.Windows.Forms.NumericUpDown();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.tabPage3.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.tableLayoutPanel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.udMaintanMinBalance)).BeginInit();
			this.groupBox4.SuspendLayout();
			this.tableLayoutPanel4.SuspendLayout();
			this.SuspendLayout();
			// 
			// richTextBox1
			// 
			this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.richTextBox1.Location = new System.Drawing.Point(3, 3);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(1188, 522);
			this.richTextBox1.TabIndex = 0;
			this.richTextBox1.Text = "";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(629, 417);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 2;
			this.button1.Text = "lab";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Visible = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 10000;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(710, 417);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 7;
			this.button2.Text = "Clear!";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// timer2
			// 
			this.timer2.Enabled = true;
			this.timer2.Interval = 30000;
			this.timer2.Tick += new System.EventHandler(this.timer2_Tick_1);
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Controls.Add(this.tabPage4);
			this.tabControl1.Controls.Add(this.tabPage5);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(495, 285);
			this.tabControl1.TabIndex = 9;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.groupBox4);
			this.tabPage1.Controls.Add(this.lblLastUpdated);
			this.tabPage1.Controls.Add(this.groupBox3);
			this.tabPage1.Controls.Add(this.groupBox2);
			this.tabPage1.Controls.Add(this.groupBox1);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(487, 259);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Trading Stats";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.udMaintanMinBalance);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(487, 259);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Settings";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.richTextBox1);
			this.tabPage3.Location = new System.Drawing.Point(4, 22);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage3.Size = new System.Drawing.Size(1194, 528);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Log";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// tabPage4
			// 
			this.tabPage4.Location = new System.Drawing.Point(4, 22);
			this.tabPage4.Name = "tabPage4";
			this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage4.Size = new System.Drawing.Size(928, 351);
			this.tabPage4.TabIndex = 3;
			this.tabPage4.Text = "tabPage4";
			this.tabPage4.UseVisualStyleBackColor = true;
			// 
			// tabPage5
			// 
			this.tabPage5.Location = new System.Drawing.Point(4, 22);
			this.tabPage5.Name = "tabPage5";
			this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage5.Size = new System.Drawing.Size(928, 351);
			this.tabPage5.TabIndex = 4;
			this.tabPage5.Text = "tabPage5";
			this.tabPage5.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label2.Location = new System.Drawing.Point(3, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(31, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "BTC";
			this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// lblBtcValue
			// 
			this.lblBtcValue.AutoSize = true;
			this.lblBtcValue.Location = new System.Drawing.Point(40, 0);
			this.lblBtcValue.Name = "lblBtcValue";
			this.lblBtcValue.Size = new System.Drawing.Size(100, 13);
			this.lblBtcValue.TabIndex = 18;
			this.lblBtcValue.Text = "0000000.00000000";
			this.lblBtcValue.TextChanged += new System.EventHandler(this.lblBtcValue_TextChanged);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label10.Location = new System.Drawing.Point(3, 13);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(31, 13);
			this.label10.TabIndex = 9;
			this.label10.Text = "NMC";
			this.label10.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// lblNmcValue
			// 
			this.lblNmcValue.AutoSize = true;
			this.lblNmcValue.Location = new System.Drawing.Point(40, 13);
			this.lblNmcValue.Name = "lblNmcValue";
			this.lblNmcValue.Size = new System.Drawing.Size(100, 13);
			this.lblNmcValue.TabIndex = 23;
			this.lblNmcValue.Text = "0000000.00000000";
			this.lblNmcValue.TextChanged += new System.EventHandler(this.lblNmcValue_TextChanged);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label7.Location = new System.Drawing.Point(3, 26);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(31, 13);
			this.label7.TabIndex = 6;
			this.label7.Text = "IXC";
			this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// lblIXCValue
			// 
			this.lblIXCValue.AutoSize = true;
			this.lblIXCValue.Location = new System.Drawing.Point(40, 26);
			this.lblIXCValue.Name = "lblIXCValue";
			this.lblIXCValue.Size = new System.Drawing.Size(100, 13);
			this.lblIXCValue.TabIndex = 24;
			this.lblIXCValue.Text = "0000000.00000000";
			this.lblIXCValue.TextChanged += new System.EventHandler(this.lblIXCValue_TextChanged);
			// 
			// lblDvcValueLabel
			// 
			this.lblDvcValueLabel.AutoSize = true;
			this.lblDvcValueLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblDvcValueLabel.Location = new System.Drawing.Point(3, 39);
			this.lblDvcValueLabel.Name = "lblDvcValueLabel";
			this.lblDvcValueLabel.Size = new System.Drawing.Size(31, 13);
			this.lblDvcValueLabel.TabIndex = 7;
			this.lblDvcValueLabel.Text = "DVC";
			this.lblDvcValueLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// lblDvcValue
			// 
			this.lblDvcValue.AutoSize = true;
			this.lblDvcValue.Location = new System.Drawing.Point(40, 39);
			this.lblDvcValue.Name = "lblDvcValue";
			this.lblDvcValue.Size = new System.Drawing.Size(100, 13);
			this.lblDvcValue.TabIndex = 25;
			this.lblDvcValue.Text = "0000000.00000000";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label9.Location = new System.Drawing.Point(3, 52);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(31, 16);
			this.label9.TabIndex = 8;
			this.label9.Text = "GHS";
			this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// lblGhsValue
			// 
			this.lblGhsValue.AutoSize = true;
			this.lblGhsValue.Location = new System.Drawing.Point(40, 52);
			this.lblGhsValue.Name = "lblGhsValue";
			this.lblGhsValue.Size = new System.Drawing.Size(100, 13);
			this.lblGhsValue.TabIndex = 26;
			this.lblGhsValue.Text = "0000000.00000000";
			this.lblGhsValue.TextChanged += new System.EventHandler(this.lblGhsValue_TextChanged);
			// 
			// lblLastUpdated
			// 
			this.lblLastUpdated.AutoSize = true;
			this.lblLastUpdated.Location = new System.Drawing.Point(8, 207);
			this.lblLastUpdated.Name = "lblLastUpdated";
			this.lblLastUpdated.Size = new System.Drawing.Size(193, 13);
			this.lblLastUpdated.TabIndex = 4;
			this.lblLastUpdated.Text = "Last Update: 12/31/2014 12:59:59 PM";
			// 
			// lblTmrInverval
			// 
			this.lblTmrInverval.AutoSize = true;
			this.lblTmrInverval.Location = new System.Drawing.Point(3, 0);
			this.lblTmrInverval.Name = "lblTmrInverval";
			this.lblTmrInverval.Size = new System.Drawing.Size(137, 13);
			this.lblTmrInverval.TabIndex = 8;
			this.lblTmrInverval.Text = "Refresh Rate: 100 seconds";
			// 
			// lblApiCallCount
			// 
			this.lblApiCallCount.AutoSize = true;
			this.lblApiCallCount.Location = new System.Drawing.Point(3, 13);
			this.lblApiCallCount.Name = "lblApiCallCount";
			this.lblApiCallCount.Size = new System.Drawing.Size(95, 13);
			this.lblApiCallCount.TabIndex = 5;
			this.lblApiCallCount.Text = "Api Calls: 1000000";
			this.lblApiCallCount.TextChanged += new System.EventHandler(this.lblApiCallCount_TextChanged);
			// 
			// lblOrderCount
			// 
			this.lblOrderCount.AutoSize = true;
			this.lblOrderCount.Location = new System.Drawing.Point(3, 39);
			this.lblOrderCount.Name = "lblOrderCount";
			this.lblOrderCount.Size = new System.Drawing.Size(86, 13);
			this.lblOrderCount.TabIndex = 9;
			this.lblOrderCount.Text = "Orders: 9999999";
			this.lblOrderCount.TextChanged += new System.EventHandler(this.lblOrderCount_TextChanged);
			// 
			// lblOrdersPerHour
			// 
			this.lblOrdersPerHour.AutoSize = true;
			this.lblOrdersPerHour.Location = new System.Drawing.Point(3, 52);
			this.lblOrdersPerHour.Name = "lblOrdersPerHour";
			this.lblOrdersPerHour.Size = new System.Drawing.Size(128, 13);
			this.lblOrdersPerHour.TabIndex = 10;
			this.lblOrdersPerHour.Text = "Orders Per Hour: 9999.99";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(3, 26);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(195, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "Hours: 9999.99 Calls Per Hour: 9000.00";
			// 
			// lblghsPerHour
			// 
			this.lblghsPerHour.AutoSize = true;
			this.lblghsPerHour.Location = new System.Drawing.Point(3, 13);
			this.lblghsPerHour.Name = "lblghsPerHour";
			this.lblghsPerHour.Size = new System.Drawing.Size(150, 13);
			this.lblghsPerHour.TabIndex = 28;
			this.lblghsPerHour.Text = "GHS Per Hour: 000.00000000";
			// 
			// lblPurchasedBtc
			// 
			this.lblPurchasedBtc.AutoSize = true;
			this.lblPurchasedBtc.Location = new System.Drawing.Point(3, 0);
			this.lblPurchasedBtc.Name = "lblPurchasedBtc";
			this.lblPurchasedBtc.Size = new System.Drawing.Size(159, 13);
			this.lblPurchasedBtc.TabIndex = 27;
			this.lblPurchasedBtc.Text = "GHS Purchased: 000.00000000";
			// 
			// lblBtcEarned
			// 
			this.lblBtcEarned.AutoSize = true;
			this.lblBtcEarned.Location = new System.Drawing.Point(21, 19);
			this.lblBtcEarned.Name = "lblBtcEarned";
			this.lblBtcEarned.Size = new System.Drawing.Size(140, 13);
			this.lblBtcEarned.TabIndex = 29;
			this.lblBtcEarned.Text = "BTC Earned: 000.00000000";
			// 
			// lblBtcPerHour
			// 
			this.lblBtcPerHour.AutoSize = true;
			this.lblBtcPerHour.Location = new System.Drawing.Point(13, 32);
			this.lblBtcPerHour.Name = "lblBtcPerHour";
			this.lblBtcPerHour.Size = new System.Drawing.Size(148, 13);
			this.lblBtcPerHour.TabIndex = 30;
			this.lblBtcPerHour.Text = "BTC Per Hour: 000.00000000";
			// 
			// lblBtcPerDay
			// 
			this.lblBtcPerDay.AutoSize = true;
			this.lblBtcPerDay.Location = new System.Drawing.Point(17, 45);
			this.lblBtcPerDay.Name = "lblBtcPerDay";
			this.lblBtcPerDay.Size = new System.Drawing.Size(144, 13);
			this.lblBtcPerDay.TabIndex = 31;
			this.lblBtcPerDay.Text = "BTC Per Day: 000.00000000";
			// 
			// lblBtcPerWeek
			// 
			this.lblBtcPerWeek.AutoSize = true;
			this.lblBtcPerWeek.Location = new System.Drawing.Point(7, 58);
			this.lblBtcPerWeek.Name = "lblBtcPerWeek";
			this.lblBtcPerWeek.Size = new System.Drawing.Size(154, 13);
			this.lblBtcPerWeek.TabIndex = 32;
			this.lblBtcPerWeek.Text = "BTC Per Week: 000.00000000";
			// 
			// lblBtcPerMonth
			// 
			this.lblBtcPerMonth.AutoSize = true;
			this.lblBtcPerMonth.Location = new System.Drawing.Point(6, 71);
			this.lblBtcPerMonth.Name = "lblBtcPerMonth";
			this.lblBtcPerMonth.Size = new System.Drawing.Size(155, 13);
			this.lblBtcPerMonth.TabIndex = 33;
			this.lblBtcPerMonth.Text = "BTC Per Month: 000.00000000";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.tableLayoutPanel2);
			this.groupBox1.Location = new System.Drawing.Point(8, 6);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(164, 96);
			this.groupBox1.TabIndex = 9;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Balances";
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 2;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 37F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 29F));
			this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.lblGhsValue, 1, 4);
			this.tableLayoutPanel2.Controls.Add(this.label9, 0, 4);
			this.tableLayoutPanel2.Controls.Add(this.lblDvcValue, 1, 3);
			this.tableLayoutPanel2.Controls.Add(this.lblDvcValueLabel, 0, 3);
			this.tableLayoutPanel2.Controls.Add(this.lblIXCValue, 1, 2);
			this.tableLayoutPanel2.Controls.Add(this.label7, 0, 2);
			this.tableLayoutPanel2.Controls.Add(this.lblNmcValue, 1, 1);
			this.tableLayoutPanel2.Controls.Add(this.label10, 0, 1);
			this.tableLayoutPanel2.Controls.Add(this.lblBtcValue, 1, 0);
			this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 19);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 5;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.Size = new System.Drawing.Size(153, 68);
			this.tableLayoutPanel2.TabIndex = 0;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.lblBtcEarned);
			this.groupBox2.Controls.Add(this.lblBtcPerHour);
			this.groupBox2.Controls.Add(this.lblBtcPerDay);
			this.groupBox2.Controls.Add(this.lblBtcPerWeek);
			this.groupBox2.Controls.Add(this.lblBtcPerMonth);
			this.groupBox2.Location = new System.Drawing.Point(8, 108);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(166, 96);
			this.groupBox2.TabIndex = 10;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "BTC Earning Stats";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.tableLayoutPanel3);
			this.groupBox3.Location = new System.Drawing.Point(180, 108);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(219, 96);
			this.groupBox3.TabIndex = 11;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "GHS Earning Stats";
			// 
			// tableLayoutPanel3
			// 
			this.tableLayoutPanel3.ColumnCount = 1;
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 29F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel3.Controls.Add(this.lblghsPerHour, 0, 1);
			this.tableLayoutPanel3.Controls.Add(this.lblPurchasedBtc, 0, 0);
			this.tableLayoutPanel3.Location = new System.Drawing.Point(6, 19);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			this.tableLayoutPanel3.RowCount = 2;
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel3.Size = new System.Drawing.Size(169, 29);
			this.tableLayoutPanel3.TabIndex = 1;
			// 
			// udMaintanMinBalance
			// 
			this.udMaintanMinBalance.DecimalPlaces = 8;
			this.udMaintanMinBalance.Increment = new decimal(new int[] {
            1,
            0,
            0,
            393216});
			this.udMaintanMinBalance.Location = new System.Drawing.Point(30, 26);
			this.udMaintanMinBalance.Name = "udMaintanMinBalance";
			this.udMaintanMinBalance.Size = new System.Drawing.Size(85, 20);
			this.udMaintanMinBalance.TabIndex = 9;
			this.udMaintanMinBalance.Value = new decimal(new int[] {
            1,
            0,
            0,
            393216});
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.tableLayoutPanel4);
			this.groupBox4.Location = new System.Drawing.Point(180, 7);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(219, 95);
			this.groupBox4.TabIndex = 12;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "UI Statistics";
			// 
			// tableLayoutPanel4
			// 
			this.tableLayoutPanel4.ColumnCount = 1;
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel4.Controls.Add(this.lblTmrInverval, 0, 0);
			this.tableLayoutPanel4.Controls.Add(this.lblApiCallCount, 0, 1);
			this.tableLayoutPanel4.Controls.Add(this.lblOrdersPerHour, 0, 4);
			this.tableLayoutPanel4.Controls.Add(this.lblOrderCount, 0, 3);
			this.tableLayoutPanel4.Controls.Add(this.label3, 0, 2);
			this.tableLayoutPanel4.Location = new System.Drawing.Point(12, 18);
			this.tableLayoutPanel4.Name = "tableLayoutPanel4";
			this.tableLayoutPanel4.RowCount = 5;
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel4.Size = new System.Drawing.Size(201, 68);
			this.tableLayoutPanel4.TabIndex = 0;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(495, 285);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.tabPage3.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.tableLayoutPanel3.ResumeLayout(false);
			this.tableLayoutPanel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.udMaintanMinBalance)).EndInit();
			this.groupBox4.ResumeLayout(false);
			this.tableLayoutPanel4.ResumeLayout(false);
			this.tableLayoutPanel4.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Timer timer2;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblGhsValue;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label lblDvcValue;
		private System.Windows.Forms.Label lblDvcValueLabel;
		private System.Windows.Forms.Label lblIXCValue;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label lblNmcValue;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label lblBtcValue;
		private System.Windows.Forms.Label lblLastUpdated;
		private System.Windows.Forms.Label lblTmrInverval;
		private System.Windows.Forms.Label lblApiCallCount;
		private System.Windows.Forms.Label lblOrderCount;
		private System.Windows.Forms.Label lblOrdersPerHour;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lblghsPerHour;
		private System.Windows.Forms.Label lblPurchasedBtc;
		private System.Windows.Forms.Label lblBtcEarned;
		private System.Windows.Forms.Label lblBtcPerHour;
		private System.Windows.Forms.Label lblBtcPerDay;
		private System.Windows.Forms.Label lblBtcPerWeek;
		private System.Windows.Forms.Label lblBtcPerMonth;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.TabPage tabPage4;
		private System.Windows.Forms.TabPage tabPage5;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
		private System.Windows.Forms.NumericUpDown udMaintanMinBalance;
    }
}

