using AutoMapper;
using BLL.DTOs.AdminDTOs;
using DAL.Models;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.AdminServices
{
   public class ProductService
    {
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

        public static ProductDTO InsertProduct(ProductDTO product)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<ProductDTO, Product>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<Product>(product);
            DataAccessFactory.N_ProductData().Create(mapped);
            return product;
        }
        public static ProductDTO Update(ProductDTO product)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<ProductDTO, Product>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<Product>(product);
            DataAccessFactory.N_ProductData().Update(mapped);
            return product;
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
