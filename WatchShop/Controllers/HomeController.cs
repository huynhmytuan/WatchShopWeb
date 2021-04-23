using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
            var model = db.Products.OrderByDescending(p=>p.Views).Take(3);
            return PartialView("_Special", model);
        }
        public ActionResult Saleoff()
        {
            var model = db.Products.Where(p => p.Discount > 0).Take(4);
            return PartialView("_Saleoff", model);
        }

        public ActionResult Supplier (String id)
        {
            if (id == "")
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            else
            {
                ViewBag.PageName = db.Suppliers.SingleOrDefault(p => p.Name != null).Name;
                var model = db.Products.Include("Supplier").Where(p => p.SupplierId == id);
                return View(model);
            }
        }
    }
}