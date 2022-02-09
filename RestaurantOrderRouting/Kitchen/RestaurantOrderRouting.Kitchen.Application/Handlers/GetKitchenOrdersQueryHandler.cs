using CSharpFunctionalExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using RestaurantOrderRouting.Kitchen.Application.Dtos;
using RestaurantOrderRouting.Kitchen.Application.Interfaces;
using RestaurantOrderRouting.Kitchen.Application.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RestaurantOrderRouting.Kitchen.Application.Handlers
{
    public class GetKitchenOrdersQueryHandler : IRequestHandler<GetKitchenOrdersQuery, Result<List<OrderDto>>>
    {
        private readonly IKitchenDbContext _context;
        public GetKitchenOrdersQueryHandler(IKitchenDbContext context)
        {
            _context = context;
        }

        public async Task<Result<List<OrderDto>>> Handle(GetKitchenOrdersQuery request, CancellationToken cancellationToken)
        {
            try
            {
                // This could be mapped with AutoMapper
                // This is only to show how to manage the Entity queries
                var orders = await _context.Kitchens.Where(x => x.Id == request.KitchenId)
                                              .SelectMany(x => x.Orders)
                                              .Select(x => new OrderDto()
                                              {
                                                  KitchenId = x.KitchenId,
                                                  CreationDate = x.Created,
                                                  StatusName = x.Status.ToString(),
                                                  OrderItems = x.Items.Select(y => new OrderItemDto()
                                                  {
                                                      ItemName = y.ItemName,
                                                      ItemTag = y.ItemTag,
                                                      KitchenAreaName = y.KitchenArea.ToString(),
                                                      CreationDate = y.Created,
                                                      OrderItemId = y.Id,
                                                      OrderId = y.OrderId,
                                                      Status = y.Status
                                                  })
                                              }).ToListAsync();

                return Result.Success(orders);
            }
            catch(Exception ex)
            {
                return Result.Failure<List<OrderDto>>(ex.Message);
            }
        }
    }
}
