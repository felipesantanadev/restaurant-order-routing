using RestaurantOrderRouting.Crosscutting.Enum;
using RestaurantOrderRouting.Kitchen.Domain.Common;
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
    public class OrderItem : Entity
    {
        public int OrderId { get; private set; }
        public virtual Order Order { get; set; }
        public KitchenAreas KitchenArea { get; private set; }
        public string ItemName { get; private set; }
        public string ItemTag { get; private set; }
        public OrderItemStatus Status { get; private set; }

        protected OrderItem() { }
    }
}
