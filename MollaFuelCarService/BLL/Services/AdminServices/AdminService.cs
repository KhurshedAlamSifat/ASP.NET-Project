using AutoMapper;
using BLL.DTOs.CustomerDTOs;
using DAL.Models;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.DTOs.AdminDTOs;

namespace BLL.Services.AdminServices
{
    public class AdminService
    {
        public static List<AdminDTO> Get()
        {
            var data = DataAccessFactory.N_AdminData().Read();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Admin, AdminDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<AdminDTO>>(data);
            return mapped;
        }

        public static AdminDTO Get(string username)
        {
            var data = DataAccessFactory.N_AdminData().Read(username);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Admin, AdminDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<AdminDTO>(data);
            return mapped;
        }

        public static AdminDTO Insert(AdminDTO admin)
        {

            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<AdminDTO, Admin>();
                c.CreateMap<AdminDTO, User>();
            });
            var mapper = new Mapper(cfg);
            var users = mapper.Map<User>(admin);
            users.UserType = "Admin";
            DataAccessFactory.UserData().Create(users);
            var admins = mapper.Map<Admin>(admin);
            DataAccessFactory.N_AdminData().Create(admins);
            return admin;
        }
        public static AdminDTO Updated(AdminDTO admin)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<AdminDTO, Admin>();
                c.CreateMap<AdminDTO, User>();
            });
            var mapper = new Mapper(cfg);
            var users = mapper.Map<User>(admin);
            users.UserType = "Admin";
            DataAccessFactory.UserData().Update(users);
            var admins = mapper.Map<Admin>(admin);
            DataAccessFactory.N_AdminData().Update(admins);
            return admin;
        }

        public static bool Delete(string username)
        {
            var data = DataAccessFactory.N_AdminData().Delete(username);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Admin, AdminDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<bool>(data);
            return mapped;
        }





        /// product CRUD ///

        public static List<ProductDTO> GetProduct()
        {
            var data = DataAccessFactory.N_ProductData().Read();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Product, ProductDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<ProductDTO>>(data);
            return mapped;
        }

        public static ProductDTO GetProduct(int id)
        {
            var data = DataAccessFactory.N_ProductData().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Product, ProductDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<ProductDTO>(data);
            return mapped;
        }

        public static ProductDTO InsertProduct(Product product)
        {
            var data = DataAccessFactory.N_ProductData().Create(product);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Product, ProductDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<ProductDTO>(data);
            return mapped;
        }
        public static ProductDTO Update(Product product)
        {
            var data = DataAccessFactory.N_ProductData().Update(product);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Product, ProductDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<ProductDTO>(data);
            return mapped;
        }

        public static bool DeleteProduct(int id)
        {
            var data = DataAccessFactory.N_ProductData().Delete(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Product, ProductDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<bool>(data);
            return mapped;
        }

    }
}

