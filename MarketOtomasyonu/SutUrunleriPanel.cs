using AForge.Video.DirectShow;
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
    public partial class SutUrunleriPanel : Form
    {
        Controller.Controller controller = new Controller.Controller();
        
        int sayi1;
        int sayi2;
        int islem;
        
        public SutUrunleriPanel()
        {
            InitializeComponent();
            txt_HesapMak.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EtPanel et = new EtPanel();
            et.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            BaklaPanel bakla = new BaklaPanel();
            bakla.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MeyveSebzePanel meyveSebzePanel = new MeyveSebzePanel();
            meyveSebzePanel.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CashierPanel cashierPanel = new CashierPanel();
            cashierPanel.Show();
            this.Hide();
        }

        FilterInfoCollection fic;
        VideoCaptureDevice vcd;
        
        private void SutUrunleriPanel_Load(object sender, EventArgs e)
        {
            lbl_UrunAd.ForeColor = Color.Red;

            lbl_saat.Text = DateTime.Now.Hour.ToString() + " /";
            lbl_dakika.Text= DateTime.Now.Minute.ToString() + " /";
            lbl_saniye.Text= DateTime.Now.Second.ToString();
            timer_saat.Start();

            fic = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            foreach (FilterInfo i in fic)
            {
                cmb_kameraSec.Items.Add(i.Name);
            }
        }

        private void timer_saat_Tick(object sender, EventArgs e)
        {
            lbl_saat.Text = DateTime.Now.Hour.ToString() + " /";
            lbl_dakika.Text= DateTime.Now.Minute.ToString() + " /";
            lbl_saniye.Text= DateTime.Now.Second.ToString();
        }

        private void Select(object sender, EventArgs e)
        {
            if(txt_HesapMak.Text == "0")
            {
                txt_HesapMak.Text = "";
            }
            txt_HesapMak.Text +=((Button)sender).Text.ToString();
        }

        private void txt_artı_Click(object sender, EventArgs e)
        {
            sayi1 = int.Parse(txt_HesapMak.Text);
            txt_HesapMak.Text = "0";
            islem = 1;
        }

        private void txt_esittir_Click(object sender, EventArgs e)
        {
            sayi2 = int.Parse(txt_HesapMak.Text);

            if (islem == 1) 
            {
                txt_HesapMak.Text = (sayi1 + sayi2).ToString();
            }
            else if(islem == 2)
            {
                txt_HesapMak.Text = (sayi1 - sayi2).ToString();
            }
            else if(islem == 3)
            {
                txt_HesapMak.Text = (sayi1 * sayi2).ToString();
            }
            else
            {
                txt_HesapMak.Text = (sayi1 / sayi2).ToString();
            }
            
        }

        private void txt_eksi_Click(object sender, EventArgs e)
        {
            sayi1 = int.Parse(txt_HesapMak.Text);
            txt_HesapMak.Text="0";
            islem = 2;
        }

        private void txt_carpı_Click(object sender, EventArgs e)
        {
            sayi1 = int.Parse(txt_HesapMak.Text);
            txt_HesapMak.Text = "0";
            islem = 3;
        }

        private void txt_bol_Click(object sender, EventArgs e)
        {
            sayi1 = int.Parse(txt_HesapMak.Text);
            txt_HesapMak.Text = "0";
            islem = 4;
        }

        private void txt_c_Click(object sender, EventArgs e)
        {
            txt_HesapMak.Text = "0";
        }

        private void txt_geriGel_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_HesapMak.Text))
            {
                txt_HesapMak.Text = txt_HesapMak.Text.Substring(0, txt_HesapMak.Text.Length - 1);
                
            }
           
        }

        private void btn_ac_Click(object sender, EventArgs e)
        {
            if (cmb_kameraSec.SelectedIndex >= 0)
            {
                vcd = new VideoCaptureDevice(fic[cmb_kameraSec.SelectedIndex].MonikerString);
                vcd.NewFrame += Vcd_NewFrame;
                vcd.Start();

                timer_barkod.Start();
              
            }
        }

        private void Vcd_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            pcb_Kamera.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void btn_kapat_Click(object sender, EventArgs e)
        {
            vcd.Stop();
            pcb_Kamera.Image = Image.FromFile("Pictures/Kamera.png");
        }

        
        private void timer_barkod_Tick(object sender, EventArgs e)
        {
            if (pcb_Kamera.Image != null)
            {
                BarcodeReader reader = new BarcodeReader();
                Result decode = reader.Decode((Bitmap)pcb_Kamera.Image);              

                if (decode != null)
                {
                    txt_barkod.Text = decode.ToString();
                    timer_barkod.Stop();
                }
            }
        }

        private void txt_barkod_TextChanged(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer("barkod.wav");
            player.Play();  
            
            Products product = controller.barcodeReader(txt_barkod.Text);

            if (product != null)
            {
                lbl_UrunAd.Text = product.urunIsim.ToString();
                txt_HesapMak.Text = product.fiyat.ToString();
            }
            else
            {
                lbl_UrunAd.Text = "Ürün bulunamadı!";
                txt_HesapMak.Text = "0";
            }

        }
    }
}
