using AForge.Video;
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
    public partial class EtPanel : Form
    {
        public EtPanel()
        {
            InitializeComponent();
            txt_HesapMakinesiGoruntuEP.Text = "0";
        }

        FilterInfoCollection fic;
        VideoCaptureDevice vcd;
        
        private void EtPanel_Load(object sender, EventArgs e)
        {
            lbl_UrunAdi.ForeColor = Color.Red;

            lbl_HourEP.Text = DateTime.Now.Hour.ToString() + "/";
            lbl_MinuteEP.Text = DateTime.Now.Minute.ToString() + "/";
            lbl_SecondEP.Text = DateTime.Now.Second.ToString();
            timer1.Start();

            fic = new FilterInfoCollection(FilterCategory.VideoInputDevice);
           

            foreach (FilterInfo camera in fic)
            {
                cmb_KameraSecEP.Items.Add(camera.Name);
            }
        }

        private void btn_meyveSebzeEP_Click(object sender, EventArgs e)
        {
            MeyveSebzePanel meyveSebzePanel= new MeyveSebzePanel();
            meyveSebzePanel.Show();
            this.Hide();
        }

        private void btn_CıkısYapEP_Click(object sender, EventArgs e)
        {
            CashierPanel cashierPanel= new CashierPanel();
            cashierPanel.Show();
            this.Hide();
        }

        int sayi1;
        int sayi2;
        int islem;
        
        private void SecilenTus(object sender, EventArgs e)
        {
            if(txt_HesapMakinesiGoruntuEP.Text == "0")
            {
                txt_HesapMakinesiGoruntuEP.Text="";
            }
            txt_HesapMakinesiGoruntuEP.Text += ((Button)sender).Text.ToString();

        }

        private void btn_toplamaEP_Click(object sender, EventArgs e)
        {
            sayi1 = int.Parse(txt_HesapMakinesiGoruntuEP.Text);
            txt_HesapMakinesiGoruntuEP.Text = "0";
            islem = 1; //Toplama işlemi
        }

        private void btn_esittirEP_Click(object sender, EventArgs e)
        {
           sayi2 = int.Parse(txt_HesapMakinesiGoruntuEP.Text);

            if(islem== 1)
            {
                txt_HesapMakinesiGoruntuEP.Text = (sayi1 + sayi2).ToString();
            }
            else if (islem == 2)
            {
                ;
                txt_HesapMakinesiGoruntuEP.Text = (sayi1 - sayi2).ToString();
            }
            else if (islem == 3)
            {

                txt_HesapMakinesiGoruntuEP.Text = (sayi1 * sayi2).ToString();
            }
            else
            {
                txt_HesapMakinesiGoruntuEP.Text = (sayi1 / sayi2).ToString();
            }

        }

        private void btn_cıkarmaEP_Click(object sender, EventArgs e)
        {
            islem = 2; // Çıkarma işlemi tipi = 2
            sayi1 = int.Parse(txt_HesapMakinesiGoruntuEP.Text);
            txt_HesapMakinesiGoruntuEP.Text = "0";
        }

        private void btn_carpmaEP_Click(object sender, EventArgs e)
        {
            islem = 3; // Çarpma işlemi tipi = 3
            sayi1 = int.Parse(txt_HesapMakinesiGoruntuEP.Text);
            txt_HesapMakinesiGoruntuEP.Text = "0";
        }

        private void btn_bolmeEP_Click(object sender, EventArgs e)
        {
            islem = 4; // Bölme işlemi tipi = 4
            sayi1 = int.Parse(txt_HesapMakinesiGoruntuEP.Text);
            txt_HesapMakinesiGoruntuEP.Text = "0";
        }

        private void btn_cEP_Click(object sender, EventArgs e)
        {
            txt_HesapMakinesiGoruntuEP.Text = "0";
        }

        private void btn_GeriGelEP_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_HesapMakinesiGoruntuEP.Text))
            {
                txt_HesapMakinesiGoruntuEP.Text = txt_HesapMakinesiGoruntuEP.Text.Substring(0, txt_HesapMakinesiGoruntuEP.Text.Length - 1);

            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_HourEP.Text = DateTime.Now.Hour.ToString() + " /";
            lbl_MinuteEP.Text = DateTime.Now.Minute.ToString() + " /";
            lbl_SecondEP.Text = DateTime.Now.Second.ToString();
            
        }

        private void btn_KameraAcEP_Click(object sender, EventArgs e)
        {
            vcd = new VideoCaptureDevice(fic[cmb_KameraSecEP.SelectedIndex].MonikerString);
            vcd.NewFrame += vcd_newframe;
            vcd.Start();
            timer_barkodEP.Start();
        }

        private void vcd_newframe(object sender, NewFrameEventArgs eventArgs)
        {
            picb_QrKameraEP.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void timer_barkodEP_Tick(object sender, EventArgs e)
        {
            if(picb_QrKameraEP.Image != null)
            {
                BarcodeReader reader = new BarcodeReader();
                Result barcode = reader.Decode((Bitmap)picb_QrKameraEP.Image);

                if(barcode != null)
                {
                    txt_BarkodCıktısıEP.Text = barcode.Text.ToString();
                    timer_barkodEP.Stop();
                }
            }
        }

        private void btn_kameraKapatEP_Click(object sender, EventArgs e)
        {
            vcd.Stop();
            picb_QrKameraEP.Image = Image.FromFile("Pictures/Kamera.png");
        }

        Controller.Controller controller = new Controller.Controller();
        private void txt_BarkodCıktısıEP_TextChanged(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer("barkod.wav");
            player.Play();

            Products product = controller.barcodeReader(txt_BarkodCıktısıEP.Text);

            if (product != null)
            {
                lbl_UrunAdi.Text = product.urunIsim.ToString();
                txt_HesapMakinesiGoruntuEP.Text = product.fiyat.ToString();
            }
            else
            {
                lbl_UrunAdi.Text = "Ürün bulunamadı!";
                txt_HesapMakinesiGoruntuEP.Text = "0";
            }
        }

        private void btn_baklaUrunleriEP_Click(object sender, EventArgs e)
        {
            BaklaPanel bakla = new BaklaPanel();
            bakla.Show();
            this.Hide();
        }

        private void btn_sutUrunleriEP_Click(object sender, EventArgs e)
        {
            SutUrunleriPanel sutUrunleri = new SutUrunleriPanel();
            sutUrunleri.Show();
            this.Hide();
        }
    }
}
