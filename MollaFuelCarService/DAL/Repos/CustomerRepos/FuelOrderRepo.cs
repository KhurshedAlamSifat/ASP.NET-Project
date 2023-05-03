using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos.CustomerRepos
{
    internal class FuelOrderRepo : Repo, IRepo<FuelOrder, int, FuelOrder>
    {
        public FuelOrder Create(FuelOrder obj)
        {
            db.FuelOrders.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            else return null;
        }

        public bool Delete(int id)
        {
            var ex = Read(id);
            db.FuelOrders.Remove(ex);
            return db.SaveChanges() > 0;
        }

        public List<FuelOrder> Read()
        {
            return db.FuelOrders.ToList();
        }

        public FuelOrder Read(int id)
        {
            return db.FuelOrders.Find(id);
        }

        public FuelOrder Update(FuelOrder obj)
        {
            var ex = Read(obj.Id);
            db.Entry(ex).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            else return null;
        }
    }
}
