using CSharpFunctionalExtensions;
using MediatR;
using RestaurantOrderRouting.Order.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantOrderRouting.Order.Application.Commands
{
    public class MakeOrderCommand : IRequest<Result<SimpleOrderDto>>
    {
        public int KitchenId { get; set; }
        public List<OrderItemDto> OrderItems { get; set; } = new List<OrderItemDto>();
    }
}
