using sinavUygulamasi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace sinavUygulamasi.Controllers
{
    public class UrunController : Controller
    {
        sinavdbEntities1 db = new sinavdbEntities1();
        UrunModel model = new UrunModel();

        // GET: Urun
        public ActionResult Detay(int id)
        {
            model.Urunler = db.urunler.Find(id);
            return View(model);
        }
    }
}