using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantOrderRouting.Kitchen.Domain.Entities;
using System.Threading;

namespace RestaurantOrderRouting.Kitchen.Application.Interfaces
{
    public interface IKitchenDbContext
    {
        DbSet<RestaurantOrderRouting.Kitchen.Domain.Entities.Kitchen> Kitchens { get; }
        DbSet<RestaurantOrderRouting.Kitchen.Domain.Entities.Order> Orders { get; }
        DbSet<RestaurantOrderRouting.Kitchen.Domain.Entities.OrderItem> OrderItems { get; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
