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
        private Good_BLL good_BLL = new Good_BLL();

        public WarehouseManagement_GUI()
        {
            InitializeComponent();
        }

        private void WarehouseManagement_Load(object sender, EventArgs e)
        {
            goods = good_BLL.getGoods();

            foreach (Good good in goods)
            {
                if (!cbType.Items.Contains(good.type))
                {
                    cbType.Items.Add(good.type);
                }
            }

            dgvGood.DataSource = goods;
        }

        private void cbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (dgvGood.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dgvGood.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvGood.Rows[selectedRowIndex];
                Console.WriteLine(selectedRow.Cells[0].Value);
                string deleteGoodId = selectedRow.Cells[0].Value.ToString();
                DialogResult confirmResult = MessageBox.Show("Bạn có muốn xoá món hàng có mã " + selectedRow.Cells[0].Value + "?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    good_BLL.deleteGood(deleteGoodId);
                }
                goods = good_BLL.getGoods();
                dgvGood.DataSource = goods;
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
