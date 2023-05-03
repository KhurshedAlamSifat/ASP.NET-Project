using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;

namespace DAL.Repos.ServiceManHistoryRepo
{
    internal class ServiceManHistoryRepo : Repo, IRepo<ServiceManHistory, int, ServiceManHistory>
    {
        public ServiceManHistory Create(ServiceManHistory obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int Id)
        {
            var ex = Read(Id);
            db.ServiceManHistorys.Remove(ex);
            return db.SaveChanges() > 0;
        }

        public List<ServiceManHistory> Read()
        {
            return db.ServiceManHistorys.ToList();
        }

        public ServiceManHistory Read(int Id)
        {
            return db.ServiceManHistorys.Find(Id);
        }

        public ServiceManHistory Update(ServiceManHistory obj)
        {
            throw new NotImplementedException();
        }

    }
}
