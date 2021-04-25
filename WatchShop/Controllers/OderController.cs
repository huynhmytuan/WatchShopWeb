using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WatchShop.Models;

namespace WatchShop.Controllers
{
    public class OderController : Controller
    {
        WatchShopContext db = new WatchShopContext();
        // GET: Oder
        public ActionResult Checkout()
        {
            var model = new Order();
            model.Username = User.Identity.Name;
            model.OrderDate = DateTime.Now.Date;
            model.RequireDate = DateTime.Now.Date;
            model.Amount = ShoppingCart.Cart.Total;

            return View(model);
        }

        public ActionResult Purchase(Order model)
        {
            db.Orders.Add(model);
            var cart = ShoppingCart.Cart;
            foreach (var p in cart.Items)
            {
                var d = new OrderDetail
                {
                    Order = model,
                    ProductId = p.Id,
                    UnitPrice = p.UnitPrice,
                    Discount = p.Discount,
                    Quantity = p.Quantity
                };
                var prod = db.Products.Find(p.Id);
                db.Products.Remove(prod);
                db.SaveChanges();
                prod.Views = prod.Views + 1;
                prod.Quantity = prod.Quantity - p.Quantity;
                db.Products.Add(prod);
                db.OrderDetails.Add(d);
            }
            db.SaveChanges();

            // Thanh toán trực tuyến
            //var api = new WebApiClient<AccountInfo>();
            //var data = new AccountInfo { 
            //    Id=Request["BankAccount"],
            //    Balance = cart.Total
            //};
            //api.Put("api/Bank/nn", data);
            return RedirectToAction("Detail", new { id = model.Id });
        }

        public ActionResult Detail(int id, Order model)
        {
            
            var cart = ShoppingCart.Cart;
            cart.Clear();
            RedirectToAction("Detail", new { id = model.Id });
            var order = db.Orders.Find(id);
            return View(order);
        }
        public ActionResult List()
        {
            var orders = db.Orders
                .Where(o => o.Username == User.Identity.Name);
            return View(orders);
        }
    }
}