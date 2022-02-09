using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantOrderRouting.Kitchen.Infrastructure.Persistence.Configuration
{
    public static class KitchenConfiguration
    {
        public static ModelBuilder ConfigureKitchenEntity(this ModelBuilder builder)
        {
            builder.Entity<Kitchen.Domain.Entities.Kitchen>().HasKey(x => x.Id);

            builder.Entity<Kitchen.Domain.Entities.Kitchen>().HasIndex(x => x.Name)
                                                             .IsUnique();
            builder.Entity<Kitchen.Domain.Entities.Kitchen>().Property(x => x.Name)
                                                             .HasMaxLength(100)
                                                             .IsRequired();

            builder.Entity<Kitchen.Domain.Entities.Kitchen>().HasIndex(x => x.NormalizedName)
                                                             .IsUnique();
            builder.Entity<Kitchen.Domain.Entities.Kitchen>().Property(x => x.NormalizedName)
                                                             .HasMaxLength(100)
                                                             .IsRequired();

            builder.Entity<Kitchen.Domain.Entities.Kitchen>().HasIndex(x => x.PointOfSaleIdentifier)
                                                             .IsUnique();
            builder.Entity<Kitchen.Domain.Entities.Kitchen>().Property(x => x.PointOfSaleIdentifier)
                                                             .HasMaxLength(150)
                                                             .IsRequired();

            builder.Entity<Kitchen.Domain.Entities.Kitchen>().HasIndex(x => x.ContactEmail)
                                                             .IsUnique();
            builder.Entity<Kitchen.Domain.Entities.Kitchen>().Property(x => x.ContactEmail)
                                                             .HasMaxLength(80)
                                                             .IsRequired();

            builder.Entity<Kitchen.Domain.Entities.Kitchen>().HasMany(x => x.Orders);
            builder.Entity<Kitchen.Domain.Entities.Order>().HasMany(x => x.Items);

            return builder;
        }
    }
}
