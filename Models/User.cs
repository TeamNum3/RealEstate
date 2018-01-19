using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class User
    {
        string UserName
        {
            get;
            set;
        }

        string Password
        {
            get;
            set;
        }

        string Email
        {
            get;
            set;
        }

        public User()
        {
        }

        public User(string username, string password, string email)
        {
            UserName = username;
            Password = password;
            Email = email;
        }
    }
}
