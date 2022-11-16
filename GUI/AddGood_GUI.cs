using BLL;
using DTO;
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
    public partial class AddGood_GUI : Form
    {
        private Good_BLL good_BLL = new Good_BLL();
        public AddGood_GUI()
        {
            InitializeComponent();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            string name = tbName.Text;
            int amount = Int16.Parse(tbAmount.Text);
            string type = tbType.Text;
            DateTime expiredDate = dtpExpiredDate.Value;
            double price = Double.Parse(tbPrice.Text);

            good_BLL.addGood(new Good_DTO(name, new GoodType_DTO(1, type), amount, price, expiredDate));
        }

        private void tbPrice_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
