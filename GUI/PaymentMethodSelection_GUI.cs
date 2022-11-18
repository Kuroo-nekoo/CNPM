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
    public partial class PaymentMethodSelection_GUI : Form
    {
        Double total = 0;
        public PaymentMethodSelection_GUI(Double total)
        {
            InitializeComponent();
            this.total = total;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Payment_GUI payment = new Payment_GUI(total);
            payment.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WarehouseManagement_GUI warehouseManagement = new WarehouseManagement_GUI();
            warehouseManagement.Show();
        }
    }
}
