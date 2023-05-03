using AutoMapper;
using BLL.DTOs.ServiceManDTOs;
using DAL;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.ServiceManServices
{
    public class ServiceManOrderlistService
    {
        public static List<ServiceManOrderlistDTO> Get()
        {
            var data = DataAccessFactory.ServiceManOrderlistData().Read();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<ServiceManOrderlist, ServiceManOrderlistDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<ServiceManOrderlistDTO>>(data);
            return mapped;
        }

        public static ServiceManOrderlistDTO Get(int OrderId)
        {
            var data = DataAccessFactory.ServiceManOrderlistData().Read(OrderId);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<ServiceManOrderlist, ServiceManOrderlistDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<ServiceManOrderlistDTO>(data);
            return mapped;
        }


        public static bool Delete(int OrderId)
        {
            var data = DataAccessFactory.ServiceManOrderlistData().Delete(OrderId);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<ServiceManOrderlist, ServiceManOrderlistDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<bool>(data);
            return mapped;
        }
    }
}
