using sinavUygulamasi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace sinavUygulamasi.Controllers
{
    public class HomeController : Controller
    {
        sinavdbEntities1 db = new sinavdbEntities1();
        // GET: Home
        public ActionResult Index()
        {
            List<UrunModel> uList = db.urunler.Select(x => new UrunModel
            {
                urun_id = x.urun_id,
                urun_ad = x.urun_ad,
                urun_aciklama = x.urun_aciklama,
                urun_resim = x.urun_resim,
                urun_kategori_id = x.urun_kategori_id,
                urun_kategori = x.kategori.kategori_adi,
                fiyat = x.fiyat,
            }).ToList();
            return View(uList);
        }

     
    }
}