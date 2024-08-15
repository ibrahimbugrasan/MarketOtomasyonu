using MarketOtomasyonu.Controller;
using MarketOtomasyonu.Enum;
using MarketOtomasyonu.Model;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Controller.Controller controller = new Controller.Controller();
            User result = controller.login(txt_KullaniciAdi.Text, txt_sifre.Text);

            if(result != null && result.status==LoginStatus.basarili && result.permission == "admin")
            {
                AdminPanel admin = new AdminPanel();
                admin.Show();
                this.Hide();
            }
            else if(result != null && result.status==LoginStatus.basarili && result.permission == "kasiyer")
            {
                CashierPanel cashier = new CashierPanel();
                cashier.Show();
                this.Hide();
            }
            else if(result != null && result.status == LoginStatus.basarisiz)
            {
                MessageBox.Show("Girdiğiniz bilgilerle eşleşen bir kullanıcı bulunamadı! Lütfen bilgilerinizi kontrol edip tekrar deneyin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Lütfen zorunlu alanların hepsini doldurduğunuzdan emin olun!","Hata",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
             
        }

        private void label3_Click(object sender, EventArgs e)
        {
            SifreDegistirme SD = new SifreDegistirme();            
            SD.Show();
            this.Hide();
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void label3_MouseHover(object sender, EventArgs e)
        {

        }

        private void label3_MouseLeave_1(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }
    }
}
