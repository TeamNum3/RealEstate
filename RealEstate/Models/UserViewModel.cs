using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace RealEstate.Models
{
    public class UserViewModel : IDataErrorInfo
    {
        //[Required(ErrorMessage = "Логін не введений", AllowEmptyStrings = false)]
        //[StringLength(13, MinimumLength = 4, ErrorMessage = "3<Логін <14")]
        public string UserName
        {
            get;
            set;
        }

        //[Required(ErrorMessage = "Пароль не введений")]
        //[StringLength(13, MinimumLength = 4, ErrorMessage = "3<Логін <14")]
        public string Password
        {
            get;
            set;
        }

        public string ConfirmPassword
        {
            get;
            set;
        }

        //[EmailAddress(ErrorMessage = "Не правильний формат емейлу")]
        public string Email
        {
            get;
            set;
        }

        public UserViewModel()
        {
        }

        public UserViewModel(string username, string password, string confirmPassword, string email)
        {
            UserName = username;
            Password = password;
            ConfirmPassword = confirmPassword;
            Email = email;
        }

        public string this[string columnName]
        {
            get
            {

                string errorMessege = String.Empty;
                string emailPattern = @"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$"; //msdn пропонує таке

                //var results = new List<ValidationResult>();
                //if (!Validator.TryValidateObject(this, new ValidationContext(this), results, true))
                //{
                //    error = results[0].ErrorMessage;
                //}

                switch (columnName)
                {
                    case "UserName":
                        if (UserName.Length < 3 || UserName.Length > 13)
                        {
                            errorMessege = "3<Логін <14";
                        }
                        break;
                    case "Email":
                        if (!Regex.IsMatch(Email, emailPattern, RegexOptions.IgnoreCase))
                        {
                            errorMessege = "Не правильний формат емейлу";
                        }
                        break;
                }
                return errorMessege;
            }
        }
        public string Error
        {
            get { throw new NotImplementedException(); }
        }
    }
}
//https://tarundotnet.wordpress.com/2011/03/03/wpf-tutorial-how-to-use-idataerrorinfo-in-wpf/