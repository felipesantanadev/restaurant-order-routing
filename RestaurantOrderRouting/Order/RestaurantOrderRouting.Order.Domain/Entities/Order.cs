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
    public class Order : Entity
    {
        public int KitchenId { get; private set; }
        public virtual Kitchen Kitchen { get; private set; }

        public OrderStatus Status { get; private set; } = OrderStatus.Received;
        public virtual IList<OrderItem> Items { get; private set; } = new List<OrderItem>();

        public Order(int kitchenId)
        {
            if (kitchenId <= 0)
                throw new InvalidKitchenException();

            KitchenId = kitchenId;
        }

        public void CreateNewItem(KitchenAreas kitchenArea, string itemName, string itemTag)
        {
            var orderItem = new OrderItem(this, kitchenArea, itemName, itemTag);
            Items.Add(orderItem);
        }

        public void ChangeItemStatus(int orderItemId, OrderItemStatus newStatus)
        {
            var item = Items.Where(x => x.Id == orderItemId).FirstOrDefault();
            item.UpdateStatus(newStatus);
        }
    }
}
