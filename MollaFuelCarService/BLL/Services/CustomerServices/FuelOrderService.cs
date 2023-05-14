using AutoMapper;
using BLL.DTOs.CustomerDTOs;
using DAL.Models;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.CustomerServices
{
    public class FuelOrderService
    {
        public static List<FuelOrderDTO> Get()
        {
            var data = DataAccessFactory.FuelOrderData().Read();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<FuelOrder, FuelOrderDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<FuelOrderDTO>>(data);
            return mapped;
        }
        public static FuelOrderDTO Get(int id)
        {
            var data = DataAccessFactory.FuelOrderData().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<FuelOrder, FuelOrderDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<FuelOrderDTO>(data);
            return mapped;
        }

        public static FuelOrderDTO Insert(FuelOrderDTO fuelorder)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<FuelOrderDTO, FuelOrder>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<FuelOrder>(fuelorder);
            DataAccessFactory.FuelOrderData().Create(mapped);
            return fuelorder;
        }
        public static FuelOrderDTO Update(FuelOrderDTO fuelorder)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<FuelOrderDTO, FuelOrder>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<FuelOrder>(fuelorder);
            DataAccessFactory.FuelOrderData().Create(mapped);
            return fuelorder;
        }

        public static bool Delete(int id)
        {
            var data = DataAccessFactory.FuelOrderData().Delete(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<FuelOrder, FuelOrderDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<bool>(data);
            return mapped;
        }

        public static FuelOrderDTO GetProduct(int id)
        {
            var data = DataAccessFactory.FuelOrderData().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<FuelOrder, FuelOrderDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<FuelOrderDTO>(data);
            return mapped;
        }
    }
}
