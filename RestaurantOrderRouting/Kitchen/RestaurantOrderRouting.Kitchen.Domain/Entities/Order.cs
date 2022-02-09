using RestaurantOrderRouting.Kitchen.Domain.Common;
using RestaurantOrderRouting.Order.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantOrderRouting.Kitchen.Domain.Entities
{
    /// <summary>
    /// This entity is only used by queries
    /// Nobody can create a new order inside the Kitchen's bounded countext
    /// </summary>
    public class Order : Entity
    {
        public int KitchenId { get; private set; }
        public virtual Kitchen Kitchen { get; set; }
        public OrderStatus Status { get; private set; }
        public virtual IList<OrderItem> Items { get; private set; }

        protected Order() { }
    }
}
