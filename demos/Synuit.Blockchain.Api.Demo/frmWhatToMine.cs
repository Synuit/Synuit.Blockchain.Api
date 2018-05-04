//using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Synuit.Coin.Market.Stats
{
   public partial class frmWhatToMine : Form
   {
      // IEnumerable<Synuit.Blockchain.Api.Coin.Data.CoinInformation> _coins;
      public frmWhatToMine()
      {
         InitializeComponent();
      }

      private void Form1_Load(object sender, EventArgs e)
      {
         RefreshListing();
      }

      private void RefreshListing()
      {
         //_coins = new Synuit.Blockchain.WhatToMine.ApiContext().GetCoinInformation();
         //CoinGrid.DataSource = _coins;
      }

      private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
      {
         RefreshListing();
      }

      private void testToolStripMenuItem_Click(object sender, EventArgs e)
      {
         //var json = File.ReadAllText("coinlist.json");
         //var coinlist = JsonConvert.DeserializeObject<RootObject>(json);
      }

        private void CoinGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
