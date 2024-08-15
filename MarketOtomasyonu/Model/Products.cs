using MarketOtomasyonu.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketOtomasyonu.Model
{
    public class Products
    {
        public string id { get; set; }
        public string qrkod { get; set; }
        public string barkodkod { get; set; }
        public DateTime olusturulma_Tarih { get; set; }
        public DateTime guncelleme_Tarih { get; set; }
        public string urunIsim { get; set; }
        public float kilo { get; set; }
        public int fiyat { get; set; }
        public int ciro { get; set; }
        public LoginStatus status { get; set; }
    }
}
