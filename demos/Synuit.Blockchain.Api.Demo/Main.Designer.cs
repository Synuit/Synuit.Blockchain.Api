namespace Synuit.Coin.Market.Stats
{
   partial class frmMain
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
            this.btnCryptoCompare = new System.Windows.Forms.Button();
            this.btnWhatToMne = new System.Windows.Forms.Button();
            this.pnlHistoDay = new System.Windows.Forms.Panel();
            this.txtHistPriceLow = new System.Windows.Forms.TextBox();
            this.txtHistPriceHigh = new System.Windows.Forms.TextBox();
            this.txtHistPriceOpen = new System.Windows.Forms.TextBox();
            this.lblHistPriceLow = new System.Windows.Forms.Label();
            this.lblHistPriceHigh = new System.Windows.Forms.Label();
            this.lblHistPriceOpen = new System.Windows.Forms.Label();
            this.btnRunHistoDayLow = new System.Windows.Forms.Button();
            this.btnRunHistoDayHigh = new System.Windows.Forms.Button();
            this.btnRunHistoDayOpen = new System.Windows.Forms.Button();
            this.txtHistPriceClose = new System.Windows.Forms.TextBox();
            this.lblHistPriceClose = new System.Windows.Forms.Label();
            this.btnRunHistoDayClose = new System.Windows.Forms.Button();
            this.dtpTargetDate = new System.Windows.Forms.DateTimePicker();
            this.txtTargetCoin = new System.Windows.Forms.TextBox();
            this.lblTargetDate = new System.Windows.Forms.Label();
            this.lblTargetCoin = new System.Windows.Forms.Label();
            this.lblHeaderHistPrice = new System.Windows.Forms.Label();
            this.pnlSnapshot = new System.Windows.Forms.Panel();
            this.btnRunCoinSnapshot = new System.Windows.Forms.Button();
            this.txtTargetCoinList = new System.Windows.Forms.TextBox();
            this.lblTargetCoinList = new System.Windows.Forms.Label();
            this.lblHeaderCoinSnapshot = new System.Windows.Forms.Label();
            this.pnlHistoDay.SuspendLayout();
            this.pnlSnapshot.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCryptoCompare
            // 
            this.btnCryptoCompare.Location = new System.Drawing.Point(30, 12);
            this.btnCryptoCompare.Name = "btnCryptoCompare";
            this.btnCryptoCompare.Size = new System.Drawing.Size(168, 34);
            this.btnCryptoCompare.TabIndex = 0;
            this.btnCryptoCompare.Text = "CryptoCompare.com";
            this.btnCryptoCompare.UseVisualStyleBackColor = true;
            this.btnCryptoCompare.Click += new System.EventHandler(this.btnCryptoCompare_Click);
            // 
            // btnWhatToMne
            // 
            this.btnWhatToMne.Enabled = false;
            this.btnWhatToMne.Location = new System.Drawing.Point(233, 12);
            this.btnWhatToMne.Name = "btnWhatToMne";
            this.btnWhatToMne.Size = new System.Drawing.Size(168, 34);
            this.btnWhatToMne.TabIndex = 1;
            this.btnWhatToMne.Text = "WhatToMine.com";
            this.btnWhatToMne.UseVisualStyleBackColor = true;
            this.btnWhatToMne.Visible = false;
            this.btnWhatToMne.Click += new System.EventHandler(this.btnWhatToMine_Click);
            // 
            // pnlHistoDay
            // 
            this.pnlHistoDay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlHistoDay.Controls.Add(this.txtHistPriceLow);
            this.pnlHistoDay.Controls.Add(this.txtHistPriceHigh);
            this.pnlHistoDay.Controls.Add(this.txtHistPriceOpen);
            this.pnlHistoDay.Controls.Add(this.lblHistPriceLow);
            this.pnlHistoDay.Controls.Add(this.lblHistPriceHigh);
            this.pnlHistoDay.Controls.Add(this.lblHistPriceOpen);
            this.pnlHistoDay.Controls.Add(this.btnRunHistoDayLow);
            this.pnlHistoDay.Controls.Add(this.btnRunHistoDayHigh);
            this.pnlHistoDay.Controls.Add(this.btnRunHistoDayOpen);
            this.pnlHistoDay.Controls.Add(this.txtHistPriceClose);
            this.pnlHistoDay.Controls.Add(this.lblHistPriceClose);
            this.pnlHistoDay.Controls.Add(this.btnRunHistoDayClose);
            this.pnlHistoDay.Controls.Add(this.dtpTargetDate);
            this.pnlHistoDay.Controls.Add(this.txtTargetCoin);
            this.pnlHistoDay.Controls.Add(this.lblTargetDate);
            this.pnlHistoDay.Controls.Add(this.lblTargetCoin);
            this.pnlHistoDay.Controls.Add(this.lblHeaderHistPrice);
            this.pnlHistoDay.Location = new System.Drawing.Point(30, 93);
            this.pnlHistoDay.Name = "pnlHistoDay";
            this.pnlHistoDay.Size = new System.Drawing.Size(634, 133);
            this.pnlHistoDay.TabIndex = 2;
            // 
            // txtHistPriceLow
            // 
            this.txtHistPriceLow.Enabled = false;
            this.txtHistPriceLow.Location = new System.Drawing.Point(535, 103);
            this.txtHistPriceLow.Name = "txtHistPriceLow";
            this.txtHistPriceLow.Size = new System.Drawing.Size(64, 20);
            this.txtHistPriceLow.TabIndex = 16;
            // 
            // txtHistPriceHigh
            // 
            this.txtHistPriceHigh.Enabled = false;
            this.txtHistPriceHigh.Location = new System.Drawing.Point(379, 103);
            this.txtHistPriceHigh.Name = "txtHistPriceHigh";
            this.txtHistPriceHigh.Size = new System.Drawing.Size(64, 20);
            this.txtHistPriceHigh.TabIndex = 15;
            // 
            // txtHistPriceOpen
            // 
            this.txtHistPriceOpen.Enabled = false;
            this.txtHistPriceOpen.Location = new System.Drawing.Point(240, 103);
            this.txtHistPriceOpen.Name = "txtHistPriceOpen";
            this.txtHistPriceOpen.Size = new System.Drawing.Size(64, 20);
            this.txtHistPriceOpen.TabIndex = 14;
            // 
            // lblHistPriceLow
            // 
            this.lblHistPriceLow.AutoSize = true;
            this.lblHistPriceLow.Location = new System.Drawing.Point(475, 106);
            this.lblHistPriceLow.Name = "lblHistPriceLow";
            this.lblHistPriceLow.Size = new System.Drawing.Size(54, 13);
            this.lblHistPriceLow.TabIndex = 13;
            this.lblHistPriceLow.Text = "Low Price";
            // 
            // lblHistPriceHigh
            // 
            this.lblHistPriceHigh.AutoSize = true;
            this.lblHistPriceHigh.Location = new System.Drawing.Point(319, 106);
            this.lblHistPriceHigh.Name = "lblHistPriceHigh";
            this.lblHistPriceHigh.Size = new System.Drawing.Size(56, 13);
            this.lblHistPriceHigh.TabIndex = 12;
            this.lblHistPriceHigh.Text = "High Price";
            // 
            // lblHistPriceOpen
            // 
            this.lblHistPriceOpen.AutoSize = true;
            this.lblHistPriceOpen.Location = new System.Drawing.Point(164, 104);
            this.lblHistPriceOpen.Name = "lblHistPriceOpen";
            this.lblHistPriceOpen.Size = new System.Drawing.Size(74, 13);
            this.lblHistPriceOpen.TabIndex = 11;
            this.lblHistPriceOpen.Text = "Opening Price";
            // 
            // btnRunHistoDayLow
            // 
            this.btnRunHistoDayLow.Location = new System.Drawing.Point(473, 65);
            this.btnRunHistoDayLow.Name = "btnRunHistoDayLow";
            this.btnRunHistoDayLow.Size = new System.Drawing.Size(150, 28);
            this.btnRunHistoDayLow.TabIndex = 10;
            this.btnRunHistoDayLow.Text = "Get Historical Low Price";
            this.btnRunHistoDayLow.UseVisualStyleBackColor = true;
            this.btnRunHistoDayLow.Click += new System.EventHandler(this.btnRunHistoDayLow_Click);
            // 
            // btnRunHistoDayHigh
            // 
            this.btnRunHistoDayHigh.Location = new System.Drawing.Point(318, 65);
            this.btnRunHistoDayHigh.Name = "btnRunHistoDayHigh";
            this.btnRunHistoDayHigh.Size = new System.Drawing.Size(150, 28);
            this.btnRunHistoDayHigh.TabIndex = 9;
            this.btnRunHistoDayHigh.Text = "Get Historical High Price";
            this.btnRunHistoDayHigh.UseVisualStyleBackColor = true;
            this.btnRunHistoDayHigh.Click += new System.EventHandler(this.btnRunHistoDayHigh_Click);
            // 
            // btnRunHistoDayOpen
            // 
            this.btnRunHistoDayOpen.Location = new System.Drawing.Point(163, 65);
            this.btnRunHistoDayOpen.Name = "btnRunHistoDayOpen";
            this.btnRunHistoDayOpen.Size = new System.Drawing.Size(150, 28);
            this.btnRunHistoDayOpen.TabIndex = 8;
            this.btnRunHistoDayOpen.Text = "Get Historical Opening Price";
            this.btnRunHistoDayOpen.UseVisualStyleBackColor = true;
            this.btnRunHistoDayOpen.Click += new System.EventHandler(this.btnRunHistoDayOpen_Click);
            // 
            // txtHistPriceClose
            // 
            this.txtHistPriceClose.Enabled = false;
            this.txtHistPriceClose.Location = new System.Drawing.Point(79, 103);
            this.txtHistPriceClose.Name = "txtHistPriceClose";
            this.txtHistPriceClose.Size = new System.Drawing.Size(64, 20);
            this.txtHistPriceClose.TabIndex = 7;
            // 
            // lblHistPriceClose
            // 
            this.lblHistPriceClose.AutoSize = true;
            this.lblHistPriceClose.Location = new System.Drawing.Point(8, 104);
            this.lblHistPriceClose.Name = "lblHistPriceClose";
            this.lblHistPriceClose.Size = new System.Drawing.Size(68, 13);
            this.lblHistPriceClose.TabIndex = 6;
            this.lblHistPriceClose.Text = "Closing Price";
            // 
            // btnRunHistoDayClose
            // 
            this.btnRunHistoDayClose.Location = new System.Drawing.Point(8, 65);
            this.btnRunHistoDayClose.Name = "btnRunHistoDayClose";
            this.btnRunHistoDayClose.Size = new System.Drawing.Size(150, 28);
            this.btnRunHistoDayClose.TabIndex = 5;
            this.btnRunHistoDayClose.Text = "Get Historical Closing Price";
            this.btnRunHistoDayClose.UseVisualStyleBackColor = true;
            this.btnRunHistoDayClose.Click += new System.EventHandler(this.btnRunHistoDayClose_Click);
            // 
            // dtpTargetDate
            // 
            this.dtpTargetDate.AllowDrop = true;
            this.dtpTargetDate.Location = new System.Drawing.Point(283, 29);
            this.dtpTargetDate.Name = "dtpTargetDate";
            this.dtpTargetDate.Size = new System.Drawing.Size(200, 20);
            this.dtpTargetDate.TabIndex = 4;
            this.dtpTargetDate.ValueChanged += new System.EventHandler(this.dtpTargetDate_ValueChanged);
            // 
            // txtTargetCoin
            // 
            this.txtTargetCoin.Location = new System.Drawing.Point(87, 27);
            this.txtTargetCoin.Name = "txtTargetCoin";
            this.txtTargetCoin.Size = new System.Drawing.Size(62, 20);
            this.txtTargetCoin.TabIndex = 3;
            this.txtTargetCoin.TextChanged += new System.EventHandler(this.txtTargetCoin_TextChanged);
            // 
            // lblTargetDate
            // 
            this.lblTargetDate.AutoSize = true;
            this.lblTargetDate.Location = new System.Drawing.Point(200, 31);
            this.lblTargetDate.Name = "lblTargetDate";
            this.lblTargetDate.Size = new System.Drawing.Size(76, 13);
            this.lblTargetDate.TabIndex = 2;
            this.lblTargetDate.Text = "Historical Date";
            // 
            // lblTargetCoin
            // 
            this.lblTargetCoin.AutoSize = true;
            this.lblTargetCoin.Location = new System.Drawing.Point(16, 31);
            this.lblTargetCoin.Name = "lblTargetCoin";
            this.lblTargetCoin.Size = new System.Drawing.Size(65, 13);
            this.lblTargetCoin.TabIndex = 1;
            this.lblTargetCoin.Text = "Coin Symbol";
            // 
            // lblHeaderHistPrice
            // 
            this.lblHeaderHistPrice.AutoSize = true;
            this.lblHeaderHistPrice.Location = new System.Drawing.Point(7, 4);
            this.lblHeaderHistPrice.Name = "lblHeaderHistPrice";
            this.lblHeaderHistPrice.Size = new System.Drawing.Size(86, 13);
            this.lblHeaderHistPrice.TabIndex = 0;
            this.lblHeaderHistPrice.Text = "Price As Of Date";
            // 
            // pnlSnapshot
            // 
            this.pnlSnapshot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSnapshot.Controls.Add(this.btnRunCoinSnapshot);
            this.pnlSnapshot.Controls.Add(this.txtTargetCoinList);
            this.pnlSnapshot.Controls.Add(this.lblTargetCoinList);
            this.pnlSnapshot.Controls.Add(this.lblHeaderCoinSnapshot);
            this.pnlSnapshot.Location = new System.Drawing.Point(30, 277);
            this.pnlSnapshot.Name = "pnlSnapshot";
            this.pnlSnapshot.Size = new System.Drawing.Size(634, 59);
            this.pnlSnapshot.TabIndex = 3;
            // 
            // btnRunCoinSnapshot
            // 
            this.btnRunCoinSnapshot.Location = new System.Drawing.Point(449, 16);
            this.btnRunCoinSnapshot.Name = "btnRunCoinSnapshot";
            this.btnRunCoinSnapshot.Size = new System.Drawing.Size(150, 28);
            this.btnRunCoinSnapshot.TabIndex = 6;
            this.btnRunCoinSnapshot.Text = "Get Coin Snapshot Info";
            this.btnRunCoinSnapshot.UseVisualStyleBackColor = true;
            this.btnRunCoinSnapshot.Click += new System.EventHandler(this.btnRunCoinSnapshot_Click);
            // 
            // txtTargetCoinList
            // 
            this.txtTargetCoinList.Location = new System.Drawing.Point(204, 20);
            this.txtTargetCoinList.Name = "txtTargetCoinList";
            this.txtTargetCoinList.Size = new System.Drawing.Size(205, 20);
            this.txtTargetCoinList.TabIndex = 5;
            // 
            // lblTargetCoinList
            // 
            this.lblTargetCoinList.AutoSize = true;
            this.lblTargetCoinList.Location = new System.Drawing.Point(16, 24);
            this.lblTargetCoinList.Name = "lblTargetCoinList";
            this.lblTargetCoinList.Size = new System.Drawing.Size(182, 13);
            this.lblTargetCoinList.TabIndex = 4;
            this.lblTargetCoinList.Text = "Coin Symbol Comma Sep List Max 10";
            // 
            // lblHeaderCoinSnapshot
            // 
            this.lblHeaderCoinSnapshot.AutoSize = true;
            this.lblHeaderCoinSnapshot.Location = new System.Drawing.Point(7, 5);
            this.lblHeaderCoinSnapshot.Name = "lblHeaderCoinSnapshot";
            this.lblHeaderCoinSnapshot.Size = new System.Drawing.Size(76, 13);
            this.lblHeaderCoinSnapshot.TabIndex = 1;
            this.lblHeaderCoinSnapshot.Text = "Coin Snapshot";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 348);
            this.Controls.Add(this.pnlSnapshot);
            this.Controls.Add(this.pnlHistoDay);
            this.Controls.Add(this.btnWhatToMne);
            this.Controls.Add(this.btnCryptoCompare);
            this.Name = "frmMain";
            this.Text = "Synuit.Coin - Crypto Stats and Markets Data";
            this.pnlHistoDay.ResumeLayout(false);
            this.pnlHistoDay.PerformLayout();
            this.pnlSnapshot.ResumeLayout(false);
            this.pnlSnapshot.PerformLayout();
            this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.Button btnCryptoCompare;
      private System.Windows.Forms.Button btnWhatToMne;
        private System.Windows.Forms.Panel pnlHistoDay;
        private System.Windows.Forms.DateTimePicker dtpTargetDate;
        private System.Windows.Forms.TextBox txtTargetCoin;
        private System.Windows.Forms.Label lblTargetDate;
        private System.Windows.Forms.Label lblTargetCoin;
        private System.Windows.Forms.Label lblHeaderHistPrice;
        private System.Windows.Forms.Button btnRunHistoDayClose;
        private System.Windows.Forms.TextBox txtHistPriceClose;
        private System.Windows.Forms.Label lblHistPriceClose;
        private System.Windows.Forms.Label lblHistPriceLow;
        private System.Windows.Forms.Label lblHistPriceHigh;
        private System.Windows.Forms.Label lblHistPriceOpen;
        private System.Windows.Forms.Button btnRunHistoDayLow;
        private System.Windows.Forms.Button btnRunHistoDayHigh;
        private System.Windows.Forms.Button btnRunHistoDayOpen;
        private System.Windows.Forms.TextBox txtHistPriceOpen;
        private System.Windows.Forms.TextBox txtHistPriceLow;
        private System.Windows.Forms.TextBox txtHistPriceHigh;
        private System.Windows.Forms.Panel pnlSnapshot;
        private System.Windows.Forms.TextBox txtTargetCoinList;
        private System.Windows.Forms.Label lblTargetCoinList;
        private System.Windows.Forms.Label lblHeaderCoinSnapshot;
        private System.Windows.Forms.Button btnRunCoinSnapshot;
    }
}