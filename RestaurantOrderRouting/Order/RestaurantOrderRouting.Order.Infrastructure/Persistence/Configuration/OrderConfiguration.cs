using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantOrderRouting.Order.Infrastructure.Persistence.Configuration
{
    public static class OrderConfiguration
    {
        public static ModelBuilder ConfigureOrderEntity(this ModelBuilder builder)
        {
            builder.Entity<Order.Domain.Entities.Order>().HasKey(x => x.Id);

            builder.Entity<Order.Domain.Entities.Order>().Property(x => x.KitchenId).IsRequired();
            builder.Entity<Order.Domain.Entities.Order>().Property(x => x.Status).IsRequired();

            // Configuring relationships
            builder.Entity<Order.Domain.Entities.Order>().HasMany(x => x.Items).WithOne(x => x.Order);
            builder.Entity<Order.Domain.Entities.Order>().HasOne(x => x.Kitchen);

            return builder;
        }
    }
}
