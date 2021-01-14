using Market.Entities;
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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Geri_Click(object sender, EventArgs e)
        {
            var m = new Form8();
            m.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string adi = textBox1.Text;

            using (var db = new DBModels())
            {
                if (adi != "")
                {
                    var tedarikci = new Tedarikciler();
                    tedarikci.TedarikciAdi = adi;
                    db.Tedarikciler.Add(tedarikci);
                    db.SaveChanges();
                    MessageBox.Show($"{adi} Başarıyla Eklendiniz.");
                    textBox1.Text = null;
                }
                else
                {
                    MessageBox.Show("Eksik Giriş Yaptınız. Lütfen Tekrar Deneyiniz.");
                }

            }
        }
    }
}
