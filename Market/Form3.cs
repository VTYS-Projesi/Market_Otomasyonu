using Market.Entities;
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
                var musteriBorc = new MusteriBorc();
                musteriBorc.Tarih = DateTime.Now;
                musteriBorc.Borc = textBox2.Text;
                var musteri = db.Musteriler.FirstOrDefault(t => t.MusteriTelNo == telNo);
                if (musteri != null)
                {
                    musteriBorc.MusteriId = musteri.MusteriId;
                    db.MusteriBorclar.Add(musteriBorc);
                    db.SaveChanges();
                    MessageBox.Show($"{musteri.MusteriAd} Müşterisine {musteriBorc.Borc} TL'lik Borç Başarıyla Eklendi.");
                }
                else
                {
                    MessageBox.Show("Bu telefon numarasına ait müşteri bulunamadı.");
                }
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            textBox2.Text = frm1.textBox1.Text;
        }
    }
}
