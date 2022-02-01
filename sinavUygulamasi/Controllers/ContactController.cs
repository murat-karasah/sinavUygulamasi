using sinavUygulamasi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace sinavUygulamasi.Controllers
{
    public class ContactController : Controller
    {
        sinavdbEntities1 db = new sinavdbEntities1();

        // GET: Contact
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(iletisim pm)
        {

            db.Entry(pm).State = System.Data.Entity.EntityState.Added;
            db.SaveChanges();
            return RedirectToAction("Index","Home");

        }
    }
}