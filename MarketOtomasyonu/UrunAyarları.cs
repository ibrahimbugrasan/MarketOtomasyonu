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
    public partial class UrunAyarları : Form
    {
        Controller.Controller controller = new Controller.Controller();
        public UrunAyarları()
        {
            InitializeComponent();
        }

        private void btn_geriU_Click(object sender, EventArgs e)
        {
            AdminPanel adminPanel = new AdminPanel();
            adminPanel.Show();
            this.Hide();
        }

        private void UrunAyarları_Load(object sender, EventArgs e)
        {
            productsSelect();          
            
        }

        public void productsSelect()
        {
            List<Products> productsList = controller.productsSelect();          
            dgv_urunler.DataSource = productsList;
        }

        private void btn_ekleU_Click(object sender, EventArgs e)
        {
            Products products = new Products();
            products.id = txt_ıdU.Text.ToString();

            string tarih = dtp_otU.Text.ToString();
            if (!string.IsNullOrEmpty(tarih) && DateTime.TryParse(tarih,out DateTime tarihOlusturma))
            {
                products.olusturulma_Tarih = tarihOlusturma;
            }
            else
            {
                products.olusturulma_Tarih = new DateTime(2024, 1, 1);
            }
            
            
            products.barkodkod = txt_barkodkodU.Text.ToString();
            products.urunIsim = txt_isimU.Text.ToString();


            string fiyat = txt_fiyatU.Text.ToString();
            if(!string.IsNullOrEmpty(fiyat) && int.TryParse(fiyat,out int fiyatD))
            {
                products.fiyat = fiyatD;
            }
            else
            {
                products.fiyat = 0;
            }


            string kilo = txt_kiloU.Text.ToString();
            if(!string.IsNullOrEmpty(kilo) && float.TryParse(kilo,out float kiloD))
            {
                products.kilo = kiloD;
            }
            else
            {
                products.kilo = 0;
            }

            string guncelleme = dtp_gtU.Text.ToString();
            if (!string.IsNullOrEmpty(guncelleme) && DateTime.TryParse(guncelleme,out DateTime gTarih))
            {
                products.guncelleme_Tarih = gTarih;
            }
            else
            {
                products.guncelleme_Tarih = new DateTime(2024, 1, 1);

            }

            string ciro = txt_ciroU.Text.ToString();
            if (!string.IsNullOrEmpty(ciro) && int.TryParse(ciro,out int sayı))
            {
                products.ciro = sayı;
            }
            else
            {
                products.ciro = 0;
                

            }


            LoginStatus result = controller.productsInsert(products);
            


            if(result == LoginStatus.basarili)
            {
                productsSelect();
                dgv_urunler.Refresh();
                MessageBox.Show("Yeni ürün başarılı bir şekilde eklenmiştir!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            else if(result== LoginStatus.basarisiz)
            {
                MessageBox.Show("Yeni ürün eklenirken bir hata meydana geldi!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Doldurulması zorunlu alanları doldurduğunuzdan emin olunuz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void dgv_urunler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_ıdU.Text = dgv_urunler.CurrentRow.Cells[0].Value.ToString();
            txt_barkodkodU.Text = dgv_urunler.CurrentRow.Cells[2].Value.ToString();
            
            txt_isimU.Text = dgv_urunler.CurrentRow.Cells[5].Value.ToString();
            txt_kiloU.Text = dgv_urunler.CurrentRow.Cells[6].Value.ToString();
            txt_fiyatU.Text = dgv_urunler.CurrentRow.Cells[7].Value.ToString();
            txt_ciroU.Text = dgv_urunler.CurrentRow.Cells[8].Value.ToString();


        }

        private void btn_temizleU_Click(object sender, EventArgs e)
        {
            txt_barkodkodU.Text = string.Empty;
            txt_ciroU.Text = string.Empty;
            txt_fiyatU.Text = string.Empty;
            dtp_gtU.Text = string.Empty;
            txt_isimU.Text = string.Empty;
            txt_kiloU.Text = string.Empty;
            dtp_otU.Text = string.Empty;
            txt_ıdAraU.Text = string.Empty;
            txt_ıdU.Text = string.Empty;

        }

        private void btn_silU_Click(object sender, EventArgs e)
        {
            Products products = new Products();
            products.id = txt_ıdU.Text.ToString();

            DialogResult result = MessageBox.Show("Bu ürünü silmek istediğinizden emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if(result == DialogResult.Yes)
            {
                if (!string.IsNullOrEmpty(txt_ıdU.Text))
                {
                    LoginStatus sonuc = controller.productsDelete(products);
                    if (sonuc == LoginStatus.basarili)
                    {
                        productsSelect();
                        MessageBox.Show("Ürün başarılı bir şekilde silinmiştir!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }

                    else if (sonuc == LoginStatus.basarisiz)
                    {
                        MessageBox.Show("Bu ID numarasına sahip bir ürün bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen silmek istediğiniz ürünün ID numarasını giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }



            }
            else
            {
                return;
            }

        }

        private void btn_guncelleU_Click(object sender, EventArgs e)
        {
            Products products = new Products();

            products.id = txt_ıdU.Text.ToString();
            products.barkodkod = txt_barkodkodU.Text.ToString();
            products.urunIsim = txt_isimU.Text.ToString();

            string ot = dtp_otU.Text.ToString();
            if(!string.IsNullOrEmpty(ot) && DateTime.TryParse(ot,out DateTime oTarih))
            {
                products.olusturulma_Tarih = oTarih;
            }
            else
            {
                products.olusturulma_Tarih = new DateTime(2024, 1, 1);

            }

            string gt = dtp_gtU.Text.ToString();
            if (!string.IsNullOrEmpty(ot) && DateTime.TryParse(ot, out DateTime gTarih))
            {
                products.guncelleme_Tarih = gTarih;
            }
            else
            {
                products.guncelleme_Tarih = new DateTime(2024, 1, 1);
            }

            string kilo = txt_kiloU.Text.ToString();
            if(!string.IsNullOrEmpty(kilo) && float.TryParse(kilo,out float k))
            {
                products.kilo = k;
            }
            else
            {
                products.kilo = 0;
            }

            string fiyat = txt_fiyatU.Text.ToString();
            if(!string.IsNullOrEmpty(fiyat) && int.TryParse(fiyat,out int f))
            {
                products.fiyat = f;
            }
            else
            {
                products.fiyat = 0;

            }

            string ciro = txt_ciroU.Text.ToString();
            if(!string.IsNullOrEmpty(ciro) && int.TryParse(ciro,out int c))
            {
                products.ciro = c;
            }
            else
            {
                products.ciro = 0;

            }


            LoginStatus result = controller.productsUpdate(products);

            if (result == LoginStatus.basarili)
            {
                productsSelect();
                MessageBox.Show("Güncelleme işlemi başarılı bir şekilde gerçekleşmiştir!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if(result== LoginStatus.basarisiz)
            {
                MessageBox.Show("Güncelleme işlemi sırasında bir hata meydana geldi!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                MessageBox.Show("Doldurulması zorunlu alanları doldurduğunuzdan emin olunuz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void btn_araU_Click(object sender, EventArgs e)
        {
            Products products = controller.productSearchId(txt_ıdAraU.Text.ToString());

            if(products != null)
            {
                List<Products> list = new List<Products>() { products };
                dgv_urunler.DataSource = list;
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir değer girdiğinizden emin olunuz!","Uyarı",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            List<Products> productsList = controller.productsSelect();
            dgv_urunler.DataSource = productsList;
        }
    }
}
