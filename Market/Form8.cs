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
    public partial class Form8 : Form
    {
        DataTable tablo = new DataTable();
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var m = new Form2();
            m.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string tedAdi = textBox1.Text;
            using (var db = new DBModels())
            {
                var tedarikciler = db.Tedarikciler.Where(t => t.TedarikciAdi == tedAdi).ToList();
                if (tedarikciler != null)
                {

                    foreach (var tedarikci in tedarikciler)
                    {
                        var borc = tedarikci.Borc;
                        if (borc == null)
                        {
                            tablo.Rows.Add(tedarikci.TedarikciAdi, 0);
                            dataGridView1.DataSource = tablo;
                        }
                        else
                        {
                            tablo.Rows.Add(tedarikci.TedarikciAdi, borc);
                            dataGridView1.DataSource = tablo;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Girdiğiniz telefon numarasına ait bir müşteri bulunamadı.");
                }


            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var m = new Form10();
            m.Show();
            this.Hide();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            tablo.Columns.Add("Tedarikçi Adı", typeof(string));
            tablo.Columns.Add("Tedarikçiye Olan Borcumuz", typeof(int));
        }
    }
}
