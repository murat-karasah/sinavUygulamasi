//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace sinavUygulamasi.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class urunler
    {
       
        public int urun_id { get; set; }
        public string urun_ad { get; set; }
        public decimal fiyat { get; set; }
        public string urun_aciklama { get; set; }
        public string urun_resim { get; set; }
        public int urun_kategori_id { get; set; }
    
        public virtual kategori kategori { get; set; }
    }
}
