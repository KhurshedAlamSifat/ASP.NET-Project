using AutoMapper;
using DAL.Models;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.DTOs.ServiceManDTOs;
using BLL.DTOs.CustomerDTOs;

namespace BLL.Services.ServiceManServices
{
    public class ServiceManService
    {
        public static List<ServiceManDTO> Get()
    {
        var data = DataAccessFactory.ServiceManData().Read();
        var cfg = new MapperConfiguration(c =>
        {
            c.CreateMap<ServiceMan, ServiceManDTO>();
        });
        var mapper = new Mapper(cfg);
        var mapped = mapper.Map<List<ServiceManDTO>>(data);
        return mapped;
    }

    public static ServiceManDTO Get(string Username)
    {
        var data = DataAccessFactory.ServiceManData().Read(Username);
        var cfg = new MapperConfiguration(c =>
        {
            c.CreateMap<ServiceMan, ServiceManDTO>();
        });
        var mapper = new Mapper(cfg);
        var mapped = mapper.Map<ServiceManDTO>(data);
        return mapped;
    }

    public static ServiceManDTO Insert(ServiceMan ServiceMan)
    {
        var data = DataAccessFactory.ServiceManData().Create(ServiceMan);
        var cfg = new MapperConfiguration(c =>
        {
            c.CreateMap<ServiceMan, ServiceManDTO>();
        });
        var mapper = new Mapper(cfg);
        var mapped = mapper.Map<ServiceManDTO>(data);
        return mapped;
    }
        public static ServiceManDTO Update(ServiceMan ServiceMan)
        {
            var data = DataAccessFactory.ServiceManData().Update(ServiceMan);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<ServiceMan, ServiceManDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<ServiceManDTO>(data);
            return mapped;
        }


        public static bool Delete(string Username)
    {
        var data = DataAccessFactory.ServiceManData().Delete(Username);
        var cfg = new MapperConfiguration(c =>
        {
            c.CreateMap<ServiceMan, ServiceManDTO>();
        });
        var mapper = new Mapper(cfg);
        var mapped = mapper.Map<bool>(data);
        return mapped;
    }
}
}
