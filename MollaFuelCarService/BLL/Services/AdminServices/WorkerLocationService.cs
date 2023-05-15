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
    public class WorkerLocationService
    {
        public static List<WorkerLocationDTO> GetLocation()
        {
            var data = DataAccessFactory.LocationData().Read();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<WorkerLocationcs, WorkerLocationDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<WorkerLocationDTO>>(data);
            return mapped;
        }

        public static WorkerLocationDTO GetLocation_wth_ID(double location)
        {
            var data = DataAccessFactory.LocationData().Read(location);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<WorkerLocationcs, WorkerLocationDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<WorkerLocationDTO>(data);
            return mapped;
        }

        public static WorkerLocationDTO Insert(WorkerLocationDTO location)
        {

            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<WorkerLocationDTO, WorkerLocationcs>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<WorkerLocationcs>(location);
            DataAccessFactory.LocationData().Create(mapped);
            return location;
        }
    }
}
