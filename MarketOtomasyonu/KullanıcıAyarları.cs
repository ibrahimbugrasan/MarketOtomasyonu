using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketOtomasyonu
{
    public partial class KullanıcıAyarları : Form
    {
        public KullanıcıAyarları()
        {
            InitializeComponent();
        }

        private void KullanıcıAyarları_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            KullanıcıSec kullanıcıSec = new KullanıcıSec();
            kullanıcıSec.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            KullanıcıEkle kullanıcıEkle = new KullanıcıEkle();
            kullanıcıEkle.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            KullanıcıGuncelle kullanıcıGuncelle = new KullanıcıGuncelle();
            kullanıcıGuncelle.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            KullanıcıSil kullanıcıSil = new KullanıcıSil();
            kullanıcıSil.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AdminPanel adminPanel = new AdminPanel();
            adminPanel.Show();
            this.Hide();
        }
    }
}
