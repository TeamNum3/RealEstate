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

        public void Registration(string username, string password, string repeatPassword,  string email)
        {
            CheckRegisterUser.checkUsername(username);
            CheckRegisterUser.checkPassword(password, repeatPassword);
            CheckRegisterUser.checkEmail(email);
            userDAO.RegisterUser(new User(username, password, email));
        }
    }
}

static class CheckRegisterUser
{
    static UserDAO userDAO = new UserDAO();

    public static void checkUsername(string username)
    {
        if (username == String.Empty)
        {
            throw new Exception("Логін не введений!");
        }
        //else if (userDAO.GetUser(username) != null)
        //{
        //    throw new Exception("Логін уже використовується!");
        //}
    }

    public static void checkPassword(string password, string repeatPassword)
    {
        if (password == String.Empty)
        {
            throw new Exception("Пароль не введений!");
        }
        else if (password != repeatPassword)
        {
            throw new Exception("Паролі не збігаються!");
        }
        else if(password.Length <= 6)
        {
            throw new Exception("Пароль повинен містити не менше 6 символів!");
        }
    }

    public static void checkEmail(string email)
    {
        if (email == String.Empty)
        {
            throw new Exception("Емейл не введений!");
        }
        else if (!email.Contains("@"))
        {
            throw new Exception("Емейл введено не коректно!");
        }
    }
}