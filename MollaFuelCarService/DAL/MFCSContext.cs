using DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MFCSContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<FuelOrder> FuelOrders { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductOrder> ProductOrders { get; set; }
        public DbSet<DeliveryMan> DeliveryMans { get; set; }
        public DbSet<ServiceMan> ServiceMans { get; set; }
        public DbSet<Admin> Admins { get; set; }
    }
}
