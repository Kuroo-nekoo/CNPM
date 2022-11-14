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
        public Good good;
        public UpdateGood_GUI(Good good)
        {
            InitializeComponent();
            this.good = good;
        }
    }
}
