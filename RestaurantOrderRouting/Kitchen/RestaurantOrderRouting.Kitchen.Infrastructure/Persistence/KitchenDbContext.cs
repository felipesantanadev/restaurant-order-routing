using Microsoft.EntityFrameworkCore;
using RestaurantOrderRouting.Kitchen.Application.Interfaces;
using RestaurantOrderRouting.Kitchen.Domain.Common;
using RestaurantOrderRouting.Kitchen.Infrastructure.Persistence.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RestaurantOrderRouting.Kitchen.Infrastructure.Persistence
{
    // Migrations commands:
    // ef migrations add AddKitchenEntity -s ..\RestaurantOrderRouting.Kitchen.API -p . -c RestaurantOrderRouting.Kitchen.Infrastructure.Persistence.KitchenDbContext -o .\Persistence\Migrations
    // ef database update -s ..\RestaurantOrderRouting.Kitchen.API -p .
    public class KitchenDbContext : DbContext, IKitchenDbContext
    {
        public KitchenDbContext(DbContextOptions<KitchenDbContext> options)
        : base(options)
        { }

        public DbSet<Domain.Entities.Kitchen> Kitchens => Set<Domain.Entities.Kitchen>();
        public DbSet<Domain.Entities.Order> Orders => Set<Domain.Entities.Order>();
        public DbSet<Domain.Entities.OrderItem> OrderItems => Set<Domain.Entities.OrderItem>();

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Domain.Entities.Order>().ToTable("Orders", t => t.ExcludeFromMigrations());
            builder.Entity<Domain.Entities.OrderItem>().ToTable("OrderItems", t => t.ExcludeFromMigrations());

            builder.ConfigureKitchenEntity();
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
