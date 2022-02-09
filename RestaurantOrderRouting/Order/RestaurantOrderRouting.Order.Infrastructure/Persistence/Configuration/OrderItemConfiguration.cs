using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantOrderRouting.Order.Infrastructure.Persistence.Configuration
{
    public static class OrderItemConfiguration
    {
        public static ModelBuilder ConfigureOrderItemEntity(this ModelBuilder builder)
        {
            builder.Entity<Order.Domain.Entities.OrderItem>().HasKey(x => x.Id);

            builder.Entity<Order.Domain.Entities.OrderItem>().Property(x => x.ItemName).HasMaxLength(100).IsRequired();
            builder.Entity<Order.Domain.Entities.OrderItem>().Property(x => x.ItemTag).HasMaxLength(50).IsRequired();
            builder.Entity<Order.Domain.Entities.OrderItem>().Property(x => x.Status).IsRequired();
            
            return builder;
        }
    }
}
