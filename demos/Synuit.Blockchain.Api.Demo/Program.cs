using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Synuit.Coin.Market.Stats
{
   static class Program
   {
        public static ApplicationContext Context { get; set; }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
      static void Main()
      {
         Application.EnableVisualStyles();
         Application.SetCompatibleTextRenderingDefault(false);
         Context = new ApplicationContext(new frmMain());
         Application.Run(Context);
      }
   }
}
