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
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            lbl_saat.Text = DateTime.Now.Hour.ToString() + ":";
            lbl_dakika.Text = DateTime.Now.Minute.ToString() + ":";
            lbl_saniye.Text = DateTime.Now.Second.ToString();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_saat.Text = DateTime.Now.Hour.ToString() + ":";
            lbl_dakika.Text = DateTime.Now.Minute.ToString() + ":";
            lbl_saniye.Text = DateTime.Now.Second.ToString();
        }

        private void btn_exitAP_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void btn_usersAP_Click(object sender, EventArgs e)
        {
            KullanıcıAyarları kullanıcıAyarları = new KullanıcıAyarları();
            kullanıcıAyarları.Show();
            this.Hide();
        }

        private void btn_exitAP_Click_1(object sender, EventArgs e)
        {
            Form1 form= new Form1();
            form.Show();
            this.Hide();
        }

        private void btn_productsAP_Click(object sender, EventArgs e)
        {
            UrunAyarları urunAyarları = new UrunAyarları();
            urunAyarları.Show();
            this.Hide();
        }
    }
}
