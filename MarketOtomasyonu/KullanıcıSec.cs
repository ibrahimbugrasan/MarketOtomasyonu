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
    public partial class KullanıcıSec : Form
    {
        public KullanıcıSec()
        {
            InitializeComponent();
        }
        Controller.Controller controller = new Controller.Controller();

        private void KullanıcıSec_Load(object sender, EventArgs e)
        {
            usersSelect();
        }
        public void usersSelect()
        {
            List<User> users = controller.usersSelect();
            dgv_select.DataSource = users;
        }

        private void lbl_password_Click(object sender, EventArgs e)
        {

        }

        private void dgv_select_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0)
            {
                DataGridViewRow row = dgv_select.Rows[e.RowIndex];

                lbl_ID.Text = row.Cells["id"].Value.ToString();
                lbl_username.Text = row.Cells["username"].Value.ToString();
                lbl_password.Text = row.Cells["password"].Value.ToString();
                lbl_area.Text = row.Cells["area"].Value.ToString();
                lbl_email.Text = row.Cells["email"].Value.ToString();
                lbl_permission.Text = row.Cells["permission"].Value.ToString();
                lbl_sq.Text = row.Cells["securityQuestion"].Value.ToString();
                lbl_sa.Text = row.Cells["securityAnswer"].Value.ToString();
            }
        }

        private void btn_cıkısyapS_Click(object sender, EventArgs e)
        {
            KullanıcıAyarları kullanıcıAyarları = new KullanıcıAyarları();
            kullanıcıAyarları.Show();
            this.Hide();
        }

        private void dgv_select_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_AraU_Click(object sender, EventArgs e)
        {
            User user = controller.userSearchId(txt_IdAra.Text.ToString());

            if(user.status == LoginStatus.basarili)
            {
                List<User> users = new List<User>() { user };
                dgv_select.DataSource = users;
            }
            else if (user.status == LoginStatus.basarisiz)
            {
                MessageBox.Show("Lütfen geçerli bir id değeri giriniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Girdiğiniz id ile eşleşen bir kullanıcı bulunamadı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            List<User> users = controller.usersSelect();
            dgv_select.DataSource = users;
        }
    }
}
