using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RestaurantOrderRouting.Order.Application.Interfaces;
using RestaurantOrderRouting.Order.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantOrderRouting.Order.Infrastructure
{
    public static class ConfigureServices
    {
        public static void AddOrderInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<OrderDbContext>(options =>
                options.UseLazyLoadingProxies().UseNpgsql(configuration.GetSection("Postgres:ConnectionString").Value));

            services.AddTransient<IOrderDbContext, OrderDbContext>();
        }
    }
}
