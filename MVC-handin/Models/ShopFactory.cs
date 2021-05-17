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

        public ShopFactory()
        {
            Database.SetInitializer(new ShopInitializer());
        }
    }

    public class ShopInitializer : DropCreateDatabaseIfModelChanges<ShopFactory>
    {
        protected override void Seed(ShopFactory context)
        {
            context.Products.Add(new Product() { Name = "Yoghurt", Description = "This creamy one will melt you", Price = 5.4M });
            context.Products.Add(new Product() { Name = "Cleaning lotion", Description = "Nothing gets in its way", Price = 64M });
            context.Products.Add(new Product() { Name = "Banana", Description = "Hungry? Get some banana!", Price = 3M });
        }
    }
}