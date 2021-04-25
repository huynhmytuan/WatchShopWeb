using PagedList;
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
    public class ProductsController : Controller
    {
        private WatchShopContext db = new WatchShopContext();

        //
        // GET: /Product/
        public ViewResult Supplier(string sortOrder, string currentFilter, string searchString, int? page, String id)
        {
            ViewBag.CurrentSort = sortOrder;
            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "Name" : "";
            ViewBag.PriceHighLow = sortOrder == "Price" ? "Price_desc" : "Price";
            ViewBag.PriceLowHigh = sortOrder == "Price" ? "Price_asc" : "Price";

            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            ViewBag.CurrentFilter = searchString;

            var products = from s in db.Products.Where(p => p.SupplierId == id)
                            select s;
            if (!String.IsNullOrEmpty(searchString))
            {
                products = products.Where(s => s.Name.Contains(searchString)).Where(s => s.SupplierId.Equals(id));
            }
            switch (sortOrder)
            {
                case "Name":
                    products = products.OrderByDescending(s => s.Name);
                    break;
                case "Price_desc":
                    products = products.OrderByDescending(s => s.UnitPrice);
                    break;
                case "Price_asc":
                    products = products.OrderBy(s => s.UnitPrice);
                    break;

                default:
                    products = products.OrderBy(s => s.UnitPrice);
                    break;
            }

            int pageSize = 6;
            int pageNumber = (page ?? 1);
            return View(products.ToPagedList(pageNumber, pageSize));
        }

        public ViewResult Category(string sortOrder, string currentFilter, string searchString, int? page, int id)
        {
            ViewBag.CurrentSort = sortOrder;
            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "Name" : "";
            ViewBag.PriceHighLow = sortOrder == "Price" ? "Price_desc" : "Price";
            ViewBag.PriceLowHigh = sortOrder == "Price" ? "Price_asc" : "Price";

            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            ViewBag.CurrentFilter = searchString;

            var products = from s in db.Products.Where(p => p.CategoryId == id)
                           select s;
            if (!String.IsNullOrEmpty(searchString))
            {
                products = products.Where(s => s.Name.Contains(searchString)).Where(s => s.CategoryId.Equals(id));
            }
            switch (sortOrder)
            {
                case "Name":
                    products = products.OrderByDescending(s => s.Name);
                    break;
                case "Price_desc":
                    products = products.OrderByDescending(s => s.UnitPrice);
                    break;
                case "Price_asc":
                    products = products.OrderBy(s => s.UnitPrice);
                    break;

                default:
                    products = products.OrderBy(s => s.UnitPrice);
                    break;
            }

            int pageSize = 6;
            int pageNumber = (page ?? 1);
            return View(products.ToPagedList(pageNumber, pageSize));
        }

        // get: products
        public ViewResult Index(string sortOrder, string currentFilter, string searchString, int? page)
            {
            ViewBag.CurrentSort = sortOrder;
            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "Name" : "";
            ViewBag.PriceHighLow = sortOrder == "Price" ? "Price_desc" : "Price";
            ViewBag.PriceLowHigh = sortOrder == "Price" ? "Price_asc" : "Price";

            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            ViewBag.CurrentFilter = searchString;

            var products = from s in db.Products
                           select s;
            if (!String.IsNullOrEmpty(searchString))
            {
                products = products.Where(s => s.Name.Contains(searchString));
            }
            switch (sortOrder)
            {
                case "Name":
                    products = products.OrderByDescending(s => s.Name);
                    break;
                case "Price_desc":
                    products = products.OrderByDescending(s => s.UnitPrice);
                    break;
                case "Price_asc":
                    products = products.OrderBy(s => s.UnitPrice);
                    break;

                default:
                    products = products.OrderBy(s => s.UnitPrice);
                    break;
            }

            int pageSize = 6;
            int pageNumber = (page ?? 1);
            return View(products.ToPagedList(pageNumber, pageSize));
        }

        // GET: Products/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = db.Products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        public ActionResult FeaturedProducts()
        {
            var model = db.Products.Where(p => p.Special == true).Take(6);
            return PartialView("_FeaturedProducts", model);
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
