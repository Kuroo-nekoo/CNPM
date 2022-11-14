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
    public partial class Payment_GUI : Form
    {
        private int total = 0;
        private int receive = 0;
        private int excess = 0;
        public Payment_GUI(int total)
        {
            InitializeComponent();
            this.total = total;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                receive = Int32.Parse(tbReceive.Text);
                lbExcess.Text = (receive - total).ToString();
            }
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            lbTotal.Text = total.ToString();
            lbExcess.Text = excess.ToString();
        }
    }
}
