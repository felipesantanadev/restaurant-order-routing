using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantOrderRouting.Crosscutting.Enum
{
    public enum OrderItemStatus
    {
        NotPreparingYet = 1,
        Preparing = 2,
        Done = 3,
        Canceled = 4
    }
}
