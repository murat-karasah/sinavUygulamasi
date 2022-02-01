using sinavUygulamasi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace sinavUygulamasi.Controllers
{
    public class AboutController : Controller
    {
        sinavdbEntities1 db = new sinavdbEntities1();

        // GET: About
        public ActionResult Index()
        {
            List<Hakkimizdamodel> hList = db.hakkimizdas.Select(x => new Hakkimizdamodel
            {
                personel_id = x.personel_id,
                personel_isim = x.personel_isim,
                personel_gorev = x.personel_gorev,
                personel_aciklama = x.personel_aciklama,
                resim = x.resim
            }).ToList();
            return View(hList);
        }

        public ActionResult Tarihce()
        {
            TarihceModel model = new TarihceModel();
            model.tList = db.tarihces.ToList();
            model.oList = db.ozelliklers.ToList();
            return View(model);
            
           
           



        }
    }
}