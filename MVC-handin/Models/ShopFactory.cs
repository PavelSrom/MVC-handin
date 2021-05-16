using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MVC_handin.Models
{
    public class ShopFactory : DbContext
    {
        public DbSet<Product> Products { get; set; }
    }


}