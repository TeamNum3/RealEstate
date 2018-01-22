using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Interfaces
{
    interface ICompareValidation
    {
        string Properties { get; set; }

        string FirstPropertyValue { get; set; }

        string SecondPropertyValue { get; set; }

        string Validate();
    }
}
