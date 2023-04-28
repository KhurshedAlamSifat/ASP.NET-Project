using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos.AdminRepos
{
    internal class AdminRepo : Repo, IRepo<Admin, string, Admin>
    {
        public Admin Create(Admin obj)
        {
            db.Admins.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;

        }

        public bool Delete(string id)
        {
            var ex = Read(id);
            db.Admins.Remove(ex);
            return db.SaveChanges() > 0;

        }

        public List<Admin> Read()
        {
            return db.Admins.ToList();
        }

        public Admin Read(string id)
        {
            return db.Admins.Find(id);
        }

        public Admin Update(Admin obj)
        {
            var admin = Read(obj.Password);
            db.Entry(admin).CurrentValues.SetValues(obj);
            return null;
        }
    }
}