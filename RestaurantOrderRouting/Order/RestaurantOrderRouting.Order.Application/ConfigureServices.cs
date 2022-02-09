using MediatR;
using Microsoft.Extensions.DependencyInjection;
using RestaurantOrderRouting.Order.Application.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace RestaurantOrderRouting.Order.Application
{
    public static class ConfigureServices
    {
        public static void AddOrderApplication(this IServiceCollection services)
        {
            services.AddMediatR(typeof(MakeOrderCommand).GetTypeInfo().Assembly);
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
        }
    }
}
