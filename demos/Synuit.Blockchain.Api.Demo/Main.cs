using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Synuit.Coin.Market.Stats
{

    public partial class frmMain : Form
   {

        public frmMain()
        {
           InitializeComponent();
        }
    
        private void btnWhatToMine_Click(object sender, EventArgs e)
        {
            frmWhatToMine frm = new frmWhatToMine();
            frm.Show(this);
        }

        private void btnCryptoCompare_Click(object sender, EventArgs e)
        {
            frmCryptoCompare frm = new frmCryptoCompare();
            frm.Show(this);
        }

        private void txtTargetCoin_TextChanged(object sender, EventArgs e)
        {
            string targetCoin = Text;
        }

        private void dtpTargetDate_ValueChanged(object sender, EventArgs e)
        {
            DateTime targetDate = dtpTargetDate.Value.Date;
        }

        private void btnRunHistoDayClose_Click(object sender, EventArgs e)
        {
            double histPrice = new Synuit.Blockchain.Api.CryptoCompare.ApiContext().GetClosingPriceForDate(txtTargetCoin.Text, dtpTargetDate.Value.Date);
            txtHistPriceClose.Text = histPrice.ToString();
        }

        private void btnRunHistoDayOpen_Click(object sender, EventArgs e)
        {
            double histPrice = new Synuit.Blockchain.Api.CryptoCompare.ApiContext().GetOpeningPriceForDate(txtTargetCoin.Text, dtpTargetDate.Value.Date);
            txtHistPriceOpen.Text = histPrice.ToString();
        }

        private void btnRunHistoDayHigh_Click(object sender, EventArgs e)
        {
            double histPrice = new Synuit.Blockchain.Api.CryptoCompare.ApiContext().GetHighPriceForDate(txtTargetCoin.Text, dtpTargetDate.Value.Date);
            txtHistPriceHigh.Text = histPrice.ToString();
        }

        private void btnRunHistoDayLow_Click(object sender, EventArgs e)
        {
            double histPrice = new Synuit.Blockchain.Api.CryptoCompare.ApiContext().GetLowPriceForDate(txtTargetCoin.Text, dtpTargetDate.Value.Date);
            txtHistPriceLow.Text = histPrice.ToString();
        }

        private void btnRunCoinSnapshot_Click(object sender, EventArgs e)
        {
            btnRunCoinSnapshot.Text = txtTargetCoinList.Text;
            Program.Context.MainForm = this;
            frmCryptoCompare frm = new frmCryptoCompare();
            frm.Show(this);
            btnRunCoinSnapshot.Text = "Get Coin Snapshot Info";
        }
    }
}
