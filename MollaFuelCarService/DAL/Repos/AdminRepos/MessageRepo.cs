using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos.AdminRepos
{
    internal class MessageRepo : Repo, IRepo<Message, int, Message>
    {
        public Message Create(Message obj)
        {

            db.Messages.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Message> Read()
        {
            return db.Messages.ToList();
        }

        public Message Read(int id)
        {
            return db.Messages.Find(id);
        }

        public Message Update(Message obj)
        {
            throw new NotImplementedException();
        }
    }
}
