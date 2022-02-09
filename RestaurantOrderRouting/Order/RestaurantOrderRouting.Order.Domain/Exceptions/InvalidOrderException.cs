using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantOrderRouting.Order.Domain.Exceptions
{
    public class InvalidOrderException : Exception
    {
        public InvalidOrderException() : base("An order item can only be added to a valid order.") { }
    }
}
