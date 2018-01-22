    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Interfaces;
using DataAccessLayer.Repositories;
using DataAccessLayer.Entities;
using BusinessLogicLayer.Infrastructure;
using BusinessLogicLayer.DTO;
using System.ComponentModel.DataAnnotations;

namespace BusinessLogicLayer.Services
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

        public void Registration(object o)
        {
            //checkUsernameR(username);
            //checkPasswordR(password, repeatPassword);
            //checkEmailR(email);


            //UserDTO userDTO = new UserDTO(username, password, repeatPassword, email);

            //var results = new List<ValidationResult>();
            //if (!Validator.TryValidateObject(userDTO, new ValidationContext(userDTO), results, true))
            //{
            //    throw new Infrastructure.ValidationException(results[0].ErrorMessage);
            //}
            //Db.Users.Create(new User(username, password, email));
            //Db.Save();
        }

        //void checkUsernameR(string username)
        //{
        //    if (username == String.Empty)
        //    {
        //        throw new ValidationException("Логін не введений!");
        //    }
        //    else if (Db.Users.Find(u => u.UserName == username).Count() != 0) //Музичук був би мною довольний :)
        //    {
        //        throw new ValidationException("Логін уже використовується!");
        //    }
        //}

        //void checkPasswordR(string password, string repeatPassword)
        //{
        //    if (password == String.Empty)
        //    {
        //        throw new ValidationException("Пароль не введений!");
        //    }
        //    else if (password != repeatPassword)
        //    {
        //        throw new ValidationException("Паролі не збігаються!");
        //    }
        //    else if (password.Length <= 6)
        //    {
        //        throw new ValidationException("Пароль повинен містити не менше 6 символів!");
        //    }
        //}

        //void checkEmailR(string email)
        //{
        //    if (email == String.Empty)
        //    {
        //        throw new ValidationException("Емейл не введений!");
        //    }
        //    else if (!email.Contains("@"))
        //    {
        //        throw new ValidationException("Емейл введено не коректно!");
        //    }
        //}

        public void Authorization(string userName, string password)
        {
            User user = Db.Users.Find(u => u.UserName == userName).FirstOrDefault();
            if (userName == String.Empty)
            {
                throw new Infrastructure.ValidationException("Логін не введений!");
            }
            else if (user == null)
            {
                throw new Infrastructure.ValidationException("Логін введено не правильно!");
            }
            else if (password == String.Empty)
            {
                throw new Infrastructure.ValidationException("Пароль не введений!");
            }
            else if(user.Password != password)
            {
                throw new Infrastructure.ValidationException("Пароль введено не правильно!");
            }
        }
    }
}
