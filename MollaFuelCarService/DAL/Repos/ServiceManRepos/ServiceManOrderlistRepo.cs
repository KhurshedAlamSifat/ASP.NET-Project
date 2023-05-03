using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Repos.ServiceManRepo;

namespace DAL.Repos.ServiceManOrderlistRepo
{
    internal class ServiceManOrderlistRepo : Repo, IRepo<ServiceManOrderlist, int, ServiceManOrderlist>
    {
        public ServiceManOrderlist Create(ServiceManOrderlist obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int OrderId)
        {
            var ex = Read(OrderId);
            db.ServiceManOrderlists.Remove(ex);
            return db.SaveChanges() > 0;
        }

        public List<ServiceManOrderlist> Read()
        {
            return db.ServiceManOrderlists.ToList();
        }

        public ServiceManOrderlist Read(int OrderId)
        {
            return db.ServiceManOrderlists.Find(OrderId);
        }

        public ServiceManOrderlist Update(ServiceManOrderlist obj)
        {
            throw new NotImplementedException();
        }

    }
}
