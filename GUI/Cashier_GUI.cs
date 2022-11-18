using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;
using GUI.CustomControl;

namespace GUI
{
    public partial class Cashier_GUI : Form
    {
        FoodAndBeverageType_BLL foodAndBeverageType_BLL = new FoodAndBeverageType_BLL();
        FoodAndBeverage_BLL foodAndBeverage_BLL = new FoodAndBeverage_BLL();
        List<FoodAndBeverageType_DTO> foodAndBeverageTypes;
        List<FoodAndBeverage_DTO> selectedFoodAndBeverages = new List<FoodAndBeverage_DTO>();
        List<String> seletedIds = new List<String>(); 
        List<FoodAndBeverage_DTO> foodAndBeverages;
        Double total = 0;
        public Cashier_GUI()
        {
            InitializeComponent();
        }

        private void foodAndBeverageTypeButtonClick(object sender, EventArgs e)
        {
            string typeId = (sender as Button).Name;
            foodAndBeverages = foodAndBeverage_BLL.getFoodAndBeveragesByType(typeId);
            flpMain.Controls.Clear();

            foreach (FoodAndBeverage_DTO foodAndBeverage in foodAndBeverages)
            {
                Button itemButton = new Button() { Text = foodAndBeverage.name, Width = (flpMain.Width - 15) / 2, Height = 150, Name = foodAndBeverage.id.ToString() };
                itemButton.Click += ItemButtonClick;
                flpMain.Controls.Add(itemButton);
            }
        }

        public void ItemButtonClick(object sender, EventArgs e)
        {
            string id = (sender as Button).Name;

            foreach (FoodAndBeverage_DTO foodAndBeverage in foodAndBeverages)
            {
                if (foodAndBeverage.id.ToString().Equals(id) && !seletedIds.Contains(id))
                {
                    selectedFoodAndBeverages.Add(foodAndBeverage);
                    seletedIds.Add(id);
                }
            }

            flpSelectedItem.Controls.Clear();
            foreach (FoodAndBeverage_DTO item in selectedFoodAndBeverages)
            {
                SelectedItemFlowLayoutPanel seletedItemFlowLayoutPanel = new SelectedItemFlowLayoutPanel(item, selectedFoodAndBeverages, seletedIds, lbTotal, total);
                flpSelectedItem.Controls.Add(seletedItemFlowLayoutPanel);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PaymentMethodSelection_GUI form2 = new PaymentMethodSelection_GUI(total);
            form2.Show();
        }

        private void Cashier_Load(object sender, EventArgs e)
        {
            foodAndBeverageTypes = foodAndBeverageType_BLL.getFoodAndBeverageTypes();

            foreach (FoodAndBeverageType_DTO foodAndBeverageType in foodAndBeverageTypes)
            { 
                Button foodAndBeverageTypeButton = new Button();
                foodAndBeverageTypeButton.Name = foodAndBeverageType.id.ToString();
                foodAndBeverageTypeButton.Text = foodAndBeverageType.value;
                foodAndBeverageTypeButton.Width = 200 - 5;
                foodAndBeverageTypeButton.Height = 100;
                foodAndBeverageTypeButton.Click += foodAndBeverageTypeButtonClick;
                flpCategory.Controls.Add(foodAndBeverageTypeButton);
            }
        }
    }
}
