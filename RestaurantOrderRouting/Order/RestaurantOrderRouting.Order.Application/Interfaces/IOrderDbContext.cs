using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantOrderRouting.Order.Domain.Entities;
using System.Threading;

namespace RestaurantOrderRouting.Order.Application.Interfaces
{
    public interface IOrderDbContext
    {
        DbSet<RestaurantOrderRouting.Order.Domain.Entities.Order> Orders { get; }
        DbSet<RestaurantOrderRouting.Order.Domain.Entities.OrderItem> OrderItems { get; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
