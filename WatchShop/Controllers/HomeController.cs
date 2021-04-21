using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WatchShop.Models;

namespace WatchShop.Controllers
{
    public class HomeController : Controller
    {
        WatchShopContext db = new WatchShopContext();
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

        public ActionResult BrandMenu()
        {
            var model = db.Suppliers;
            return PartialView("_BrandMenu", model);
        }

        public ActionResult Suppliers()
        {
            var model = db.Suppliers;
            return PartialView("_Suppliers", model);
        }

        public ActionResult Special()
        {
            var model = db.Products.Where(p => p.Special == true).Take(4);
            return PartialView("_Special", model);
        }
        public ActionResult Saleoff()
        {
            var model = db.Products.Where(p => p.Discount > 0).Take(4);
            return PartialView("_Saleoff", model);
        }
    }
}