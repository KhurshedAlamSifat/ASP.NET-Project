using AutoMapper;
using BLL.DTOs.AdminDTOs;
using BLL.DTOs.CustomerDTOs;
using DAL;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.CustomerServices
{
    public class CustomerService
    {
        public static List<CustomerDTO> Get()
        {
            var data = DataAccessFactory.CustomerData().Read();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Customer, CustomerDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<CustomerDTO>>(data);
            return mapped;
        }

        public static CustomerDTO Get(string username) 
        {
            var data = DataAccessFactory.CustomerData().Read(username);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Customer, CustomerDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<CustomerDTO>(data);
            return mapped;
        }

        public static CustomerDTO Insert(Customer customer)
        {
            var data = DataAccessFactory.CustomerData().Create(customer);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Customer, CustomerDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<CustomerDTO>(data);
           // var usermapped = mapper.Map<User>(data);
            //usermapped.UserType = "Customer";

            //DataAccessFactory.UserData().Create(usermapped);
            
            return mapped;
        }
        public static CustomerDTO Update(Customer customer)
        {
            var data = DataAccessFactory.CustomerData().Update(customer);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Customer, CustomerDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<CustomerDTO>(data);
            return mapped;
        }

        public static bool Delete(string username)
        {
            var data=DataAccessFactory.CustomerData().Delete(username);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Customer, CustomerDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<bool>(data);
            return mapped;
        }

        public static CustomerOrderDTO CustomersOrders(string username)
        {
            var data = DataAccessFactory.CustomerData().Read(username);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Customer, CustomerOrderDTO>();
                c.CreateMap<Order, OrderDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<CustomerOrderDTO>(data);
            return mapped;
        }

        public static bool OrderDelete(string username)
        {
            var data = DataAccessFactory.CustomerData().Delete(username);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Customer, CustomerOrderDTO>();
                c.CreateMap<Order, OrderDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<bool>(data);
            return mapped;
        }

    }

}
