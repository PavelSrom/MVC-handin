using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Globalization;
using System.Web.Mvc;

namespace MVC_handin.ViewModels.Home
{
    public class ShowLanguagesViewModel
    {
        // constructor for languages
        public ShowLanguagesViewModel(CultureInfo[] cultures)
        {
            CultureList = cultures.Select(c => new SelectListItem() { Text = c.EnglishName });
        }

        public IEnumerable<SelectListItem> CultureList { get; set; }
    }
}