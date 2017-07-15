using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcGuestbook.Models;

namespace MvcGuestbook.Controllers
{
    public class GuestbookController : Controller
    {
        private MvcGuestbookContext db = new MvcGuestbookContext();

        //
        // GET: /Guestbook/

        public ActionResult Index()
        {
            return View(db.Guestbooks.ToList());
        }

       

        //
        // GET: /Guestbook/Create

        public ActionResult Write()
        {
            return View();
        }

        //
        // POST: /Guestbook/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Write(Guestbook guestbook)
        {
            if (ModelState.IsValid)
            {
                db.Guestbooks.Add(guestbook);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(guestbook);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}