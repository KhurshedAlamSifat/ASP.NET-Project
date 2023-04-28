using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos.AdminRepos
{
    internal class ServiceManRepo : Repo,IRepo<ServiceMan, string, ServiceMan>
    {
        public ServiceMan Create(ServiceMan obj)
        {
            db.ServiceMans.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;

            
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
            var serviceMan = Read(obj.Password);
            db.Entry(serviceMan).CurrentValues.SetValues(obj);
            return null;
        }
    }
}
