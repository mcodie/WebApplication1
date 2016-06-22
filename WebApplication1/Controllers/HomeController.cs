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
            ViewBag.Message = "Your application description page goes here and below (added to original branch).";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page goes here.";

            return View();
        }

        public ActionResult NewActionMethod()
        {
            ViewBag.Message = "Your new Action Method.";

            return View();
        }
    }
}