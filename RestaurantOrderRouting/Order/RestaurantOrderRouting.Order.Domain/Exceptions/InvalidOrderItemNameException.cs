using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantOrderRouting.Order.Domain.Exceptions
{
    public class InvalidOrderItemNameException : Exception
    {
        public InvalidOrderItemNameException() : base("Invalid order item name.") { }
    }
}
