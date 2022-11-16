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
using System.Runtime.InteropServices;

namespace GUI
{
    public partial class WarehouseManagement_GUI : Form
    {
        private Good_BLL good_BLL = new Good_BLL();
        private List<String> types = new List<String>();
        private DataGridViewColumn typeColumn = new DataGridViewTextBoxColumn() { Name = "test", HeaderText="Đơn vị tính"};
        private List<Good_DTO> goods = new List<Good_DTO>();

        public WarehouseManagement_GUI()
        {
            InitializeComponent();
        }

        private void WarehouseManagement_Load(object sender, EventArgs e)
        {
            goods = good_BLL.getGoods();
            loadDataToDataGridView();
        }

        private void cbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            goods = good_BLL.filterGood(cbType.SelectedItem.ToString());
            loadDataToDataGridView();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (dgvGood.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dgvGood.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvGood.Rows[selectedRowIndex];
                Console.WriteLine(selectedRow.Cells[0].Value);
                string deleteGoodId = selectedRow.Cells[0].Value.ToString();
                DialogResult confirmResult = MessageBox.Show("Xoá " + selectedRow.Cells[1].Value + " khỏi danh sách ?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    good_BLL.deleteGood(deleteGoodId);
                }
                goods = good_BLL.getGoods();
                loadDataToDataGridView();
            }
        }
        
        private void btUpdate_Click(object sender, EventArgs e)
        {
            int index = dgvGood.CurrentCell.RowIndex;
            Good_DTO good = goods[index];
            UpdateGood_GUI updateGood = new UpdateGood_GUI(good);
            updateGood.Show();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            AddGood_GUI addGood_GUI = new AddGood_GUI();
            addGood_GUI.Show();
        }

        private void loadDataToDataGridView()
        {
            dgvGood.Columns.Clear();
            dgvGood.DataSource = goods;
            dgvGood.Columns.RemoveAt(2);
            dgvGood.Columns.Insert(2, typeColumn);
            dgvGood.Columns[0].HeaderText = "Mã hàng";
            dgvGood.Columns[1].HeaderText = "Tên hàng";
            dgvGood.Columns[3].HeaderText = "Số lượng";
            dgvGood.Columns[4].HeaderText = "Đơn giá";
            dgvGood.Columns[5].HeaderText = "Hạn sử dụng";

            foreach (Good_DTO good in goods)
            {
                if (!cbType.Items.Contains(good.type.value))
                {
                    cbType.Items.Add(good.type.value);
                }
                dgvGood[2, goods.IndexOf(good)].Value = good.type.value;
            }
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            string searchValue = tbSearch.Text;
            goods = good_BLL.searchGood(searchValue);
            loadDataToDataGridView();
            tbSearch.Text = "";
        }

        private void tbSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btSearch_Click(sender, e);
            }
        }
    }
}
