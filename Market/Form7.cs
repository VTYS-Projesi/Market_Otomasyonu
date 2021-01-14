using Market.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var m = new Form2();
            m.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string fileName = openFileDialog1.FileName;
            using (FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read))
            {
                StreamReader srd = new StreamReader(fs);
                string ln;
                while ((ln = srd.ReadLine()) != null)
                {
                    var urun = new Urunler();
                    var values = ln.Split(',');
                    urun.IrsaliyeNo = Int32.Parse(values[0]);
                    urun.UrunKodu = Int32.Parse(values[1]);
                    urun.BarkodNo = Int32.Parse(values[2]);
                    urun.AlisFiyat = Int32.Parse(values[3]);
                    urun.Miktar = Int32.Parse(values[4]);
                    using (var db = new DBModels())
                    {
                        db.Urunler.Add(urun);
                        db.SaveChanges();
                    }
                }
                srd.Close();
                fs.Close();

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var m = new UrunEkleme();
            m.Show();
            this.Hide();
        }
    }
}
