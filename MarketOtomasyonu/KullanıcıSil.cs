using MarketOtomasyonu.Controller;
using MarketOtomasyonu.Enum;
using MarketOtomasyonu.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketOtomasyonu
{
    public partial class KullanıcıSil : Form
    {
        public KullanıcıSil()
        {
            InitializeComponent();
        }

        Controller.Controller controller = new Controller.Controller();

        private void KullanıcıSil_Load(object sender, EventArgs e)
        {
            usersSellect();
        }
        public void usersSellect()
        {
            List<User> users = controller.usersSelect();
            dgv_kullaniciSilS.DataSource = users;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_temizleS_Click(object sender, EventArgs e)
        {
            txt_ıdS.Text = string.Empty;
        }

        private void btn_geriS_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_geriS_Click_1(object sender, EventArgs e)
        {
            KullanıcıAyarları kullanıcıAyarları = new KullanıcıAyarları();
            kullanıcıAyarları.Show();
            this.Hide();
        }

        private void btn_silS_Click(object sender, EventArgs e)
        {
            User user = new User();
            

            DialogResult result = MessageBox.Show("Bu kullanıcıyı silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            
            if(result == DialogResult.Yes)
            {
                              
                int sayi;

                if (int.TryParse(txt_ıdS.Text, out sayi))
                {
                    user.id = sayi;
                    LoginStatus sonuc = controller.usersDelete(user);
                    if (sonuc == LoginStatus.basarili)
                    {
                        usersSellect();
                        MessageBox.Show("Kullanıcı başarılı bir şekilde silinmiştir!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Böyle bir kullanıcı bulunmamaktadır!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                else
                {
                    MessageBox.Show("Lütfen silmek istediğiniz kullanıcının id kodunu giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            else
            {
                return;
            }
            
        }
    }
}
