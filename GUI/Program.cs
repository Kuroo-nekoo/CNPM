using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Selection_GUI selection = new Selection_GUI();
            Application.Run(selection);

            if (selection.isCashierSelected)
            {
                Application.Run(new Cashier_GUI());
            }
            else if (selection.isWarehouseManagementSelected)
            {
                Application.Run(new WarehouseManagement_GUI());
            }
            else if (selection.isManagerSelected)
            {
                Application.Run(new ManagerSelection_GUI());
            }
        }
    }
}
