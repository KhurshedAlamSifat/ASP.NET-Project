using AutoMapper;
using DAL.Models;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.DTOs.ServiceManDTOs;

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

        public static ServiceManDTO Get(string username)
        {
            var data = DataAccessFactory.ServiceManData().Read(username);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<ServiceMan, ServiceManDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<ServiceManDTO>(data);
            return mapped;
        }

        public static ServiceManDTO Insert(ServiceManDTO serviceman)
        {

            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<ServiceManDTO, ServiceMan>();
                c.CreateMap<ServiceManDTO, User>();
            });
            var mapper = new Mapper(cfg);
            var users = mapper.Map<User>(serviceman);
            users.UserType = "ServiceMan";
            DataAccessFactory.UserData().Create(users);
            var servicemans = mapper.Map<ServiceMan>(serviceman);
            DataAccessFactory.ServiceManData().Create(servicemans);
            return serviceman;
        }
        public static ServiceManDTO Update(ServiceMan serviceman)
        {
            var data = DataAccessFactory.ServiceManData().Update(serviceman);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<ServiceMan, ServiceManDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<ServiceManDTO>(data);
            return mapped;
        }

        public static bool Delete(string username)
        {
            var data = DataAccessFactory.ServiceManData().Delete(username);
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
