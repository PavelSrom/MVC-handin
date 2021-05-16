using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_handin.Models; // so that my Car class is available

namespace MVC_handin.ViewModels.Garage
{
    public class CarListViewModel
    {
        public CarListViewModel(IEnumerable<Car> cars)
        {
            CarsList = cars.Select(c => new SelectListItem() { Text = c.Model });
            FastestCar = cars.OrderByDescending(c => c.MaxSpeed).FirstOrDefault();
        }

        public IEnumerable<SelectListItem> CarsList { get; private set; }
        public Car FastestCar { get; set; }
    }
}