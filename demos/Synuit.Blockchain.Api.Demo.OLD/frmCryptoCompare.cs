using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Synuit.Coin.Market.Stats
{
   public partial class frmCryptoCompare : Form
   {
      IEnumerable<Synuit.Blockchain.Api.Coin.Models.CoinInformation> _coins;

      public frmCryptoCompare()
      {
         InitializeComponent();
      }

      private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
      {

      }

      private void RefreshListing(string typeParam = "", string inputParam = "")
      {
         if (typeParam == "snapshot")
             _coins = new Synuit.Blockchain.Api.CryptoCompare.ApiContext().GetCoinInformationWithSnapshot(inputParam);
         else
             _coins = new Synuit.Blockchain.Api.CryptoCompare.ApiContext().GetCoinInformation();
         CoinGrid.DataSource = _coins;
      }

      private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
      {
         RefreshListing();
      }

      private void frmCryptoCompare_Load(object sender, EventArgs e)
        {
            string inputParams = Program.Context.MainForm.ActiveControl.Text;
            string callingButtonName = Program.Context.MainForm.ActiveControl.Name;
            if (callingButtonName.Equals("btnRunCoinSnapshot"))
                RefreshListing("snapshot", inputParams);
            else
                RefreshListing();
                
      }

        private void CoinGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
