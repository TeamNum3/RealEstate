using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Validation
{
    public class StringLengthValidation: Interfaces.IValidation
    {
        public string Property
        {
            get;
            set;
        } = "Поле";

        public string PropertyValue
        {
            get;
            set;
        } = "";

        public int MinLength
        {
            get;
            set;
        } = 4;

        public int MaxLength
        {
            get;
            set;
        } = 13;

        public string Validate()
        {
            if (PropertyValue.Length < MinLength || PropertyValue.Length > MaxLength)
            {
                return MinLength + "< " + Property + " <" + MaxLength;
            }
            return String.Empty;
        }
    }
}
