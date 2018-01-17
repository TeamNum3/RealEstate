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
        UserDAO userDAO;

        public Controller()
        {
            userDAO = new UserDAO();
        }

        public void Login(string username, string password)
        {
            if (username == string.Empty || password == string.Empty)
            {
                throw new Exception("Пароль або Логін не введені!");
            }
            else
            {
                User user = userDAO.GetUser(username);
                //перевірка паролю
            }
        }
    }
}
