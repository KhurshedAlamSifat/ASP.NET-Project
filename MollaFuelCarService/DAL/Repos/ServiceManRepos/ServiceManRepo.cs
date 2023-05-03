using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos.ServiceManRepo
{
    internal class ServiceManRepo : Repo, IRepo<ServiceMan, string, ServiceMan>, IAuth<bool>
    {
        public bool Authenticate(string username, string password)
        {
            var data = db.Customers.FirstOrDefault(u => u.Username.Equals(username) &&
            u.Password.Equals(password));
            if (data != null) return true;
            return false;
        }
        public ServiceMan Create(ServiceMan obj)
        {
            db.ServiceMans.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            else return null;
        }

        public bool Delete(string id)
        {
            var ex = Read(id);
            db.ServiceMans.Remove(ex);
            return db.SaveChanges() > 0;
        }

        public List<ServiceMan> Read()
        {
            return db.ServiceMans.ToList();
        }

        public ServiceMan Read(string id)
        {
            return db.ServiceMans.Find(id);
        }

        public ServiceMan Update(ServiceMan obj)
        {
            var ex = Read(obj.Username);
            db.Entry(ex).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            else return null;
        }

    }
}



