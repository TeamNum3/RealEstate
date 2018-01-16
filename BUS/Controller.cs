using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAO;

namespace BUS
{
    public class Controller
    {
        public void Login(string username, string password)
        {
            if (username == string.Empty || password == string.Empty)
            {
                throw new Exception("Пароль або Логін не введені!");
            }
        }
    }
}
