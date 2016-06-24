using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page goes here and below (new branch code and also orig). And this was added on the Github web";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page goes here: this is my contact in main branch - and here is little bit more info";

            return View();
        }
    }
}
