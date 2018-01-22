using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Validation
{
    public class CompareValidation: Interfaces.ICompareValidation
    {
        public string Properties
        {
            get;
            set;
        } = "Поля";

        public string FirstPropertyValue
        {
            get;
            set;
        } = "";

        public string SecondPropertyValue
        {
            get;
            set;
        } = "";

        public string Validate()
        {
            if (FirstPropertyValue != SecondPropertyValue)
            {
                return Properties + " не співпадають.";
            }
            return String.Empty;
        }
    }
}
