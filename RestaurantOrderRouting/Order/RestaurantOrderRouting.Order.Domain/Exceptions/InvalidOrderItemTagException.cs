using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantOrderRouting.Order.Domain.Exceptions
{
    public class InvalidOrderItemTagException : Exception
    {
        public InvalidOrderItemTagException() : base("Invalid order item tag.") { }
    }
}
