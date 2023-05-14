using AutoMapper;
using BLL.DTOs.CustomerDTOs;
using DAL;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.CustomerServices
{
    public class AuthenticateService
    {
        public static TokenDTO Authenticate(string username, string password)
        {

            var res = DataAccessFactory.AuthData().Authenticate(username, password);
            if (res)
            {
                var usertype= DataAccessFactory.UserData().Read(username).UserType;
                var token = new Token();
                token.Username = username;
                token.UserType= usertype;
                token.CreatedAt = DateTime.Now;
                token.TKey= Guid.NewGuid().ToString();
                var ret = DataAccessFactory.TokenData().Create(token);
                if (ret != null)
                {
                    var cfg = new MapperConfiguration(c =>
                    {
                        c.CreateMap<Token, TokenDTO>();
                    });
                    var mapper = new Mapper(cfg);
                    var mapped = mapper.Map<TokenDTO>(ret);
                    return mapped;
                }
            }
            return null;
        }

        public static bool IsTokenValid(string tkey)
        {
            var exToken = DataAccessFactory.TokenData().Read(tkey);
            if(exToken != null && exToken.Expired == null)
            {
                return true;
            }
            return false;
        }
        public static bool Logout(string tkey)
        {
            var exToken = DataAccessFactory.TokenData().Read(tkey);
            exToken.Expired = DateTime.Now;
            var res = DataAccessFactory.TokenData().Update(exToken);
            if(res != null)
            {
                return true;
            }
            return false;
        }

        public static bool IsAdmin(string tkey)
        {
            var extk = DataAccessFactory.TokenData().Read(tkey);
            if (IsTokenValid(tkey) && extk.User.UserType.Equals("Admin"))
            {
                return true;
            }
            return false;
        }
        public static bool IsCustomer(string tkey)
        {
            var extk = DataAccessFactory.TokenData().Read(tkey);
            if (IsTokenValid(tkey) && extk.User.UserType.Equals("Customer"))
            {
                return true;
            }
            return false;
        }
        public static bool IsDeliveryMan(string tkey)
        {
            var extk = DataAccessFactory.TokenData().Read(tkey);
            if (IsTokenValid(tkey) && extk.User.UserType.Equals("DeliveryMan"))
            {
                return true;
            }
            return false;
        }
        public static bool IsServiceMan(string tkey)
        {
            var extk = DataAccessFactory.TokenData().Read(tkey);
            if (IsTokenValid(tkey) && extk.User.UserType.Equals("ServiceMan"))
            {
                return true;
            }
            return false;
        }
    }
}
