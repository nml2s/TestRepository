using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBootstrap.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


        public JsonResult GetCountries()
        {
            var Countries = new List<string>();
            Countries.Add("Australia");
            Countries.Add("India");
            Countries.Add("Russia");
            return Json(Countries, JsonRequestBehavior.AllowGet);
        }


        [HttpPost]
        public ActionResult PostTime(string selectedtTime)
        {
            //put a checkpoint here and interrogate selectedTime and work with it
            return Json(new
            {
                aValue = "aValueRet"
            }
                   , @"application/json");
        }

        public ActionResult CountryList()
        {
            return View("Getcountries");
        }




        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Checkout()
        {
            return View();
        }
    }
}