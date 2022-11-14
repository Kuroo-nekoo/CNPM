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
    public partial class Selection_GUI : Form
    {
        public bool isCashierSelected { get; private set; } = false;
        public bool isWarehouseManagementSelected { get; private set; } = false;
        public bool isManagerSelected { get; private set; } = false;
        public Selection_GUI()
        {
            InitializeComponent();
        }

        private void btCashier_Click(object sender, EventArgs e)
        {
            isCashierSelected = true;
            Close();
        }

        private void btWarehouseManagement_Click(object sender, EventArgs e)
        {
            isWarehouseManagementSelected = true;
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            isManagerSelected = true;
            Close();
        }
    }
}
