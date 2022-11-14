using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class ManagerSelection_GUI : Form
    {
        public ManagerSelection_GUI()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SupplierManagement_GUI supplierManagement = new SupplierManagement_GUI();
            supplierManagement.Show();
        }
    }
}
