using DAL.Interfaces;
using DAL.Models;
using DAL.Repos.AdminRepos;
using DAL.Repos.CustomerRepos;
using DAL.Repos.ServiceManOrderlistRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory
    {
        public static IRepo<Customer, string, Customer> CustomerData()
        {
            return new CustomerRepo();
        }

        public static IAuth<bool> AuthData()
        {
            return new CustomerRepo();
        }

        public static IRepo<Token, string, Token> TokenData()
        {
            return new TokenRepo();
        }

        public static IRepo<Order, int, Order> OrderData()
        {
            return new OrderRepo();
        }
        public static IRepo<Admin, int, Admin> N_AdminData() { return new AdminRepo(); }

        public static IRepo<Product, int, Product> N_ProductData() { return new ProductRepo(); }

        public static IRepo<DeliveryMan, string, DeliveryMan> N_DeliveryManData() { return new DeliveryManRepo(); }

        public static IRepo<ServiceMan, string, ServiceMan> ServiceManData()
        {
            return new ServiceManRepo();
        }
        public static IRepo<ServiceManOrderlist, int, ServiceManOrderlist> ServiceManOrderlistData()
        {
            return new ServiceManOrderlistRepo();
        }
    }
}