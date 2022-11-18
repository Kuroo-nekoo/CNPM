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

namespace GUI.CustomControl
{
    public partial class SelectedItemFlowLayoutPanel : UserControl
    {
        FoodAndBeverage_DTO foodAndBeverage_DTO;
        List<FoodAndBeverage_DTO> foodAndBeverages;
        Label lbTotal;
        Double total;
        List<String> selectedIds;
        public SelectedItemFlowLayoutPanel(FoodAndBeverage_DTO foodAndBeverage, List<FoodAndBeverage_DTO> foodAndBeverages, List<String> selectedIds, Label lbTotal, Double total)
        {
            InitializeComponent();
            this.foodAndBeverage_DTO = foodAndBeverage;
            this.foodAndBeverages = foodAndBeverages;
            this.lbTotal = lbTotal;
            this.total = total;
            this.foodAndBeverage_DTO.amount = 1;
            this.selectedIds = selectedIds;
        }

        private void SelectedItemFlowLayoutPanel_Load(object sender, EventArgs e)
        {
            tbAmount.Text = foodAndBeverage_DTO.amount.ToString();
            lbName.Text = foodAndBeverage_DTO.name;
            lbPrice.Text = (foodAndBeverage_DTO.price * foodAndBeverage_DTO.amount).ToString();
            calTotal();
        }

        private void btDecrease_Click(object sender, EventArgs e)
        {
            foodAndBeverage_DTO.amount--;
            tbAmount.Text = foodAndBeverage_DTO.amount.ToString();
            this.calTotal();
        }

        private void btIncrese_Click(object sender, EventArgs e)
        {
            foodAndBeverage_DTO.amount++;
            tbAmount.Text = foodAndBeverage_DTO.amount.ToString();
            this.calTotal();
        }

        private void btRemove_Click(object sender, EventArgs e)
        {
            float total = 0;
            foodAndBeverages.Remove(foodAndBeverage_DTO);
            selectedIds.Remove(foodAndBeverage_DTO.id.ToString());
            lbTotal.Text = total.ToString();
            Dispose();
            calTotal();
        }

        private void btSizeS_Click(object sender, EventArgs e)
        {
            foodAndBeverage_DTO.size = "S";
            calTotal();
        }

        private void btSizeM_Click(object sender, EventArgs e)
        {
            foodAndBeverage_DTO.size = "M";
            calTotal();
        }

        private void btSizeL_Click(object sender, EventArgs e)
        {
            foodAndBeverage_DTO.size = "L";
            calTotal();
        }

        private void calTotal()
        {
            lbPrice.Text = calPrice(foodAndBeverage_DTO).ToString();
            Double total = 0;

            foreach (FoodAndBeverage_DTO foodAndBeverage in foodAndBeverages)
            {
                total += calPrice(foodAndBeverage);
            }
            lbTotal.Text = total.ToString();
        }

        private Double calPrice(FoodAndBeverage_DTO foodAndBeverage)
        {
            if (foodAndBeverage.size == "S")
            {
                return Math.Ceiling(((Double)foodAndBeverage.price * foodAndBeverage.amount * 0.8) / 1000) * 1000;
            }
            else if (foodAndBeverage.size == "M")
            {
                return (Double)foodAndBeverage.price * foodAndBeverage.amount;
            }
            else
            {
                return Math.Ceiling(((Double)foodAndBeverage.price * foodAndBeverage.amount * 1.2) / 1000) * 1000;
            }
        }
    }
}
