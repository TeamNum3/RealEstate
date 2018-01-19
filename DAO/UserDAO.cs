using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DAO
{
    public class UserDAO
    {
        MyContext db;

        public UserDAO()
        {
            db = new MyContext();
        }

        public User GetUser(string username)
        {
            return new User();//заглушкаs
        }

        public void RegisterUser(User user)
        {
            db.Users.Add(user);
        }
    }
}
