using Microsoft.EntityFrameworkCore;
using RestaurantOrderRouting.Order.Application.Interfaces;
using RestaurantOrderRouting.Order.Domain.Common;
using RestaurantOrderRouting.Order.Domain.Entities;
using RestaurantOrderRouting.Order.Infrastructure.Persistence.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RestaurantOrderRouting.Order.Infrastructure.Persistence
{
    // Migrations commands:
    // ef migrations add AddOrderEntity -s ..\RestaurantOrderRouting.Order.API -p . -c RestaurantOrderRouting.Order.Infrastructure.Persistence.OrderDbContext -o .\Persistence\Migrations
    // ef database update -s ..\RestaurantOrderRouting.Order.API -p .
    public class OrderDbContext : DbContext, IOrderDbContext
    {
        public OrderDbContext(DbContextOptions<OrderDbContext> options)
        : base(options)
        { }

        public DbSet<Domain.Entities.Order> Orders => Set<Domain.Entities.Order>();
        public DbSet<Domain.Entities.OrderItem> OrderItems => Set<Domain.Entities.OrderItem>();

        protected override void OnModelCreating(ModelBuilder builder)
        {
            // Exclude the Kitchen entity from migration, because the Kitchen Bounded Context
            // already deals with that
            builder.Entity<Kitchen>().ToTable("Kitchens", t => t.ExcludeFromMigrations());

            builder.ConfigureOrderEntity();
            builder.ConfigureOrderItemEntity();
        }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            foreach (var entry in ChangeTracker.Entries<Entity>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.Created = DateTime.Now;
                        break;

                    case EntityState.Modified:
                        entry.Entity.LastModified = DateTime.Now;
                        break;
                }
            }

            return await base.SaveChangesAsync(cancellationToken);
        }
    }
}
