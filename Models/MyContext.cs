using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.SqlServer;

namespace Models
{
    class MyContext : DbContext
    {
        public MyContext()
            : base("RealEstate")
        {
        }

        public DbSet<User> Users
        {
            get;
            set;
        }
    }
}
