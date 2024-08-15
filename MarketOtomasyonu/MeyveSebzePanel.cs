using AForge.Video.DirectShow;
using MarketOtomasyonu.Controller;
using MarketOtomasyonu.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;

namespace MarketOtomasyonu
{
    public partial class MeyveSebzePanel : Form
    {
        int sayi1;
        int sayi2;
        int islemTip;

        Controller.Controller controller = new Controller.Controller();
        
        public MeyveSebzePanel()
        {
            InitializeComponent();
            txt_HesapMakinesiGoruntu.Text = "0";
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        FilterInfoCollection fic;
        VideoCaptureDevice vcd;

        private void MeyveSebzePanel_Load(object sender, EventArgs e)
        {
            lbl_UrunAdi.ForeColor = Color.Red;
            
            lbl_HourMSP.Text = DateTime.Now.Hour.ToString() + "/";
            lbl_MinuteMSP.Text = DateTime.Now.Minute.ToString() + "/";
            lbl_SecondMSP.Text = DateTime.Now.Second.ToString();
            timer1.Start();

            fic = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo camera in fic)
            {
                cmb_KameraSec.Items.Add(camera.Name);
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_HourMSP.Text = DateTime.Now.Hour.ToString() + " /";
            lbl_MinuteMSP.Text = DateTime.Now.Minute.ToString() + " /";
            lbl_SecondMSP.Text = DateTime.Now.Second.ToString();
        }

        private void secilenTus(object sender, EventArgs e)
        {
            if(txt_HesapMakinesiGoruntu.Text == "0")
            {
                txt_HesapMakinesiGoruntu.Text = "";
            }
            txt_HesapMakinesiGoruntu.Text += ((Button)sender).Text.ToString();
            
        }

        private void btn_c_Click(object sender, EventArgs e)
        {
            txt_HesapMakinesiGoruntu.Text = "0";
        }

        private void btn_toplama_Click(object sender, EventArgs e)
        {
            islemTip = 1; // Toplama işlem tipi = 1
            sayi1 = int.Parse(txt_HesapMakinesiGoruntu.Text);
            txt_HesapMakinesiGoruntu.Text = "0";
            
        }

        private void btn_esittir_Click(object sender, EventArgs e)
        {

            sayi2 = int.Parse(txt_HesapMakinesiGoruntu.Text);
            if (islemTip == 1)
            {
                
                txt_HesapMakinesiGoruntu.Text = (sayi1 + sayi2).ToString();
            }
            else if (islemTip == 2)
            {
                ;
                txt_HesapMakinesiGoruntu.Text = (sayi1 - sayi2).ToString();
            }
            else if (islemTip == 3)
            {
                
                txt_HesapMakinesiGoruntu.Text = (sayi1 * sayi2).ToString();
            }
            else
            {
                txt_HesapMakinesiGoruntu.Text = (sayi1 / sayi2).ToString();
            }
        }

        private void btn_cıkarma_Click(object sender, EventArgs e)
        {
            islemTip = 2; // Çıkarma işlemi tipi = 2
            sayi1 = int.Parse(txt_HesapMakinesiGoruntu.Text);
            txt_HesapMakinesiGoruntu.Text = "0";
        }

        private void btn_carpma_Click(object sender, EventArgs e)
        {
            islemTip = 3; // Çarpma işlemi tipi = 3
            sayi1 = int.Parse(txt_HesapMakinesiGoruntu.Text);
            txt_HesapMakinesiGoruntu.Text = "0";
        }

        private void btn_bolme_Click(object sender, EventArgs e)
        {
            islemTip = 4; // Bölme işlemi tipi = 4
            sayi1 = int.Parse(txt_HesapMakinesiGoruntu.Text);
            txt_HesapMakinesiGoruntu.Text = "0";
        }

        private void btn_GeriGel_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txt_HesapMakinesiGoruntu.Text))
            {
                txt_HesapMakinesiGoruntu.Text = txt_HesapMakinesiGoruntu.Text.Substring(0, txt_HesapMakinesiGoruntu.Text.Length - 1);
                
            }
        }

        private void btn_KameraAc_Click(object sender, EventArgs e)
        {
            vcd = new VideoCaptureDevice(fic[cmb_KameraSec.SelectedIndex].MonikerString);
            vcd.NewFrame += Vcd_NewFrame;
            vcd.Start();
            timer_barkod.Start();
        }

        private void Vcd_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            picb_QrKamera.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void btn_kameraKapat_Click(object sender, EventArgs e)
        {
            vcd.Stop();
            picb_QrKamera.Image = Image.FromFile("Pictures/Kamera.png");
        }

        private void txt_BarkodCıktısı_TextChanged(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer("barkod.wav");
            player.Play();

            Products product = controller.barcodeReader(txt_BarkodCıktısı.Text.ToString());

            if (product != null)
            {
                lbl_UrunAdi.Text = product.urunIsim.ToString();
                txt_HesapMakinesiGoruntu.Text = product.fiyat.ToString();
            }
            else
            {
                lbl_UrunAdi.Text = "Ürün bulunamadı!";
                txt_HesapMakinesiGoruntu.Text = "0";
            }


        }

        private void timer_barkod_Tick(object sender, EventArgs e)
        {
            if(picb_QrKamera.Image!= null)
            {
                BarcodeReader reader = new BarcodeReader();
                Result barcode = reader.Decode((Bitmap)picb_QrKamera.Image);
                
                if(barcode!=null)
                {
                    txt_BarkodCıktısı.Text= barcode.ToString();
                    timer_barkod.Stop();
                }
            }
           
        }

        private void txt_HesapMakinesiGoruntu_TextChanged(object sender, EventArgs e)
        {
             
        }

        private void btn_etPanelMSP_Click(object sender, EventArgs e)
        {
            EtPanel etPanel = new EtPanel();
            etPanel.Show();
            this.Hide();
        }

        private void btn_CıkısYapMSP_Click(object sender, EventArgs e)
        {
            CashierPanel cashierPanel= new CashierPanel();
            cashierPanel.Show();
            this.Hide();
        }

        private void btn_baklaUrunleriMSP_Click(object sender, EventArgs e)
        {
            BaklaPanel bakla = new BaklaPanel();
            bakla.Show();
            this.Hide();
        }

        private void btn_sutUrunleriMSP_Click(object sender, EventArgs e)
        {
            SutUrunleriPanel sutUrunleri = new SutUrunleriPanel();
            sutUrunleri.Show();
            this.Hide();
        }
    }
}
