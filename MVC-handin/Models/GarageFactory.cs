using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MVC_handin.Models
{
    public class GarageFactory : DbContext
    {
        public DbSet<Car> Cars { get; set; }

        public GarageFactory()
        {
            Database.SetInitializer(new GarageInitializer());
        }
    }
    // initialize GarageFactory if it doesn't exist
    public class GarageInitializer : DropCreateDatabaseIfModelChanges<GarageFactory>
    {
        protected override void Seed(GarageFactory context)
        {
            context.Cars.Add(new Car() { Model = "Volvo", MaxSpeed = 200 });
            context.Cars.Add(new Car() { Model = "Tesla Model S Plaid", MaxSpeed = 20000 });
        }
    }
}