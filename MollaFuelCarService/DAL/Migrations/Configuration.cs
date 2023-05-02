namespace DAL.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DAL.MFCSContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DAL.MFCSContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            Random random = new Random();

            for (int i = 1; i <= 5; i++)
            {

                context.Admins.AddOrUpdate(new Models.Admin
                {
                    Name = Guid.NewGuid().ToString().Substring(0, 10),
                    Username = "Admin-" + i,
                    Email = "adminuser" + i + "@gmail.com",
                    Password = Guid.NewGuid().ToString().Substring(0, 6)
                });
            }

            //Seed for Customer Table
            for (int i = 1; i <= 5; i++)
            {
                int year = random.Next(1950, 2022); // Generate a random year between 1950 and 2021
                int month = random.Next(1, 13); // Generate a random month between 1 and 12
                int daysInMonth = DateTime.DaysInMonth(year, month);
                int day = random.Next(1, daysInMonth + 1);
                int genderValue = random.Next(1, 3);
                context.Customers.AddOrUpdate(new Models.Customer
                {
                    Name = Guid.NewGuid().ToString().Substring(0, 10),
                    Username = "username-" + i,
                    Dob = new DateTime(year, month, day),
                    Gender = (genderValue == 1) ? "Male" : "Female",
                    Phone = "01" + random.Next(1, 10).ToString() + random.Next(10000000, 99999999).ToString(),
                    Email = "username-" + i + "@gmail.com",
                    Location = "Road-" + (i * 3) + ", Area-" + ((12 * i) - 11),
                    Password = Guid.NewGuid().ToString().Substring(0, 6)
                });
            }

            //Seed for DeliveryMan Table
            for (int i = 1; i <= 5; i++)
            {
                int year = random.Next(1950, 2022); // Generate a random year between 1950 and 2021
                int month = random.Next(1, 13); // Generate a random month between 1 and 12
                int daysInMonth = DateTime.DaysInMonth(year, month);
                int day = random.Next(1, daysInMonth + 1);
                int genderValue = random.Next(1, 3);
                context.DeliveryMans.AddOrUpdate(new Models.DeliveryMan
                {
                    Name = Guid.NewGuid().ToString().Substring(0, 10),
                    Username = "Deliveryman-" + i,
                    Dob = new DateTime(year, month, day),
                    Gender = (genderValue == 1) ? "Male" : "Female",
                    Phone = "01" + random.Next(1, 10).ToString() + random.Next(10000000, 99999999).ToString(),
                    Email = "deliveryman-" + i + "@gmail.com",
                    Location = "Road-" + random.Next(1, 15) + ", Area-" + random.Next(2, 5),
                    Password = Guid.NewGuid().ToString().Substring(0, 6)
                });
            }

            //Seed for ServiceMan Table
            for (int i = 1; i <= 5; i++)
            {
                int year = random.Next(1950, 2022); // Generate a random year between 1950 and 2021
                int month = random.Next(1, 13); // Generate a random month between 1 and 12
                int daysInMonth = DateTime.DaysInMonth(year, month);
                int day = random.Next(1, daysInMonth + 1);
                int genderValue = random.Next(1, 3);
                context.ServiceMans.AddOrUpdate(new Models.ServiceMan
                {
                    Name = Guid.NewGuid().ToString().Substring(0, 10),
                    Username = "Serviceman-" + i,
                    Dob = new DateTime(year, month, day),
                    Gender = (genderValue == 1) ? "Male" : "Female",
                    Phone = "01" + random.Next(1, 10).ToString() + random.Next(10000000, 99999999).ToString(),
                    Email = "deliveryman-" + i + "@gmail.com",
                    Location = "Road-" + random.Next(1, 15) + ", Area-" + random.Next(2, 5),
                    Password = Guid.NewGuid().ToString().Substring(0, 6)
                });
            }

            //Seed for Product Table
            for (int i = 1; i <= 15; i++)
            {
                string[] categories = { "Seat covers", "Dashboard decoration", "Ambient lighting", "Sun shades", "Car seat organiser" };
                int index = random.Next(categories.Length);
                context.Products.AddOrUpdate(new Models.Product
                {
                    ProductName = Guid.NewGuid().ToString().Substring(0, 6),
                    Description = Guid.NewGuid().ToString().Substring(0, 16),
                    Price = random.Next(250, 30000),
                    Quantity = random.Next(1, 8),
                    Category = categories[index]
                });
            }

            //seed for FuelOrder Table
            for (int i = 1; i <= 10; i++)
            {
                string[] fueltype = { "Patrol", "Disel", "Octan", "Gasoline", "Solar" };
                int index = random.Next(fueltype.Length);
                int status = random.Next(1, 3);
                context.FuelOrders.AddOrUpdate(new Models.FuelOrder
                {
                    FuelType = fueltype[index],
                    FOrderDate = DateTime.Now,
                    DeliveredBy = "Deliveryman-" + random.Next(1, 6),
                    OrderedBy = "username-" + random.Next(1, 6),
                    DeliverAddress = "Road-" + random.Next(1, 15) + ", Area-" + random.Next(2, 5),
                    TotalPrice = random.Next(2000, 3000),
                    Status = status == 1 ? "Pending" : "Deliverd"
                });
            }

            //seed for Order Table
            for (int i = 1; i <= 7; i++)
            {
                int status = random.Next(1, 3);
                context.Orders.AddOrUpdate(new Models.Order
                {
                    OrderDate = DateTime.Now,
                    ServicedBy = "Serviceman-" + random.Next(1, 6),
                    OrderedBy = "username-" + random.Next(1, 6),
                    DeliverAddress = "Road-" + random.Next(1, 15) + ", Area-" + random.Next(2, 5),
                    TotalPrice = random.Next(2000, 3000),
                    Status = status == 1 ? "Pending" : "Deliverd"
                });
            }
        }
    }
}
