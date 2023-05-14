using AutoMapper;
using AutoMapper.QueryableExtensions.Impl;
using BLL.DTOs.DeliveryManDTOs;
using DAL;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.DeliveryManServices
{
    public class DeliveryManServices
    {
        public static List<DeliveryManDTO> Get()
        {
            var data =DataAccessFactory.N_DeliveryManData().Read();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<DeliveryMan,DeliveryManDTO>();  
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<DeliveryManDTO>>(data);
            return mapped;
            
        }

        public static DeliveryManDTO Get(string username)
        {
            var data = DataAccessFactory.N_DeliveryManData().Read(username);
            var cfg = new MapperConfiguration(c => {
             c.CreateMap<DeliveryMan,DeliveryManDTO>();
            }); 
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<DeliveryManDTO>(data);
            return mapped;
        }

        //-------------------------
        public static DeliveryManDTO Insert(DeliveryManDTO deliveryman)
        {

            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<DeliveryManDTO, DeliveryMan>();
                c.CreateMap<DeliveryManDTO, User>();
            });
            var mapper = new Mapper(cfg);
            var users = mapper.Map<User>(deliveryman);
            users.UserType = "DeliveryMan";
            DataAccessFactory.UserData().Create(users);
            var delivers = mapper.Map<DeliveryMan>(deliveryman);
            DataAccessFactory.N_DeliveryManData().Create(delivers);
            return deliveryman;
        }
        //-----------------------
        public static DeliveryManDTO Update(DeliveryManDTO deliveryman)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<DeliveryManDTO, DeliveryMan>();
                c.CreateMap<DeliveryManDTO, User>();
            });
            var mapper = new Mapper(cfg);
            var users = mapper.Map<User>(deliveryman);
            users.UserType = "DeliveryMan";
            DataAccessFactory.UserData().Update(users);
            var delivers = mapper.Map<DeliveryMan>(deliveryman);
            DataAccessFactory.N_DeliveryManData().Update(delivers);
            return deliveryman;
        }
        //----------------------
        public static bool Delete(string username)
        {
            var data = DataAccessFactory.N_DeliveryManData().Delete(username);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<DeliveryMan, DeliveryManDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<bool>(data);
            return mapped;
        }
    }
}
