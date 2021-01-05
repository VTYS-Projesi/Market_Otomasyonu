using System;
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
        private SatisEkrani frm1;
        public NakitSatis(SatisEkrani frm1)
        {
            this.frm1 = frm1;
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void NakitSatis_Load(object sender, EventArgs e)
        {
            textBox1.Text = frm1.textBox1.Text;
        }
    }
}
