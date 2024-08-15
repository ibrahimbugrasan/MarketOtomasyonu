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
    public partial class CashierPanel : Form
    {
        public CashierPanel()
        {
            InitializeComponent();
        }

        private void btn_CıkısYap_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void lbl_saat_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_saat.Text = DateTime.Now.Hour.ToString() + "/";
            lbl_dakika.Text = DateTime.Now.Minute.ToString() + "/";
            lbl_saniye.Text = DateTime.Now.Second.ToString();
        }

        private void CashierPanel_Load(object sender, EventArgs e)
        {
            timer1.Start();
            lbl_saat.Text = DateTime.Now.Hour.ToString() + "/";
            lbl_dakika.Text = DateTime.Now.Minute.ToString() + "/";
            lbl_saniye.Text = DateTime.Now.Second.ToString();
            
            
        }

        private void btn_sebzeUrunleri_Click(object sender, EventArgs e)
        {
            MeyveSebzePanel meyveSebzePanel= new MeyveSebzePanel();
            meyveSebzePanel.Show();
            this.Hide();
        }

        private void btn_EtUrunleri_Click(object sender, EventArgs e)
        {
            EtPanel etPanel = new EtPanel();
            etPanel.Show();
            this.Hide();
        }

        private void btn_sutUrunleri_Click(object sender, EventArgs e)
        {
            SutUrunleriPanel sut = new SutUrunleriPanel();
            sut.Show();
            this.Hide();
        }

        private void btn_baklaUrunleri_Click(object sender, EventArgs e)
        {
            BaklaPanel baklaPanel= new BaklaPanel();
            baklaPanel.Show();
            this.Hide();    
        }
    }
}
