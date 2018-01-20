using System;
using DAL.EF;
using DAL.Interfaces;
using DAL.Entities;

namespace DAL.Repositories
{
    public class EFUnitOfWork : IUnitOfWork
    {
        MyContext db;
        UserRepository userRepository;

        public EFUnitOfWork()
        {
            db = new MyContext();
        }

        public IRepository<User> Users
        {
            get
            {
                if (userRepository == null)
                    userRepository = new UserRepository(db);
                return userRepository;
            }
        }

        public void Save()
        {
            db.SaveChanges();
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
