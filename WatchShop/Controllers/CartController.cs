using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WatchShop.Models;

namespace WatchShop.Controllers
{
    public class CartController : Controller
    {
        public ActionResult Index()
        {
            var cart = ShoppingCart.Cart;
            return View(cart.Items);
        }

        public ActionResult CartView()
        {
            var cart = ShoppingCart.Cart;
            return PartialView("_SideCart",cart.Items);
        }

        public ActionResult Add(int id)
        {
            var cart = ShoppingCart.Cart;
            cart.Add(id);

            var info = new { cart.Count, cart.Total };
            //return RedirectToAction("Index");
            return Json(info, JsonRequestBehavior.AllowGet);
        }


        public ActionResult Remove(int id)
        {
            var cart = ShoppingCart.Cart;
            cart.Remove(id);

            var info = new { cart.Count, cart.Total };
            return Json(info, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Update(int id, int quantity)
        {
            var cart = ShoppingCart.Cart;
            cart.Update(id, quantity);

            var p = cart.Items.Single(i => i.Id == id);
            var info = new
            {
                cart.Count,
                cart.Total,
                Amount = p.UnitPrice * p.Quantity * (1 - p.Discount)
            };
            return Json(info, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Clear()
        {
            var cart = ShoppingCart.Cart;
            cart.Clear();
            return RedirectToAction("Index");
        }
    }
}
