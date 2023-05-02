using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos.CustomerRepos
{
    internal class OrderRepo : Repo, IRepo<Order, int, Order>
    {
        public Order Create(Order obj)
        {
            db.Orders.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            else return null;
        }

        public bool Delete(int id)
        {
            var ex = Read(id);
            db.Orders.Remove(ex);
            return db.SaveChanges() > 0;
        }

        public List<Order> Read()
        {
            return db.Orders.ToList();
        }

        public Order Read(int id)
        {
            return db.Orders.Find(id);
        }

        public Order Update(Order obj)
        {
            var ex = Read(obj.OrderId);
            db.Entry(ex).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            else return null;
        }
    }
}
