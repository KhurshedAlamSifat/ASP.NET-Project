using DAL.Interfaces;
using DAL.Models;
using DAL.Repos.AdminRepos;
using DAL.Repos.CustomerRepos;
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

        public static IRepo<Admin, string, Admin> N_AdminData() { return new AdminRepo(); }
    }
}
