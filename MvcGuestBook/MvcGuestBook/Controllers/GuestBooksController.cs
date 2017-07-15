using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MvcGuestBook.Models;

namespace MvcGuestBook.Controllers
{
    public class GuestBooksController : Controller
    {
        private MvcGuestBookContext db = new MvcGuestBookContext();

     
        public ActionResult TestForm(string userName)
        {
            ViewData.Model = userName;
            return View();
        }
        
        // GET: GuestBooks
        public ActionResult Index()
        {
            return View(db.GuestBooks.ToList());
        }
        

        // GET: GuestBooks/Write
        public ActionResult Write()
        {
            
            return View();
        }

        // POST: GuestBooks/Write
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Write([Bind(Include = "Id,姓名,Email,内容")] GuestBook guestBook)
        {
            if (ModelState.IsValid)
            {
                db.GuestBooks.Add(guestBook);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(guestBook);
        }


        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
