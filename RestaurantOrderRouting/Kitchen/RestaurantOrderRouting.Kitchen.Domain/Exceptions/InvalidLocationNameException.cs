using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantOrderRouting.Kitchen.Domain.Exceptions
{
    // This class was created just to point how custom exceptions could be created for Domain
    public class InvalidLocationNameException : Exception
    {
        public InvalidLocationNameException() : base("The provided location name is not valid.") { }
    }
}
