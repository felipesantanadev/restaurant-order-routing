using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantOrderRouting.Kitchen.Application.Dtos
{
    public class SimpleKitchenDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PointOfSaleIndetifier { get; set; }
    }
}
