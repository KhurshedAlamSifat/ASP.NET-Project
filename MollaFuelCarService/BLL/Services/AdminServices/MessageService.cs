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
    public class MessageService
    {
        public static List<MessageDTO> GetMSG()
        {
            var data = DataAccessFactory.MessageData().Read();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Message, MessageDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<MessageDTO>>(data);
            return mapped;
        }

        public static MessageDTO GetMSG_wth_Id(int id)
        {
            var data = DataAccessFactory.MessageData().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Message, MessageDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<MessageDTO>(data);
            return mapped;
        }


        public static MessageDTO InsertMessage(MessageDTO message) /// for worker
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<MessageDTO, Message>();
               // c.CreateMap<WorkerLocationDTO, Message>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<Product>(message);
            DataAccessFactory.N_ProductData().Create(mapped);
            return message;
        }



    }
}
