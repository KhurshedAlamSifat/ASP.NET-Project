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

        public static CustomerDTO Insert(CustomerDTO customer)
        {
            
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<CustomerDTO, Customer>();
                c.CreateMap<CustomerDTO, User>();
            });
            var mapper = new Mapper(cfg);
            var users = mapper.Map<User>(customer);
            users.UserType = "Customer";
            DataAccessFactory.UserData().Create(users);
            var customers = mapper.Map<Customer>(customer);
            DataAccessFactory.CustomerData().Create(customers);
            return customer;
        }
        public static CustomerDTO Update(CustomerDTO customer)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<CustomerDTO, Customer>();
                c.CreateMap<CustomerDTO, User>();
            });
            var mapper = new Mapper(cfg);
            var users = mapper.Map<User>(customer);
            users.UserType = "Customer";
            DataAccessFactory.UserData().Update(users);
            var customers = mapper.Map<Customer>(customer);
            DataAccessFactory.CustomerData().Update(customers);
            return customer;
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

        public static CustomerFuelOrderDTO CustomersFuelOrders(string username)
        {
            var data = DataAccessFactory.CustomerData().Read(username);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Customer, CustomerOrderDTO>();
                c.CreateMap<FuelOrder, FuelOrderDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<CustomerFuelOrderDTO>(data);
            return mapped;
        }

        public static bool FuelOrderDelete(string username)
        {
            var data = DataAccessFactory.CustomerData().Delete(username);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Customer, CustomerOrderDTO>();
                c.CreateMap<FuelOrder, FuelOrderDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<bool>(data);
            return mapped;
        }
    }

}
