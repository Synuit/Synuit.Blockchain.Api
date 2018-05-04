namespace Synuit.Coin.Market.Stats
{
   partial class frmCryptoCompare
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CoinGrid = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.symbolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.algorithmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proofTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentBlocksDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.blockRewardDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalCoinSupplyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalCoinsMinedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.blockRewardReductionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estimatedBlockTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.networkHashRateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marketCapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coinInformationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CoinGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coinInformationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(832, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // CoinGrid
            // 
            this.CoinGrid.AutoGenerateColumns = false;
            this.CoinGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CoinGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.symbolDataGridViewTextBoxColumn,
            this.algorithmDataGridViewTextBoxColumn,
            this.proofTypeDataGridViewTextBoxColumn,
            this.currentBlocksDataGridViewTextBoxColumn,
            this.blockRewardDataGridViewTextBoxColumn,
            this.totalCoinSupplyDataGridViewTextBoxColumn,
            this.totalCoinsMinedDataGridViewTextBoxColumn,
            this.blockRewardReductionDataGridViewTextBoxColumn,
            this.estimatedBlockTimeDataGridViewTextBoxColumn,
            this.networkHashRateDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.marketCapDataGridViewTextBoxColumn});
            this.CoinGrid.DataSource = this.coinInformationBindingSource;
            this.CoinGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CoinGrid.Location = new System.Drawing.Point(0, 24);
            this.CoinGrid.Name = "CoinGrid";
            this.CoinGrid.Size = new System.Drawing.Size(832, 298);
            this.CoinGrid.TabIndex = 1;
            this.CoinGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CoinGrid_CellContentClick);
            // 
            // symbolDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "CoinID";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.symbolDataGridViewTextBoxColumn.DataPropertyName = "Symbol";
            this.symbolDataGridViewTextBoxColumn.HeaderText = "Symbol";
            this.symbolDataGridViewTextBoxColumn.Name = "symbolDataGridViewTextBoxColumn";
            // 
            // algorithmDataGridViewTextBoxColumn
            // 
            this.algorithmDataGridViewTextBoxColumn.DataPropertyName = "Algorithm";
            this.algorithmDataGridViewTextBoxColumn.HeaderText = "Algorithm";
            this.algorithmDataGridViewTextBoxColumn.Name = "algorithmDataGridViewTextBoxColumn";
            // 
            // currentBlocksDataGridViewTextBoxColumn
            // 
            this.proofTypeDataGridViewTextBoxColumn.DataPropertyName = "ProofType";
            this.proofTypeDataGridViewTextBoxColumn.HeaderText = "ProofType";
            this.proofTypeDataGridViewTextBoxColumn.Name = "proofTypeDataGridViewTextBoxColumn";
            //
            //  proofTypeDataGridViewTextBoxColumn
            //
            this.currentBlocksDataGridViewTextBoxColumn.DataPropertyName = "CurrentBlocks";
            this.currentBlocksDataGridViewTextBoxColumn.HeaderText = "CurrentBlocks";
            this.currentBlocksDataGridViewTextBoxColumn.Name = "currentBlocksDataGridViewTextBoxColumn";
            // 
            // blockRewardDataGridViewTextBoxColumn
            // 
            this.blockRewardDataGridViewTextBoxColumn.DataPropertyName = "Reward";
            this.blockRewardDataGridViewTextBoxColumn.HeaderText = "BlockReward";
            this.blockRewardDataGridViewTextBoxColumn.Name = "blockRewardDataGridViewTextBoxColumn";
            // 
            // totalCoinSupplyDataGridViewTextBoxColumn
            // 
            this.totalCoinSupplyDataGridViewTextBoxColumn.DataPropertyName = "TotalCoinSupply";
            this.totalCoinSupplyDataGridViewTextBoxColumn.HeaderText = "TotalCoinSupply";
            this.totalCoinSupplyDataGridViewTextBoxColumn.Name = "totalCoinSupplyDataGridViewTextBoxColumn";
            // 
            // totalCoinsMinedDataGridViewTextBoxColumn
            // 
            this.totalCoinsMinedDataGridViewTextBoxColumn.DataPropertyName = "TotalCoinsMined";
            this.totalCoinsMinedDataGridViewTextBoxColumn.HeaderText = "TotalCoinsMined";
            this.totalCoinsMinedDataGridViewTextBoxColumn.Name = "totalCoinsMinedDataGridViewTextBoxColumn";
            // 
            // blockRewardReductionDataGridViewTextBoxColumn
            // 
            this.blockRewardReductionDataGridViewTextBoxColumn.DataPropertyName = "RewardReduction";
            this.blockRewardReductionDataGridViewTextBoxColumn.HeaderText = "RewardReduction";
            this.blockRewardReductionDataGridViewTextBoxColumn.Name = "blockRewardReductionDataGridViewTextBoxColumn";
            // 
            // estimatedBlockTimeDataGridViewTextBoxColumn
            // 
            this.estimatedBlockTimeDataGridViewTextBoxColumn.DataPropertyName = "EstimatedBlockTime";
            this.estimatedBlockTimeDataGridViewTextBoxColumn.HeaderText = "EstBlockTime";
            this.estimatedBlockTimeDataGridViewTextBoxColumn.Name = "estimatedBlockTimeDataGridViewTextBoxColumn";
            // 
            // networkHashRateDataGridViewTextBoxColumn
            // 
            this.networkHashRateDataGridViewTextBoxColumn.DataPropertyName = "NetworkHashRate";
            this.networkHashRateDataGridViewTextBoxColumn.HeaderText = "HashRatePerSec";
            this.networkHashRateDataGridViewTextBoxColumn.Name = "networkHashRateDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // marketCapDataGridViewTextBoxColumn
            // 
            this.marketCapDataGridViewTextBoxColumn.DataPropertyName = "MarketCap";
            this.marketCapDataGridViewTextBoxColumn.HeaderText = "MarketCap";
            this.marketCapDataGridViewTextBoxColumn.Name = "marketCapDataGridViewTextBoxColumn";
            // 
            // coinInformationBindingSource
            // 
            this.coinInformationBindingSource.DataSource = typeof(Synuit.Blockchain.Api.Coin.Models.CoinInformation);
            // 
            // frmCryptoCompare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 322);
            this.Controls.Add(this.CoinGrid);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmCryptoCompare";
            this.Text = "CryptoCompare.com";
            this.Load += new System.EventHandler(this.frmCryptoCompare_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CoinGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coinInformationBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.MenuStrip menuStrip1;
      private System.Windows.Forms.DataGridView CoinGrid;
      private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
      private System.Windows.Forms.BindingSource coinInformationBindingSource;
      private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
      private System.Windows.Forms.DataGridViewTextBoxColumn symbolDataGridViewTextBoxColumn;
      private System.Windows.Forms.DataGridViewTextBoxColumn algorithmDataGridViewTextBoxColumn;
      private System.Windows.Forms.DataGridViewTextBoxColumn proofTypeDataGridViewTextBoxColumn;
      private System.Windows.Forms.DataGridViewTextBoxColumn currentBlocksDataGridViewTextBoxColumn;
      private System.Windows.Forms.DataGridViewTextBoxColumn blockRewardDataGridViewTextBoxColumn;
      private System.Windows.Forms.DataGridViewTextBoxColumn totalCoinSupplyDataGridViewTextBoxColumn;
      private System.Windows.Forms.DataGridViewTextBoxColumn totalCoinsMinedDataGridViewTextBoxColumn;
      private System.Windows.Forms.DataGridViewTextBoxColumn blockRewardReductionDataGridViewTextBoxColumn;
      private System.Windows.Forms.DataGridViewTextBoxColumn estimatedBlockTimeDataGridViewTextBoxColumn;
      private System.Windows.Forms.DataGridViewTextBoxColumn networkHashRateDataGridViewTextBoxColumn;
      private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
      private System.Windows.Forms.DataGridViewTextBoxColumn marketCapDataGridViewTextBoxColumn;
    }
}