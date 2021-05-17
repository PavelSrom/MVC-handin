using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Globalization;
using System.Web.Helpers; // support images
using MVC_handin.Models;

namespace MVC_handin.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index(string search)
        {
            var factory = new ShopFactory();
            IQueryable<Product> prods = factory.Products.OrderBy(prod => prod.Name);

            if (search != null)
            {
                prods = prods.Where(prod => prod.Name.Contains(search));
            }

            var products = prods.Take(10).ToList();

            return View(products);
        }

        public ViewResult Languages()
        {
            var languages = CultureInfo.GetCultures(CultureTypes.SpecificCultures);
            ViewBag.Languages = languages;

            return View();
        }

        public ActionResult Details(int id)
        {
            var factory = new ShopFactory();
            var found = factory.Products.Where(product => product.ID == id).FirstOrDefault();

            return View(found);
        }

        // get product picture
        public ActionResult Picture(int id)
        {
            var factory = new ShopFactory();
            var product = factory.Products.Where(prod => prod.ID == id).FirstOrDefault();

            if (product == null) return HttpNotFound();

            var img = new WebImage(string.Format("~/Content/Images/{0}.jpg", product.ImageName));
            img.Resize(50, 50);

            return File(img.GetBytes(), "image/jpeg");
        }
    }
}