using RestaurantOrderRouting.Crosscutting.Enum;
using RestaurantOrderRouting.Order.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantOrderRouting.Order.Application.Dtos
{
    public class OrderItemDto
    {
        public string ItemName { get; set; }
        public string ItemTag { get; set; }
        public KitchenAreas KitchenArea { get; set; }
    }
}
