﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market
{
    public partial class NakitSatis : Form
    {
        public NakitSatis()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double y1, y2, y3;
            y1 = Convert.ToDouble(textBox1.Text);
            y2 = Convert.ToDouble(textBox2.Text);
            y3 = (y2 - y1);
            textBox3.Text = y3.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var m = new SatisEkrani();
            m.Show();
            this.Hide();
        }
    }
}
