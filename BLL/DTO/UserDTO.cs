using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace BLL.DTO
{
    public class UserDTO
    {
        [Required(ErrorMessage = "Логін не введений", AllowEmptyStrings = false)]
        public string UserName
        {
            get;
            set;
        }

        [Required(ErrorMessage = "Пароль не введений")]
        public string Password
        {
            get;
            set;
        }

        [Compare("Password", ErrorMessage = "Паролі не співпадають")]
        public string ConfirmPassword
        {
            get;
            set;
        }

        [Required(ErrorMessage = "Емейл не введений")]
        [EmailAddress(ErrorMessage = "Не правильний формат емейлу")]
        public string Email
        {
            get;
            set;
        }

        public UserDTO()
        {
        }

        public UserDTO(string username, string password, string confirmPassword, string email)
        {
            UserName = username;
            Password = password;
            ConfirmPassword = confirmPassword;
            Email = email;
        }
    }
}
