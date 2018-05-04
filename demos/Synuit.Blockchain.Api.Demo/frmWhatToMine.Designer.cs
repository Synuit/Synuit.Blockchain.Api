namespace Synuit.Coin.Market.Stats
{
   partial class frmWhatToMine
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
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CoinGrid = new System.Windows.Forms.DataGridView();
            this.symbolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.algorithmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentBlocksDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.difficultyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rewardDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minimumBlockTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.networkHashRateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.incomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exchangeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profitabilityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adjustedProfitabilityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.averageProfitabilityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.averageHashRateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isMultiCoinDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.coinInformationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CoinGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coinInformationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem,
            this.testToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(673, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.testToolStripMenuItem.Text = "Test";
            this.testToolStripMenuItem.Click += new System.EventHandler(this.testToolStripMenuItem_Click);
            // 
            // CoinGrid
            // 
            this.CoinGrid.AutoGenerateColumns = false;
            this.CoinGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CoinGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.symbolDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.algorithmDataGridViewTextBoxColumn,
            this.currentBlocksDataGridViewTextBoxColumn,
            this.difficultyDataGridViewTextBoxColumn,
            this.rewardDataGridViewTextBoxColumn,
            this.minimumBlockTimeDataGridViewTextBoxColumn,
            this.networkHashRateDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.incomeDataGridViewTextBoxColumn,
            this.exchangeDataGridViewTextBoxColumn,
            this.profitabilityDataGridViewTextBoxColumn,
            this.adjustedProfitabilityDataGridViewTextBoxColumn,
            this.averageProfitabilityDataGridViewTextBoxColumn,
            this.averageHashRateDataGridViewTextBoxColumn,
            this.isMultiCoinDataGridViewCheckBoxColumn});
            this.CoinGrid.DataSource = this.coinInformationBindingSource;
            this.CoinGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CoinGrid.Location = new System.Drawing.Point(0, 24);
            this.CoinGrid.Name = "CoinGrid";
            this.CoinGrid.Size = new System.Drawing.Size(673, 238);
            this.CoinGrid.TabIndex = 1;
            this.CoinGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CoinGrid_CellContentClick);
            // 
            // symbolDataGridViewTextBoxColumn
            // 
            this.symbolDataGridViewTextBoxColumn.DataPropertyName = "Symbol";
            this.symbolDataGridViewTextBoxColumn.HeaderText = "Symbol";
            this.symbolDataGridViewTextBoxColumn.Name = "symbolDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // algorithmDataGridViewTextBoxColumn
            // 
            this.algorithmDataGridViewTextBoxColumn.DataPropertyName = "Algorithm";
            this.algorithmDataGridViewTextBoxColumn.HeaderText = "Algorithm";
            this.algorithmDataGridViewTextBoxColumn.Name = "algorithmDataGridViewTextBoxColumn";
            // 
            // currentBlocksDataGridViewTextBoxColumn
            // 
            this.currentBlocksDataGridViewTextBoxColumn.DataPropertyName = "CurrentBlocks";
            this.currentBlocksDataGridViewTextBoxColumn.HeaderText = "CurrentBlocks";
            this.currentBlocksDataGridViewTextBoxColumn.Name = "currentBlocksDataGridViewTextBoxColumn";
            // 
            // difficultyDataGridViewTextBoxColumn
            // 
            this.difficultyDataGridViewTextBoxColumn.DataPropertyName = "Difficulty";
            this.difficultyDataGridViewTextBoxColumn.HeaderText = "Difficulty";
            this.difficultyDataGridViewTextBoxColumn.Name = "difficultyDataGridViewTextBoxColumn";
            // 
            // rewardDataGridViewTextBoxColumn
            // 
            this.rewardDataGridViewTextBoxColumn.DataPropertyName = "Reward";
            this.rewardDataGridViewTextBoxColumn.HeaderText = "Reward";
            this.rewardDataGridViewTextBoxColumn.Name = "rewardDataGridViewTextBoxColumn";
            // 
            // minimumBlockTimeDataGridViewTextBoxColumn
            // 
            this.minimumBlockTimeDataGridViewTextBoxColumn.DataPropertyName = "MinimumBlockTime";
            this.minimumBlockTimeDataGridViewTextBoxColumn.HeaderText = "MinimumBlockTime";
            this.minimumBlockTimeDataGridViewTextBoxColumn.Name = "minimumBlockTimeDataGridViewTextBoxColumn";
            // 
            // networkHashRateDataGridViewTextBoxColumn
            // 
            this.networkHashRateDataGridViewTextBoxColumn.DataPropertyName = "NetworkHashRate";
            this.networkHashRateDataGridViewTextBoxColumn.HeaderText = "NetworkHashRate";
            this.networkHashRateDataGridViewTextBoxColumn.Name = "networkHashRateDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // incomeDataGridViewTextBoxColumn
            // 
            this.incomeDataGridViewTextBoxColumn.DataPropertyName = "Income";
            this.incomeDataGridViewTextBoxColumn.HeaderText = "Income";
            this.incomeDataGridViewTextBoxColumn.Name = "incomeDataGridViewTextBoxColumn";
            // 
            // exchangeDataGridViewTextBoxColumn
            // 
            this.exchangeDataGridViewTextBoxColumn.DataPropertyName = "Exchange";
            this.exchangeDataGridViewTextBoxColumn.HeaderText = "Exchange";
            this.exchangeDataGridViewTextBoxColumn.Name = "exchangeDataGridViewTextBoxColumn";
            // 
            // profitabilityDataGridViewTextBoxColumn
            // 
            this.profitabilityDataGridViewTextBoxColumn.DataPropertyName = "Profitability";
            this.profitabilityDataGridViewTextBoxColumn.HeaderText = "Profitability";
            this.profitabilityDataGridViewTextBoxColumn.Name = "profitabilityDataGridViewTextBoxColumn";
            // 
            // adjustedProfitabilityDataGridViewTextBoxColumn
            // 
            this.adjustedProfitabilityDataGridViewTextBoxColumn.DataPropertyName = "AdjustedProfitability";
            this.adjustedProfitabilityDataGridViewTextBoxColumn.HeaderText = "AdjustedProfitability";
            this.adjustedProfitabilityDataGridViewTextBoxColumn.Name = "adjustedProfitabilityDataGridViewTextBoxColumn";
            // 
            // averageProfitabilityDataGridViewTextBoxColumn
            // 
            this.averageProfitabilityDataGridViewTextBoxColumn.DataPropertyName = "AverageProfitability";
            this.averageProfitabilityDataGridViewTextBoxColumn.HeaderText = "AverageProfitability";
            this.averageProfitabilityDataGridViewTextBoxColumn.Name = "averageProfitabilityDataGridViewTextBoxColumn";
            // 
            // averageHashRateDataGridViewTextBoxColumn
            // 
            this.averageHashRateDataGridViewTextBoxColumn.DataPropertyName = "AverageHashRate";
            this.averageHashRateDataGridViewTextBoxColumn.HeaderText = "AverageHashRate";
            this.averageHashRateDataGridViewTextBoxColumn.Name = "averageHashRateDataGridViewTextBoxColumn";
            // 
            // isMultiCoinDataGridViewCheckBoxColumn
            // 
            this.isMultiCoinDataGridViewCheckBoxColumn.DataPropertyName = "IsMultiCoin";
            this.isMultiCoinDataGridViewCheckBoxColumn.HeaderText = "IsMultiCoin";
            this.isMultiCoinDataGridViewCheckBoxColumn.Name = "isMultiCoinDataGridViewCheckBoxColumn";
            // 
            // coinInformationBindingSource
            // 
            this.coinInformationBindingSource.DataSource = typeof(Synuit.Blockchain.Api.Coin.Models.CoinInformation);
            // 
            // frmWhatToMine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 262);
            this.Controls.Add(this.CoinGrid);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmWhatToMine";
            this.Text = "Synuit.Coin - Markets and Network Data";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CoinGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coinInformationBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.MenuStrip menuStrip1;
      private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
      private System.Windows.Forms.DataGridView CoinGrid;
      private System.Windows.Forms.DataGridViewTextBoxColumn symbolDataGridViewTextBoxColumn;
      private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
      private System.Windows.Forms.DataGridViewTextBoxColumn algorithmDataGridViewTextBoxColumn;
      private System.Windows.Forms.DataGridViewTextBoxColumn currentBlocksDataGridViewTextBoxColumn;
      private System.Windows.Forms.DataGridViewTextBoxColumn difficultyDataGridViewTextBoxColumn;
      private System.Windows.Forms.DataGridViewTextBoxColumn rewardDataGridViewTextBoxColumn;
      private System.Windows.Forms.DataGridViewTextBoxColumn minimumBlockTimeDataGridViewTextBoxColumn;
      private System.Windows.Forms.DataGridViewTextBoxColumn networkHashRateDataGridViewTextBoxColumn;
      private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
      private System.Windows.Forms.DataGridViewTextBoxColumn incomeDataGridViewTextBoxColumn;
      private System.Windows.Forms.DataGridViewTextBoxColumn exchangeDataGridViewTextBoxColumn;
      private System.Windows.Forms.DataGridViewTextBoxColumn profitabilityDataGridViewTextBoxColumn;
      private System.Windows.Forms.DataGridViewTextBoxColumn adjustedProfitabilityDataGridViewTextBoxColumn;
      private System.Windows.Forms.DataGridViewTextBoxColumn averageProfitabilityDataGridViewTextBoxColumn;
      private System.Windows.Forms.DataGridViewTextBoxColumn averageHashRateDataGridViewTextBoxColumn;
      private System.Windows.Forms.DataGridViewCheckBoxColumn isMultiCoinDataGridViewCheckBoxColumn;
      private System.Windows.Forms.BindingSource coinInformationBindingSource;
      private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
   }
}

