using RestaurantOrderRouting.Crosscutting.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantOrderRouting.Kitchen.Application.Dtos
{
    public class OrderItemDto
    {
        public int OrderId { get; set; }
        public int OrderItemId { get; set; }
        public string KitchenAreaName { get; set; }
        public string ItemName { get; set; }
        public string ItemTag { get; set; }
        public OrderItemStatus Status { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
