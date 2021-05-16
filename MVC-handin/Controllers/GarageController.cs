using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_handin.Models; // so that GarageFactory is available
using MVC_handin.ViewModels.Garage;

namespace MVC_handin.Controllers
{
    public class GarageController : Controller
    {
        // GET: Garage
        public ActionResult CarsList()
        {
            var factory = new GarageFactory();
            var viewModel = new CarListViewModel(factory.Cars);

            return View(viewModel);
        }
    }
}