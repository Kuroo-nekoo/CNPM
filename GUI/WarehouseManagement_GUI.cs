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
using BLL;

namespace GUI
{
    public partial class WarehouseManagement_GUI : Form
    {
        private List<Good> goods = new List<Good>();
        private BindingSource bs = new BindingSource();
        private Good_BLL good_BLL = new Good_BLL();

        public WarehouseManagement_GUI()
        {
            InitializeComponent();
        }

        private void WarehouseManagement_Load(object sender, EventArgs e)
        {
            good_BLL.getGoods();
            goods.Add(new Good("1", "good1", "type 1", 10, new DateTime(), 20000));
            goods.Add(new Good("2", "good2", "type 1", 10, new DateTime(), 20000));
            goods.Add(new Good("3", "good3", "type 2", 10, new DateTime(), 20000));
            goods.Add(new Good("4", "good4", "type 2", 10, new DateTime(), 20000));
            goods.Add(new Good("5", "good5", "type 1", 10, new DateTime(), 20000));
            goods.Add(new Good("6", "good6", "type 2", 10, new DateTime(), 20000));
            goods.Add(new Good("7", "good7", "type 1", 10, new DateTime(), 20000));
            goods.Add(new Good("8", "good8", "type 1", 10, new DateTime(), 20000));
            goods.Add(new Good("9", "good9", "type 3", 10, new DateTime(), 20000));
            goods.Add(new Good("10", "good10", "type 3", 10, new DateTime(), 20000));
            bs.DataSource = goods;

            foreach (Good good in goods)
            {
                if (!cbType.Items.Contains(good.type))
                {
                    cbType.Items.Add(good.type);
                }
            }

            dgvGood.DataSource = bs;
        }

        private void cbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            DataView dv = dt.DefaultView;
            dv.RowFilter = string.Format("Series LIKE '%{0}%'", cbType.SelectedItem.ToString());
            dgvGood.DataSource = dv;
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvGood.SelectedRows)
            {
                dgvGood.Rows.Remove(row);
            }
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            int index = dgvGood.CurrentCell.RowIndex;
            Good good = goods[index];
            UpdateGood_GUI updateGood = new UpdateGood_GUI(good);
            updateGood.Show();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
