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
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.label1 = new System.Windows.Forms.Label();
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
			this.button2 = new System.Windows.Forms.Button();
			this.timer2 = new System.Windows.Forms.Timer(this.components);
			this.udMaintanMinBalance = new System.Windows.Forms.NumericUpDown();
			this.lblBtcPerWeek = new System.Windows.Forms.Label();
			this.lblBtcPerMonth = new System.Windows.Forms.Label();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.udMaintanMinBalance)).BeginInit();
			this.SuspendLayout();
			// 
			// richTextBox1
			// 
			this.richTextBox1.Location = new System.Drawing.Point(8, 103);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(772, 308);
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
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel1.AutoSize = true;
			this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
			this.tableLayoutPanel1.ColumnCount = 5;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 57F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 183F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 188F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
			this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.lblBtcValue, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.label10, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.lblNmcValue, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.label7, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.lblIXCValue, 1, 3);
			this.tableLayoutPanel1.Controls.Add(this.lblDvcValueLabel, 0, 4);
			this.tableLayoutPanel1.Controls.Add(this.lblDvcValue, 1, 4);
			this.tableLayoutPanel1.Controls.Add(this.label9, 0, 5);
			this.tableLayoutPanel1.Controls.Add(this.lblGhsValue, 1, 5);
			this.tableLayoutPanel1.Controls.Add(this.lblLastUpdated, 3, 0);
			this.tableLayoutPanel1.Controls.Add(this.lblTmrInverval, 2, 1);
			this.tableLayoutPanel1.Controls.Add(this.lblApiCallCount, 2, 2);
			this.tableLayoutPanel1.Controls.Add(this.lblOrderCount, 2, 3);
			this.tableLayoutPanel1.Controls.Add(this.lblOrdersPerHour, 2, 4);
			this.tableLayoutPanel1.Controls.Add(this.label3, 2, 5);
			this.tableLayoutPanel1.Controls.Add(this.lblghsPerHour, 3, 5);
			this.tableLayoutPanel1.Controls.Add(this.lblPurchasedBtc, 3, 4);
			this.tableLayoutPanel1.Controls.Add(this.lblBtcEarned, 4, 1);
			this.tableLayoutPanel1.Controls.Add(this.lblBtcPerHour, 4, 2);
			this.tableLayoutPanel1.Controls.Add(this.lblBtcPerDay, 4, 3);
			this.tableLayoutPanel1.Controls.Add(this.lblBtcPerWeek, 4, 4);
			this.tableLayoutPanel1.Controls.Add(this.lblBtcPerMonth, 4, 5);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 6;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.Size = new System.Drawing.Size(677, 85);
			this.tableLayoutPanel1.TabIndex = 3;
			this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(4, 1);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(51, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Balances";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(4, 15);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(28, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "BTC";
			this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// lblBtcValue
			// 
			this.lblBtcValue.AutoSize = true;
			this.lblBtcValue.Location = new System.Drawing.Point(62, 15);
			this.lblBtcValue.Name = "lblBtcValue";
			this.lblBtcValue.Size = new System.Drawing.Size(64, 13);
			this.lblBtcValue.TabIndex = 18;
			this.lblBtcValue.Text = "0.00000000";
			this.lblBtcValue.TextChanged += new System.EventHandler(this.lblBtcValue_TextChanged);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(4, 29);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(31, 13);
			this.label10.TabIndex = 9;
			this.label10.Text = "NMC";
			this.label10.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// lblNmcValue
			// 
			this.lblNmcValue.AutoSize = true;
			this.lblNmcValue.Location = new System.Drawing.Point(62, 29);
			this.lblNmcValue.Name = "lblNmcValue";
			this.lblNmcValue.Size = new System.Drawing.Size(64, 13);
			this.lblNmcValue.TabIndex = 23;
			this.lblNmcValue.Text = "0.00000000";
			this.lblNmcValue.TextChanged += new System.EventHandler(this.lblNmcValue_TextChanged);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(4, 43);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(24, 13);
			this.label7.TabIndex = 6;
			this.label7.Text = "IXC";
			this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// lblIXCValue
			// 
			this.lblIXCValue.AutoSize = true;
			this.lblIXCValue.Location = new System.Drawing.Point(62, 43);
			this.lblIXCValue.Name = "lblIXCValue";
			this.lblIXCValue.Size = new System.Drawing.Size(64, 13);
			this.lblIXCValue.TabIndex = 24;
			this.lblIXCValue.Text = "0.00000000";
			this.lblIXCValue.TextChanged += new System.EventHandler(this.lblIXCValue_TextChanged);
			// 
			// lblDvcValueLabel
			// 
			this.lblDvcValueLabel.AutoSize = true;
			this.lblDvcValueLabel.Location = new System.Drawing.Point(4, 57);
			this.lblDvcValueLabel.Name = "lblDvcValueLabel";
			this.lblDvcValueLabel.Size = new System.Drawing.Size(29, 13);
			this.lblDvcValueLabel.TabIndex = 7;
			this.lblDvcValueLabel.Text = "DVC";
			this.lblDvcValueLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// lblDvcValue
			// 
			this.lblDvcValue.AutoSize = true;
			this.lblDvcValue.Location = new System.Drawing.Point(62, 57);
			this.lblDvcValue.Name = "lblDvcValue";
			this.lblDvcValue.Size = new System.Drawing.Size(64, 13);
			this.lblDvcValue.TabIndex = 25;
			this.lblDvcValue.Text = "0.00000000";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(4, 71);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(30, 13);
			this.label9.TabIndex = 8;
			this.label9.Text = "GHS";
			this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// lblGhsValue
			// 
			this.lblGhsValue.AutoSize = true;
			this.lblGhsValue.Location = new System.Drawing.Point(62, 71);
			this.lblGhsValue.Name = "lblGhsValue";
			this.lblGhsValue.Size = new System.Drawing.Size(64, 13);
			this.lblGhsValue.TabIndex = 26;
			this.lblGhsValue.Text = "0.00000000";
			this.lblGhsValue.TextChanged += new System.EventHandler(this.lblGhsValue_TextChanged);
			// 
			// lblLastUpdated
			// 
			this.lblLastUpdated.AutoSize = true;
			this.lblLastUpdated.Location = new System.Drawing.Point(317, 1);
			this.lblLastUpdated.Name = "lblLastUpdated";
			this.lblLastUpdated.Size = new System.Drawing.Size(74, 13);
			this.lblLastUpdated.TabIndex = 4;
			this.lblLastUpdated.Text = "Last Update: -";
			// 
			// lblTmrInverval
			// 
			this.lblTmrInverval.AutoSize = true;
			this.lblTmrInverval.Location = new System.Drawing.Point(133, 15);
			this.lblTmrInverval.Name = "lblTmrInverval";
			this.lblTmrInverval.Size = new System.Drawing.Size(31, 13);
			this.lblTmrInverval.TabIndex = 8;
			this.lblTmrInverval.Text = "5000";
			// 
			// lblApiCallCount
			// 
			this.lblApiCallCount.AutoSize = true;
			this.lblApiCallCount.Location = new System.Drawing.Point(133, 29);
			this.lblApiCallCount.Name = "lblApiCallCount";
			this.lblApiCallCount.Size = new System.Drawing.Size(21, 13);
			this.lblApiCallCount.TabIndex = 5;
			this.lblApiCallCount.Text = "lab";
			this.lblApiCallCount.TextChanged += new System.EventHandler(this.lblApiCallCount_TextChanged);
			// 
			// lblOrderCount
			// 
			this.lblOrderCount.AutoSize = true;
			this.lblOrderCount.Location = new System.Drawing.Point(133, 43);
			this.lblOrderCount.Name = "lblOrderCount";
			this.lblOrderCount.Size = new System.Drawing.Size(50, 13);
			this.lblOrderCount.TabIndex = 9;
			this.lblOrderCount.Text = "Orders: 0";
			this.lblOrderCount.TextChanged += new System.EventHandler(this.lblOrderCount_TextChanged);
			// 
			// lblOrdersPerHour
			// 
			this.lblOrdersPerHour.AutoSize = true;
			this.lblOrdersPerHour.Location = new System.Drawing.Point(133, 57);
			this.lblOrdersPerHour.Name = "lblOrdersPerHour";
			this.lblOrdersPerHour.Size = new System.Drawing.Size(110, 13);
			this.lblOrdersPerHour.TabIndex = 10;
			this.lblOrdersPerHour.Text = "Orders Per Hour: 0.00";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(133, 71);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(35, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "label3";
			// 
			// lblghsPerHour
			// 
			this.lblghsPerHour.AutoSize = true;
			this.lblghsPerHour.Location = new System.Drawing.Point(317, 71);
			this.lblghsPerHour.Name = "lblghsPerHour";
			this.lblghsPerHour.Size = new System.Drawing.Size(138, 13);
			this.lblghsPerHour.TabIndex = 28;
			this.lblghsPerHour.Text = "GHS Per Hour: 0.00000000";
			// 
			// lblPurchasedBtc
			// 
			this.lblPurchasedBtc.AutoSize = true;
			this.lblPurchasedBtc.Location = new System.Drawing.Point(317, 57);
			this.lblPurchasedBtc.Name = "lblPurchasedBtc";
			this.lblPurchasedBtc.Size = new System.Drawing.Size(22, 13);
			this.lblPurchasedBtc.TabIndex = 27;
			this.lblPurchasedBtc.Text = "0.0";
			// 
			// lblBtcEarned
			// 
			this.lblBtcEarned.AutoSize = true;
			this.lblBtcEarned.Location = new System.Drawing.Point(506, 15);
			this.lblBtcEarned.Name = "lblBtcEarned";
			this.lblBtcEarned.Size = new System.Drawing.Size(13, 13);
			this.lblBtcEarned.TabIndex = 29;
			this.lblBtcEarned.Text = "0";
			// 
			// lblBtcPerHour
			// 
			this.lblBtcPerHour.AutoSize = true;
			this.lblBtcPerHour.Location = new System.Drawing.Point(506, 29);
			this.lblBtcPerHour.Name = "lblBtcPerHour";
			this.lblBtcPerHour.Size = new System.Drawing.Size(13, 13);
			this.lblBtcPerHour.TabIndex = 30;
			this.lblBtcPerHour.Text = "0";
			// 
			// lblBtcPerDay
			// 
			this.lblBtcPerDay.AutoSize = true;
			this.lblBtcPerDay.Location = new System.Drawing.Point(506, 43);
			this.lblBtcPerDay.Name = "lblBtcPerDay";
			this.lblBtcPerDay.Size = new System.Drawing.Size(13, 13);
			this.lblBtcPerDay.TabIndex = 31;
			this.lblBtcPerDay.Text = "0";
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
			// udMaintanMinBalance
			// 
			this.udMaintanMinBalance.DecimalPlaces = 8;
			this.udMaintanMinBalance.Increment = new decimal(new int[] {
            1,
            0,
            0,
            393216});
			this.udMaintanMinBalance.Location = new System.Drawing.Point(695, 76);
			this.udMaintanMinBalance.Name = "udMaintanMinBalance";
			this.udMaintanMinBalance.Size = new System.Drawing.Size(85, 20);
			this.udMaintanMinBalance.TabIndex = 8;
			this.udMaintanMinBalance.Value = new decimal(new int[] {
            1,
            0,
            0,
            393216});
			this.udMaintanMinBalance.ValueChanged += new System.EventHandler(this.udMaintanMinBalance_ValueChanged);
			// 
			// lblBtcPerWeek
			// 
			this.lblBtcPerWeek.AutoSize = true;
			this.lblBtcPerWeek.Location = new System.Drawing.Point(506, 57);
			this.lblBtcPerWeek.Name = "lblBtcPerWeek";
			this.lblBtcPerWeek.Size = new System.Drawing.Size(35, 13);
			this.lblBtcPerWeek.TabIndex = 32;
			this.lblBtcPerWeek.Text = "label4";
			// 
			// lblBtcPerMonth
			// 
			this.lblBtcPerMonth.AutoSize = true;
			this.lblBtcPerMonth.Location = new System.Drawing.Point(506, 71);
			this.lblBtcPerMonth.Name = "lblBtcPerMonth";
			this.lblBtcPerMonth.Size = new System.Drawing.Size(143, 13);
			this.lblBtcPerMonth.TabIndex = 33;
			this.lblBtcPerMonth.Text = "BTC Per Month: 0.00000000";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(797, 444);
			this.Controls.Add(this.udMaintanMinBalance);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.richTextBox1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.udMaintanMinBalance)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblGhsValue;
        private System.Windows.Forms.Label lblDvcValue;
        private System.Windows.Forms.Label lblIXCValue;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblNmcValue;
        private System.Windows.Forms.Label lblBtcValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblDvcValueLabel;
        private System.Windows.Forms.Label lblLastUpdated;
		private System.Windows.Forms.Label lblApiCallCount;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label lblTmrInverval;
		private System.Windows.Forms.Label lblOrderCount;
        private System.Windows.Forms.Label lblOrdersPerHour;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label lblPurchasedBtc;
		private System.Windows.Forms.Label lblghsPerHour;
		private System.Windows.Forms.NumericUpDown udMaintanMinBalance;
		private System.Windows.Forms.Label lblBtcEarned;
		private System.Windows.Forms.Label lblBtcPerHour;
		private System.Windows.Forms.Label lblBtcPerDay;
		private System.Windows.Forms.Label lblBtcPerWeek;
		private System.Windows.Forms.Label lblBtcPerMonth;
    }
}

