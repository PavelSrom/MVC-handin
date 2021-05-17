using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Globalization;
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
    }
}