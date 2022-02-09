using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RestaurantOrderRouting.Kitchen.Application.Interfaces;
using RestaurantOrderRouting.Kitchen.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantOrderRouting.Kitchen.Infrastructure
{
    public static class ConfigureServices
    {
        public static void AddKitchenInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<KitchenDbContext>(options =>
                options.UseLazyLoadingProxies().UseNpgsql(configuration.GetSection("Postgres:ConnectionString").Value));

            services.AddTransient<IKitchenDbContext, KitchenDbContext>();
        }
    }
}
