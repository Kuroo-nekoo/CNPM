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

namespace GUI
{
    public partial class Cashier_GUI : Form
    {
        ArrayList categoryList = new ArrayList() { new Category("0", "món ăn", new List<FoodAndBeverage>() { new FoodAndBeverage("1", "mon 1", 10) }), new Category("1", "nước uống", new List<FoodAndBeverage>{ new FoodAndBeverage("2", "mon 2", 20) }) };
        ArrayList selectedItemList = new ArrayList();
        int total = 100000;
        public Cashier_GUI()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Category category in categoryList)
            {
                Button categoryButton = new Button();
                categoryButton.Name = category.id;
                categoryButton.Text = category.name;
                categoryButton.Width = 200 - 5;
                categoryButton.Height = 100;
                categoryButton.Click += CategoryButtonClick;
                flpCategory.Controls.Add(categoryButton);
            }
        }

        private void CategoryButtonClick(object sender, EventArgs e)
        {
            string id = (sender as Button).Name;

            foreach (Category category in categoryList)
            {
                if (id == category.id)
                {
                    flpMain.Controls.Clear();
                    foreach (FoodAndBeverage item in category.items)
                    {
                        Button itemButton = new Button() { Text = item.name, Width = 395, Height = 150 };
                        itemButton.Click += ItemButtonClick;
                        flpMain.Controls.Add(itemButton);
                    }
                }
            }
        }

        public void ItemButtonClick(object sender, EventArgs e)
        {
            string itemName = (sender as Button).Text;

            if (!selectedItemList.Contains(itemName))
            {
                selectedItemList.Add(itemName);
            }

            flpSelectedItem.Controls.Clear();
            foreach (string item in selectedItemList)
            {
                FlowLayoutPanel group = new FlowLayoutPanel() { Height = 30 };
                Label lbItemName = new Label() { Text = item, Anchor = AnchorStyles.Left };
                Button btIncrease = new Button() { Text = "+", Width = 20, Anchor = AnchorStyles.Left };
                TextBox tbQuantity = new TextBox() { Text = "1", Width = 20, Anchor = AnchorStyles.Left };
                Button btnDecrease = new Button() { Text = "-", Width = 20, Anchor = AnchorStyles.Left };
                group.Controls.AddRange(new Control[] { lbItemName, btIncrease, tbQuantity, btnDecrease });
                flpSelectedItem.Controls.Add(group);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PaymentMethodSelection_GUI form2 = new PaymentMethodSelection_GUI(total);
            form2.Show();
        }
    }
}
