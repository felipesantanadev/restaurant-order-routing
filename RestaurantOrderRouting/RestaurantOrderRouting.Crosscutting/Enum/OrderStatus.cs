using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantOrderRouting.Order.Domain.Enum
{
    public enum OrderStatus
    {
        Received = 1,
        Preparing = 2,
        Done = 3,
        DoneWithRestrictions = 4,
        Canceled = 5
    }
}
