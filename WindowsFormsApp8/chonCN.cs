﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class chonCN : Form
    {
        public chonCN()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LichChieu form1 = new LichChieu();
            form1.ShowDialog();
        }
    }
}
