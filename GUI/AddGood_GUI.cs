﻿using System;
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
    public partial class AddGood_GUI : Form
    {
        public AddGood_GUI()
        {
            InitializeComponent();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
