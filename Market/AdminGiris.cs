using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market
{
    public partial class AdminGiris : Form
    {
        public AdminGiris()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = textBox3.Text;
            string sifre = textBox4.Text;
            string email = textBox5.Text;

            using (var db = new DBModels())
            {
                if (kullaniciAdi != "" && sifre != "" && email != "")
                {
                    var kullanici = new kullanıcılar();
                    kullanici.KullaniciAdi = kullaniciAdi;
                    kullanici.Sifre = sifre;
                    kullanici.Email = email;
                    db.kullanıcılar.Add(kullanici);
                    db.SaveChanges();
                    MessageBox.Show($"{kullaniciAdi} Başarıyla Kayıt Oldunuz.");
                    textBox3.Text = null;
                    textBox4.Text = null;
                    textBox5.Text = null;
                }
                else
                {
                    MessageBox.Show("Eksik giriş yaptınız. Lütfen tekrar deneyiniz.");
                }
               
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = textBox1.Text;
            string sifre = textBox2.Text;

            using (var db = new DBModels())
            {
                var kullanici = db.kullanıcılar.FirstOrDefault(a => a.KullaniciAdi == kullaniciAdi && a.Sifre == sifre);
                if (kullanici != null)
                {
                    var m = new Form1();
                    m.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Hatalı giriş yaptınız. Tekrar Deneyiniz.");
                }
            }   
        }

        private void panelLeft_Paint(object sender, PaintEventArgs e)
        {
            timer1.Interval = 10;
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label8.Text = DateTime.Now.ToString();
        }
    }
}
