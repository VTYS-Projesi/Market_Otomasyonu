using Market.Entities;
using System;
using System.Windows.Forms;
//deneme yorum satırı eklendi
namespace Market
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var m = new Form4();
            m.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string adi = textBox1.Text;
            string soyadi = textBox2.Text;
            string telefonNo = textBox3.Text;

            using (var db = new DBModels())
            {
                if (adi != "" && soyadi != "" && telefonNo != "")
                {
                    var müsteri = new Musteriler();
                    müsteri.MusteriAd = adi;
                    müsteri.MusteriSoyad = soyadi;
                    müsteri.MusteriTelNo = telefonNo;
                    db.Musteriler.Add(müsteri);
                    db.SaveChanges();
                    MessageBox.Show($"{adi} Başarıyla Kayıt Oldunuz.");
                    textBox1.Text = null;
                    textBox2.Text = null;
                    textBox3.Text = null;
                }
                else
                {
                    MessageBox.Show("Eksik giriş yaptınız. Lütfen tekrar deneyiniz.");
                }

            }
        }
    }
}
