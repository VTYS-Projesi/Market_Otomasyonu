using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Market
{
    public partial class Form4 : Form
    {
        DataTable tablo = new DataTable();
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var m = new Marketİslemleri();
            m.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var m = new Form9();
            m.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string telNo = textBox1.Text;
            using (var db = new DBModels())
            {
                var musteriBorclar = db.MusteriBorclar.Where(m => m.Musteri.MusteriTelNo == telNo).ToList();
                if (musteriBorclar != null)
                {
                    foreach (var musteriBorc in musteriBorclar)
                    {
                        tablo.Rows.Add(musteriBorc.Musteri.MusteriAd, musteriBorc.Musteri.MusteriSoyad, musteriBorc.Borc, musteriBorc.Tarih);
                        dataGridView1.DataSource = tablo;
                    }
                }
                else
                {
                    MessageBox.Show("Girdiğiniz telefon numarasına ait bir müşteri bulunamadı.");
                }


            }
        }



        private void Form4_Load(object sender, EventArgs e)
        {
            tablo.Columns.Add("Müşteri Adı", typeof(string));
            tablo.Columns.Add("Müşteri Soyadı", typeof(string));
            tablo.Columns.Add("Müşterinin Borcu", typeof(int));
            tablo.Columns.Add("Alışveriş Tarihleri", typeof(DateTime));
        }
    }
}
