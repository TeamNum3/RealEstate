using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interfaces;
using DAL.Repositories;
using DAL.Entities;
using BLL.Infrastructure;

namespace BLL.Services
{
    public class UserService
    {
        IUnitOfWork Db
        {
            get;
            set;
        }

        public UserService()
        {
            Db = new EFUnitOfWork();
        }

        public void Registration(string username, string password, string repeatPassword, string email)
        {
            checkUsernameR(username);
            checkPasswordR(password, repeatPassword);
            checkEmailR(email);

            Db.Users.Create(new User(username, password, email));
            Db.Save();
        }

        void checkUsernameR(string username)
        {
            if (username == String.Empty)
            {
                throw new ValidationException("Логін не введений!");
            }
            else if (Db.Users.Find(u => u.UserName == username).Count() != 0) //Музичук був би мною довольний :)
            {
                throw new ValidationException("Логін уже використовується!");
            }
        }

        void checkPasswordR(string password, string repeatPassword)
        {
            if (password == String.Empty)
            {
                throw new ValidationException("Пароль не введений!");
            }
            else if (password != repeatPassword)
            {
                throw new ValidationException("Паролі не збігаються!");
            }
            else if (password.Length <= 6)
            {
                throw new ValidationException("Пароль повинен містити не менше 6 символів!");
            }
        }

        void checkEmailR(string email)
        {
            if (email == String.Empty)
            {
                throw new ValidationException("Емейл не введений!");
            }
            else if (!email.Contains("@"))
            {
                throw new ValidationException("Емейл введено не коректно!");
            }
        }
    }
}
