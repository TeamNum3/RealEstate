using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.SqlServer;
using DAL.Entities;

namespace DAL.EF
{
    public class MyContext : DbContext
    {
        public MyContext()
            : base("RealEstateDB")
        {
        }

        public DbSet<User> Users
        {
            get;
            set;
        }
    }
}
