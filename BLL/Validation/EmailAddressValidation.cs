using System;
using System.Text.RegularExpressions;

namespace BLL.Validation
{
   public class EmailAddressValidation : Interfaces.IValidation
    {
        const string emailPattern = @"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$";

        public string Property
        {
            get;
            set;
        } = "Емейл";

        public string PropertyValue
        {
            get;
            set;
        } = "";

        public string Validate()
        {
            if (!Regex.IsMatch(PropertyValue, emailPattern, RegexOptions.IgnoreCase))
            {
                return Property + " у неправльному форматі.";
            }
            return String.Empty;
        }
    }
}
