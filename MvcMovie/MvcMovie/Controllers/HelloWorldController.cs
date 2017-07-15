using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld
        public ActionResult Index()
        {
            return View();
        }

        // GET: HelloWorld
        public ActionResult Welcome(string Name,int numTimes=1)
        {
            ViewBag.Message = "Hello" + Name;
            ViewBag.NumTimes = numTimes;
            return View();
        }
    }
}