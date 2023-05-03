using AutoMapper;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.DTOs.ServiceManDTOs;
using DAL;


namespace BLL.Services.ServiceManHistoryServices
{
    public class ServiceManHistoryService
    {
        public static List<ServiceManHistoryDTO> Get()
        {
            var data = DataAccessFactory.ServiceManHistorytData().Read();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<ServiceManHistory, ServiceManHistoryDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<ServiceManHistoryDTO>>(data);
            return mapped;
        }

        public static ServiceManHistoryDTO Get(int Id)
        {
            var data = DataAccessFactory.ServiceManHistorytData().Read(Id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<ServiceManHistory, ServiceManHistoryDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<ServiceManHistoryDTO>(data);
            return mapped;
        }


        public static bool Delete(int Id)
        {
            var data = DataAccessFactory.ServiceManHistorytData().Delete(Id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<ServiceManHistory, ServiceManHistoryDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<bool>(data);
            return mapped;
        }
    }
}
