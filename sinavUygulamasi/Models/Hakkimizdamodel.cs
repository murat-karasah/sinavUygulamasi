using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sinavUygulamasi.Models
{
    public class Hakkimizdamodel
    {
        public int personel_id { get; set; }
        public string personel_isim { get; set; }
        public string personel_gorev { get; set; }
        public string personel_aciklama { get; set; }
        public string resim { get; set; }
    }
}