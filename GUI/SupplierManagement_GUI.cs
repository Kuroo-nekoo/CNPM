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
    public partial class SupplierManagement_GUI : Form
    {
        private Supplier_BLL supplier_BLL;
        private List<Supplier_DTO> suppliers;

        public SupplierManagement_GUI()
        {
            InitializeComponent();
            supplier_BLL = new Supplier_BLL();
            suppliers = supplier_BLL.getSuppliers();
        }

        private void SupplierManagement_GUI_Load(object sender, EventArgs e)
        {
            dgvSupplier.DataSource = suppliers;
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            string searchValue = tbSearch.Text;
            dgvSupplier.DataSource = supplier_BLL.searchSupplier(searchValue);
        }

        private void tbSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btSearch_Click(sender, e);
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (dgvSupplier.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dgvSupplier.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvSupplier.Rows[selectedRowIndex];
                
                string idToDelete = selectedRow.Cells[0].Value.ToString();
                DialogResult confirmResult = MessageBox.Show("Xoá " + selectedRow.Cells[1].Value + " khỏi danh sách ?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    supplier_BLL.deleteSupplier(idToDelete);
                }
                dgvSupplier.DataSource = supplier_BLL.getSuppliers();
            }
        }

        private void dgvSupplier_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                btDelete_Click(sender, e);
            }
        }
    }
}
