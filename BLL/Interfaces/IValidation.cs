using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Interfaces
{
    public interface IValidation
    {
        string Property { get; set; }

        string PropertyValue { get; set; }

        string Validate();
    }
}
