using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos.DeliveryManRepos
{
    internal class DeliverManRepo : Repo, IRepo<DeliveryMan, string, DeliveryMan>
    {
        public DeliveryMan Create(DeliveryMan obj)
        {
            db.DeliveryMans.Add(obj);
            if (db.SaveChanges() > 0) return obj; 

            return null; 
        }

            public bool Delete(string id)
        {
            var ex = Read(id);
            db.DeliveryMans.Remove(ex);
            return db.SaveChanges() > 0;
        }

        public List<DeliveryMan> Read()
        {
            return db.DeliveryMans.ToList();    
        }

        public DeliveryMan Read(string id)
        {
            return db.DeliveryMans.Find(id);    
        }

        public DeliveryMan Update(DeliveryMan obj)
        {
            var ex = Read(obj.Username);
            db.Entry(ex).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            else return null;
        }
    }
}
