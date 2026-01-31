using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using POS.MasterData;
using POS.Sale;
using POS.Purchase;

namespace POS
{
    static class Program
    {
        static public int UserID;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frm_UserSettingList());
        }
    }
}
