using CSharpFunctionalExtensions;
using MediatR;
using RestaurantOrderRouting.Kitchen.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantOrderRouting.Kitchen.Application.Commands
{
    public class SetupKitchenCommand : IRequest<Result<SimpleKitchenDto>>
    {
        public string Name { get; set; }
        public string PointOfSaleIdentifier { get; set; }
        public string ContactEmail { get; set; }
    }
}
