using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RestaurantOrderRouting.Kitchen.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using RestaurantOrderRouting.Kitchen.Application.Commands;
using System.Reflection;

namespace RestaurantOrderRouting.Kitchen.Application
{
    public static class ConfigureServices
    {
        public static void AddKitchenApplication(this IServiceCollection services)
        {
            services.AddMediatR(typeof(SetupKitchenCommand).GetTypeInfo().Assembly);
        }
    }
}
