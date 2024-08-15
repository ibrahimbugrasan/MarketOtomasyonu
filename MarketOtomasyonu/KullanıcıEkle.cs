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
    public partial class KullanıcıEkle : Form
    {
        Controller.Controller controller = new Controller.Controller();
        public KullanıcıEkle()
        {
            InitializeComponent();
        }

        private void KullanıcıEkle_Load(object sender, EventArgs e)
        {
            usersSellect();
            cmbAddValue();

            cmb_gsE.SelectedIndex = 0;
            cmb_yetkiE.SelectedIndex = 0;
        }

        public void usersSellect()
        {
            List<User> users = controller.usersSelect();
            dgv_KullanıcıEkle.DataSource = users;
        }

        private void btn_ekleE_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.username = txt_kullanıcıAdıE.Text.ToString();
            user.password = txt_sifreE.Text.ToString();
            user.email = txt_emailE.Text.ToString();
            user.securityAnswer = txt_gcE.Text.ToString();
            user.securityQuestion = cmb_gsE.SelectedItem.ToString();
            user.permission = cmb_yetkiE.SelectedItem.ToString();
            user.area = txt_bolgeE.Text.ToString();

            LoginStatus result = controller.usersInsert(user);

            if(result== LoginStatus.basarili)
            {
                usersSellect();
                MessageBox.Show("Kayıt başarılı bir şekilde eklenmiştir!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            else if(result == LoginStatus.basarisiz)
            {
                MessageBox.Show("Kayıt ekleme işlemi başarısız olmuştur!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Doldurulması zorunlu alanları doldurduğunuzdan emin olunuz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            

        }

        public void cmbAddValue()
        {
            List<User> users = controller.usersSelect();

            foreach (User user in users)
            {
                if (!cmb_yetkiE.Items.Contains(user.permission))
                {
                    cmb_yetkiE.Items.Add(user.permission);
                }
                
                if (!cmb_gsE.Items.Contains(user.securityQuestion))
                {
                    cmb_gsE.Items.Add(user.securityQuestion);
                }



            }
        }

        private void btn_cıkısYapE_Click(object sender, EventArgs e)
        {
            KullanıcıAyarları kullanıcıAyarları = new KullanıcıAyarları();
            kullanıcıAyarları.Show();
            this.Hide();
        }

        private void btn_TemizleE_Click(object sender, EventArgs e)
        {
            txt_bolgeE.Text = string.Empty;
            txt_emailE.Text = string.Empty;
            txt_gcE.Text = string.Empty;
            txt_kullanıcıAdıE.Text = string.Empty;
            txt_sifreE.Text = string.Empty;
        }
    }
}
