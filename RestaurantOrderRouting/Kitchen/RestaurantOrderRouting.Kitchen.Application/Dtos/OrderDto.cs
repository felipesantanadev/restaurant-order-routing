using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantOrderRouting.Kitchen.Application.Dtos
{
    public class OrderDto
    {
        public int KitchenId { get; set; }
        public string StatusName { get; set; }
        public DateTime CreationDate { get; set; }
        public IEnumerable<OrderItemDto> OrderItems { get; set; }
    }
}
