using RestaurantOrderRouting.Crosscutting.Enum;
using RestaurantOrderRouting.Order.Domain.Common;
using RestaurantOrderRouting.Order.Domain.Enum;
using RestaurantOrderRouting.Order.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantOrderRouting.Order.Domain.Entities
{
    public class OrderItem : Entity
    {
        public int OrderId { get; private set; }
        public virtual Order Order { get; private set; }
        public KitchenAreas KitchenArea { get; private set; }
        public string ItemName { get; private set; }
        public string ItemTag { get; private set; }
        public OrderItemStatus Status { get; private set; } = OrderItemStatus.NotPreparingYet;

        protected OrderItem() { }

        public OrderItem(Order order, KitchenAreas kitchenArea, string itemName, string itemTag)
        {
            if (order == null)
                throw new InvalidOrderException();

            if (string.IsNullOrEmpty(itemName))
                throw new InvalidOrderItemNameException();

            if (string.IsNullOrEmpty(itemTag))
                throw new InvalidOrderItemTagException();

            Order = order;
            KitchenArea = kitchenArea;
            ItemName = itemName;
            ItemTag = itemTag;
        }

        public void UpdateStatus(OrderItemStatus newStatus) => Status = newStatus;
    }
}
