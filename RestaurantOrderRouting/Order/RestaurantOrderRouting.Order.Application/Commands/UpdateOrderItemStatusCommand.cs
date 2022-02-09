using CSharpFunctionalExtensions;
using MediatR;
using Microsoft.AspNetCore.JsonPatch;
using RestaurantOrderRouting.Crosscutting.Enum;
using RestaurantOrderRouting.Order.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantOrderRouting.Order.Application.Commands
{
    public class UpdateOrderItemStatusCommand : IRequest<Result>
    {
        public int OrderId { get; set; }
        public int OrderItemId { get; set; }
        public OrderItemStatus NewStatus { get; set; }
    }
}
