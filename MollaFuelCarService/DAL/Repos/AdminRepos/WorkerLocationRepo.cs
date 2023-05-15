using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos.AdminRepos
{
    internal class WorkerLocationRepo : Repo, IRepo<WorkerLocationcs, double, WorkerLocationcs>
    {
        public WorkerLocationcs Create(WorkerLocationcs obj)
        {
            db.WorkerLocationcs.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;

        }

        public bool Delete(double id)
        {
            throw new NotImplementedException();
        }

        public List<WorkerLocationcs> Read()
        {
            return db.WorkerLocationcs.ToList();
        }

        public WorkerLocationcs Read(double id)
        {
            return db.WorkerLocationcs.Find(id);
        }

        public WorkerLocationcs Update(WorkerLocationcs obj)
        {
            throw new NotImplementedException();
        }
    }
}
