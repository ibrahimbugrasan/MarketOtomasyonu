using AForge.Video.DirectShow;
using MarketOtomasyonu.Controller;
using MarketOtomasyonu.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;

namespace MarketOtomasyonu
{
    public partial class BaklaPanel : Form
    {
        FilterInfoCollection fic;
        VideoCaptureDevice vcd;

        int sayi1;
        int sayi2;
        int islemTip;

        public BaklaPanel()
        {
            InitializeComponent();
            txt_HesapMakinesiGoruntuBP.Text = "0";
        }

        private void btn_KameraAcEP_Click(object sender, EventArgs e)
        {
            vcd = new VideoCaptureDevice(fic[cmb_KameraSecBP.SelectedIndex].MonikerString);
            vcd.NewFrame += Vcd_NewFrame;
            vcd.Start();
            timer_barkod.Start();
        }

        private void Vcd_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            picb_QrKameraBP.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void BaklaPanel_Load(object sender, EventArgs e)
        {
            lbl_UrunAdi.ForeColor = Color.Red;

            lbl_HourBP.Text = DateTime.Now.Hour.ToString() + "/";
            lbl_MinuteBP.Text = DateTime.Now.Minute.ToString() + "/";
            lbl_SecondBP.Text = DateTime.Now.Second.ToString();
            timer1.Start();

            fic = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            foreach (FilterInfo name in fic)
            {
                cmb_KameraSecBP.Items.Add(name.Name);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_HourBP.Text = DateTime.Now.Hour.ToString() + " /";
            lbl_MinuteBP.Text = DateTime.Now.Minute.ToString() + " /";
            lbl_SecondBP.Text = DateTime.Now.Second.ToString();
        }

        private void timer_barkod_Tick(object sender, EventArgs e)
        {
            if(picb_QrKameraBP.Image!= null)
            {
                BarcodeReader br = new BarcodeReader();
                Result result = br.Decode((Bitmap)picb_QrKameraBP.Image);

                if(result != null)
                {
                    txt_BarkodCıktısıBP.Text = result.ToString();
                    timer_barkod.Stop();
                }
            }
        }

        private void btn_dokuzBP_Click(object sender, EventArgs e)
        {                    
                if (txt_HesapMakinesiGoruntuBP.Text == "0")
                {
                    txt_HesapMakinesiGoruntuBP.Text = "";
                }
                txt_HesapMakinesiGoruntuBP.Text += ((Button)sender).Text.ToString();          
        }

        private void btn_cBP_Click(object sender, EventArgs e)
        {
            txt_HesapMakinesiGoruntuBP.Text = "0";
        }

        private void btn_toplamaBP_Click(object sender, EventArgs e)
        {
            islemTip = 1; // Toplama işlem tipi = 1
            sayi1 = int.Parse(txt_HesapMakinesiGoruntuBP.Text);
            txt_HesapMakinesiGoruntuBP.Text = "0";
        }

        private void btn_esittirBP_Click(object sender, EventArgs e)
        {
            sayi2 = int.Parse(txt_HesapMakinesiGoruntuBP.Text);
            if (islemTip == 1)
            {

                txt_HesapMakinesiGoruntuBP.Text = (sayi1 + sayi2).ToString();
            }
            else if (islemTip == 2)
            {
                ;
                txt_HesapMakinesiGoruntuBP.Text = (sayi1 - sayi2).ToString();
            }
            else if (islemTip == 3)
            {

                txt_HesapMakinesiGoruntuBP.Text = (sayi1 * sayi2).ToString();
            }
            else
            {
                txt_HesapMakinesiGoruntuBP.Text = (sayi1 / sayi2).ToString();
            }
        }

        private void btn_cıkarmaBP_Click(object sender, EventArgs e)
        {
            islemTip = 2; // Çıkarma işlemi tipi = 2
            sayi1 = int.Parse(txt_HesapMakinesiGoruntuBP.Text);
            txt_HesapMakinesiGoruntuBP.Text = "0";
        }

        private void btn_carpmaBP_Click(object sender, EventArgs e)
        {
            islemTip = 3; // Çarpma işlemi tipi = 3
            sayi1 = int.Parse(txt_HesapMakinesiGoruntuBP.Text);
            txt_HesapMakinesiGoruntuBP.Text = "0";
        }

        private void btn_bolmeBP_Click(object sender, EventArgs e)
        {
            islemTip = 4; // Bölme işlemi tipi = 4
            sayi1 = int.Parse(txt_HesapMakinesiGoruntuBP.Text);
            txt_HesapMakinesiGoruntuBP.Text = "0";
        
        }

        private void btn_GeriGelBP_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_HesapMakinesiGoruntuBP.Text))
            {
                txt_HesapMakinesiGoruntuBP.Text = txt_HesapMakinesiGoruntuBP.Text.Substring(0, txt_HesapMakinesiGoruntuBP.Text.Length - 1);

            }
        }

        private void btn_kameraKapatBP_Click(object sender, EventArgs e)
        {
            vcd.Stop();
            picb_QrKameraBP.Image = Image.FromFile("Pictures/Kamera.png");
        }

        private void btn_CıkısYapBP_Click(object sender, EventArgs e)
        {
            CashierPanel cashier= new CashierPanel();
            cashier.Show();
            this.Hide();
        }

        private void btn_meyveSebzeBP_Click(object sender, EventArgs e)
        {
            MeyveSebzePanel ms = new MeyveSebzePanel();
            ms.Show();
            this.Hide();
        }

        private void btn_baklaUrunleriBP_Click(object sender, EventArgs e)
        {

        }

        private void btn_sutUrunleriBP_Click(object sender, EventArgs e)
        {
            SutUrunleriPanel sut = new SutUrunleriPanel();
            sut.Show();
            this.Hide();
        }

        private void btn_etPanelBP_Click(object sender, EventArgs e)
        {
            EtPanel et = new EtPanel();
            et.Show();
            this.Hide();
        }

        Controller.Controller controller = new Controller.Controller();
        private void txt_BarkodCıktısıBP_TextChanged(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer("barkod.wav");
            player.Play();

            Products product = controller.barcodeReader(txt_BarkodCıktısıBP.Text);

            if (product != null)
            {
                lbl_UrunAdi.Text = product.urunIsim.ToString();
                txt_HesapMakinesiGoruntuBP.Text = product.fiyat.ToString();
            }
            else
            {
                lbl_UrunAdi.Text = "Ürün bulunamadı!";
                txt_HesapMakinesiGoruntuBP.Text = "0";
            }
        }
    }
}
