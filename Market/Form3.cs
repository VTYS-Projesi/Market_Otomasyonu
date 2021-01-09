using System;
using System.Linq;
using System.Windows.Forms;

namespace Market
{
    public partial class Form3 : Form
    {
        private SatisEkrani frm1;
        public Form3(SatisEkrani frm1)
        {
            this.frm1 = frm1;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var m = new SatisEkrani();
            m.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string telNo = textBox1.Text;
            using (var db = new DBModels())
            {
                var musteri = db.Musteriler.FirstOrDefault(t => t.MusteriTelNo == telNo);
                if (musteri != null)
                {
                    musteri.Borc = Int32.Parse(frm1.textBox1.Text);
                }
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            textBox2.Text = frm1.textBox1.Text;
        }
    }
}
