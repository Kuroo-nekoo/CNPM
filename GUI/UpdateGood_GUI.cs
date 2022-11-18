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
    public partial class UpdateGood_GUI : Form
    {
        private Good_DTO good;
        private Good_BLL good_BLL;
        private GoodType_BLL goodType_BLL;
        private List<GoodType_DTO> goodTypes;
        private int selectedGoodTypeId;
        public UpdateGood_GUI(Good_DTO good)
        {
            InitializeComponent();
            this.good_BLL = new Good_BLL();
            this.goodType_BLL = new GoodType_BLL();
            this.good = good;
            this.goodTypes = goodType_BLL.getGoodTypes();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            foreach (GoodType_DTO goodType in goodTypes)
            {
                if (goodType.value.Equals(cbType.Text))
                {
                    selectedGoodTypeId = goodType.id;
                }
            }

            good.name = tbName.Text;
            good.amount = Int32.Parse(tbAmount.Text);
            good.price = Double.Parse(tbPrice.Text);
            good.type.id = selectedGoodTypeId;
            good.expiredDate = dtpExpiredDate.Value;

            
            good_BLL.updateGood(good);
            this.Close();
        }

        private void UpdateGood_GUI_Load(object sender, EventArgs e)
        {
            tbName.Text = good.name;
            tbAmount.Text = good.amount.ToString();
            tbPrice.Text = good.price.ToString();
            foreach(GoodType_DTO goodType in goodTypes)
            { 
                cbType.Items.Add(goodType.value);
            }
            cbType.Text = good.type.value;
            dtpExpiredDate.Text = good.expiredDate.ToString();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
