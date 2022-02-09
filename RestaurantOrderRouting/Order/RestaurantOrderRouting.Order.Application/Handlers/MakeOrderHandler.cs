using AutoMapper;
using CSharpFunctionalExtensions;
using MediatR;
using RestaurantOrderRouting.Order.Application.Commands;
using RestaurantOrderRouting.Order.Application.Dtos;
using RestaurantOrderRouting.Order.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RestaurantOrderRouting.Order.Application.Handlers
{
    public class MakeOrderHandler : IRequestHandler<MakeOrderCommand, Result<SimpleOrderDto>>
    {
        private readonly IOrderDbContext _context;
        private readonly IMapper _mapper;
        public MakeOrderHandler(IOrderDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<Result<SimpleOrderDto>> Handle(MakeOrderCommand request, CancellationToken cancellationToken)
        {
            try
            {
                // Validations
                if (request.OrderItems.Count == 0)
                    return Result.Failure<SimpleOrderDto>("Empty orders are not accepted.");

                // Creating entities
                var order = new Domain.Entities.Order(request.KitchenId);
                request.OrderItems.ForEach(x => order.CreateNewItem(x.KitchenArea, x.ItemName, x.ItemTag));

                _context.Orders.Add(order);
                var result = await _context.SaveChangesAsync(cancellationToken);

                return result > 0
                    ? Result.Success(new SimpleOrderDto() { OrderId = order.Id })
                    : Result.Failure<SimpleOrderDto>("There was an error to place the order.");
            }
            catch(Exception ex)
            {
                return Result.Failure<SimpleOrderDto>(ex.Message);
            }
        }
    }
}
