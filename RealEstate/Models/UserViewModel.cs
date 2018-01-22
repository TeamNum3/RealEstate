using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using BLL.Validation;

namespace RealEstate.Models
{
    public class UserViewModel : IDataErrorInfo
    {
        public string UserName
        {
            get;
            set;
        }

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

        //якщо кілька перевірок
        //string Test(params BLL.Interfaces.IValidation[] validations)
        //{
        //    return validations.Where(v => v.Validate() != null).FirstOrDefault().Validate();
        //}

        public string this[string columnName]
        {
            get
            {

                string errorMessege = String.Empty;

                switch (columnName)
                {
                    case "UserName":
                        errorMessege = (new StringLengthValidation() { Property = "Логін", PropertyValue = UserName }).Validate();
                        break;
                    case "Email":
                        errorMessege = (new EmailAddressValidation() { PropertyValue = Email }).Validate(); ;
                        break;
                    case "Password":
                        errorMessege = (new StringLengthValidation() { Property = "Пароль", PropertyValue = Password }).Validate();
                        break;
                    case "ConfirmPassword":
                        errorMessege = (new CompareValidation() { Properties = "Паролі", FirstPropertyValue = Password, SecondPropertyValue = ConfirmPassword }).Validate();
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