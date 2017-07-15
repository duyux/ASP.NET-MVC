using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EBuy.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";
           
            return View();
        }

        public ActionResult About()
        {
            //ViewBag.Message = "Your app description page.";
            ViewData["Username"] = User.Identity.Name;
            ViewData["CompanyName"] = "EBuy:The ASP.NET Demo Site";
            ViewData["CompanyDescription"] = "EBuy is the world leader in ASPNET MVC ddemoing!";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
