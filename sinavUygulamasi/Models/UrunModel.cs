
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;

namespace sinavUygulamasi.Models
{

    public class UrunModel
    {
        public List<UrunModel> Kategoriler { get; set; }
        public  urunler Urunler { get; set; }
        public int urun_id { get; set; }
        public string urun_ad { get; set; }
        public decimal fiyat { get; set; }
        public string urun_aciklama { get; set; }
        public string urun_kategori { get; set; }
        public string urun_resim { get; set; }
        public int urun_kategori_id { get; set; }

    }
}