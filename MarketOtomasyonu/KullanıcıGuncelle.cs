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
    public partial class KullanıcıGuncelle : Form
    {
        Controller.Controller controller = new Controller.Controller();
        public KullanıcıGuncelle()
        {
            InitializeComponent();
            
        }

        private void KullanıcıGuncelle_Load(object sender, EventArgs e)
        {
            usersSellect();
            cmbAddValue();       
            dgv_kullanıcıGuncelle.ReadOnly= true;

        }

        public void cmbAddValue()
        {
            List<User> users = controller.usersSelect();

            foreach (User user in users)
            {
                if (!cmb_yetkiG.Items.Contains(user.permission))
                {
                    cmb_yetkiG.Items.Add(user.permission);
                }

                if (!cmb_gsG.Items.Contains(user.securityQuestion))
                {
                    cmb_gsG.Items.Add(user.securityQuestion);
                }
            }
        }

        public void usersSellect()
        {
            List<User> users = controller.usersSelect();
            dgv_kullanıcıGuncelle.DataSource = users;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            KullanıcıAyarları kullanıcıAyarları = new KullanıcıAyarları();
            kullanıcıAyarları.Show();
            this.Hide();
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            User user = new User();

            int userId;
            if (int.TryParse(txt_idG.Text, out userId))
            {
                user.id = userId;
            }
            else
            {
                MessageBox.Show("Geçerli bir ID giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
           
            user.username = txt_kullanıcıAdiG.Text.ToString();
            user.password = txt_sifreG.Text.ToString();
            user.email = txt_emailG.Text.ToString();
            user.permission = cmb_yetkiG.Text.ToString();
            user.area = txt_bolgeG.Text.ToString();
            user.securityQuestion = cmb_gsG.Text.ToString();
            user.securityAnswer = txt_gcG.Text.ToString();

            LoginStatus result;
            result = controller.usersUpdate(user);
            
            
            if (result == LoginStatus.basarili)
            {
                usersSellect();
                MessageBox.Show("Kayıt başarılı bir şekilde güncellenmiştir!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if(result == LoginStatus.basarisiz)
            {
                MessageBox.Show("Kayıt güncellenirken bir hata oluştu!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

        private void dgv_kullanıcıGuncelle_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_idG.Text = dgv_kullanıcıGuncelle.CurrentRow.Cells[0].Value.ToString();
            txt_kullanıcıAdiG.Text = dgv_kullanıcıGuncelle.CurrentRow.Cells[1].Value.ToString();
            txt_sifreG.Text = dgv_kullanıcıGuncelle.CurrentRow.Cells[2].Value.ToString();
            cmb_yetkiG.Text = dgv_kullanıcıGuncelle.CurrentRow.Cells[5].Value.ToString();
            txt_emailG.Text = dgv_kullanıcıGuncelle.CurrentRow.Cells[4].Value.ToString();
            txt_bolgeG.Text = dgv_kullanıcıGuncelle.CurrentRow.Cells[3].Value.ToString();
            cmb_gsG.Text = dgv_kullanıcıGuncelle.CurrentRow.Cells[6].Value.ToString();
            txt_gcG.Text = dgv_kullanıcıGuncelle.CurrentRow.Cells[7].Value.ToString();
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            txt_idG.Text = string.Empty;
            txt_kullanıcıAdiG.Text = string.Empty;
            txt_sifreG.Text = string.Empty;
            txt_emailG.Text = string.Empty;
            txt_bolgeG.Text= string.Empty;
            txt_gcG.Text = string.Empty;
            cmb_gsG.Text = string.Empty;
            cmb_yetkiG.Text = string.Empty;
        }
    }
}
