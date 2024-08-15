using MarketOtomasyonu.Controller;
using MarketOtomasyonu.Enum;
using MarketOtomasyonu.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MarketOtomasyonu
{
    public partial class SifreDegistirme : Form
    {
        MarketOtomasyonu.Controller.Controller cont = new MarketOtomasyonu.Controller.Controller();
        int code;
        public SifreDegistirme()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void SifreDegistirme_Load(object sender, EventArgs e)
        {
            gb2_SifreDegis.Enabled = false;
            gb3_SifreDegisMailAlan.Enabled = false;

            List<LoginTable> loginTables = cont.getLoginTable();

            foreach (LoginTable lt in loginTables)
            {
                cmb_SifreDegisGS.Items.Add(lt.securityQuestion.ToString());
                cmb_SifreDegisGS.SelectedIndex = 0;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btn_SifreDegisSorgula_Click(object sender, EventArgs e)
        {
            LoginStatus result = cont.doAuthentication(txt_SifreDegisKuAdı.Text.Trim().ToLower(), cmb_SifreDegisGS.SelectedItem.ToString(), txt_SifreDegisGC.Text.Trim().ToLower());

            if(result == LoginStatus.basarili)
            {
                MessageBox.Show("İşleminiz başarılı bir şekilde gerçekleşmiştir! Şifrenizi değiştirmek için lütfen mail adresinizi giriniz!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gb3_SifreDegisMailAlan.Enabled = true;
            }
            else if(result == LoginStatus.basarisiz)
            {
                MessageBox.Show("Girdiğiniz bilgileri kontrol ediniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Eksik giriş yaptınız! Lütfen zorunlu alanları boş bırakmayın!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_SifreDegisDKGonder_Click(object sender, EventArgs e)
        {
            bool match = false;
            try
            {             
                MailAddress mailRecipient = new MailAddress(txt_SifreDegisMailAlan.Text,txt_SifreDegisKuAdı.Text);
                List<LoginTable> loginTables = cont.getLoginTable();
                foreach (LoginTable lt in loginTables)
                {
                    if (lt.email == txt_SifreDegisMailAlan.Text && lt.username == txt_SifreDegisKuAdı.Text)
                    {
                       
                        
                        //Bu nesnenin yapıcı methodunun ilk parametresine maili gönderen kişinin mail adresini ikinci parametresinede kişinin adını girin.
                        MailAddress mailSender = new MailAddress("Mail", "İsim");
                        
                        
                        MailMessage mailMessage = new MailMessage();

                        Random rnd = new Random();
                        code = rnd.Next(111111, 999999);

                        mailMessage.To.Add(mailRecipient);
                        mailMessage.From = mailSender;
                        mailMessage.Subject = "Şifre Değiştirme!";
                        mailMessage.Body = "Parola sıfırlama talebiniz alınmıştır. Parolanızı sıfırlamak için kodunuz: " + code;

                        SmtpClient smtp = new SmtpClient("smtp-mail.outlook.com", 587);
                        
                        
                        //Burada SMTP sunucusuna bağlanırken email ve parola ile kimlik doğrulaması yapmak gerekir.
                        //Bu nesnenin ilk parametresine mail adresinizi ikinci parametresine mailinizin şifresini giriniz.
                        smtp.Credentials = new System.Net.NetworkCredential("Mail", "Şifre");
                        
                       
                        smtp.EnableSsl = true;
                        smtp.Send(mailMessage);
                        MessageBox.Show("Doğrulama kodu başarılı bir şekilde gönderildi!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        match = true;
                        break;
                    }                    
                }

                if (!match)
                {
                    MessageBox.Show("Böyle bir kayıt bulunamadı! Lütfen girmiş olduğunuz bilgileri kontrol ediniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
             
            }
            catch (SmtpException smtpEx)
            {
                MessageBox.Show("SMTP Hatası: " + smtpEx.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Genel Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_SifreDegisDKOnay_Click(object sender, EventArgs e)
        {
            if(txt_SifreDegisDogrulamaKodu.Text == code.ToString())
            {
                MessageBox.Show("Doğrulama kodunuz eşleşti!","Bilgilendirme",MessageBoxButtons.OK, MessageBoxIcon.Information);
                gb2_SifreDegis.Enabled = true;
            }
            else
            {
                MessageBox.Show("Doğrulama kodunuz eşleşmedi!","Hata",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void btn_SifreDegisDegistir_Click(object sender, EventArgs e)
        {
            if(txt_SifreDegisYSifre.Text == txt_SifreDegisYSifreTek.Text)
            {
                LoginStatus result = cont.updatePassword(txt_SifreDegisMailAlan.Text, txt_SifreDegisYSifre.Text);
                if (result == LoginStatus.basarili)
                {
                    MessageBox.Show("Şifreniz başarılı bir şekilde değiştirilmiştir!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if(result == LoginStatus.basarisiz)
                {
                    MessageBox.Show("Şifreniz değiştirme işleminiz başarısız olmuştur!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    MessageBox.Show("Boşlukları doğru bir şekilde doldurduğunuzdan emin olunuz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Girdiğiniz şifreler uyuşmamaktadır! Lütfen kontrol edip tekrar deneyiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_CıkısYap_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
