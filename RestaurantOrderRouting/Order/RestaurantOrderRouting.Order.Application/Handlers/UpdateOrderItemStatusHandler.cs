using CSharpFunctionalExtensions;
using MediatR;
using RestaurantOrderRouting.Order.Application.Commands;
using RestaurantOrderRouting.Order.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RestaurantOrderRouting.Order.Application.Handlers
{
    public class UpdateOrderItemStatusHandler : IRequestHandler<UpdateOrderItemStatusCommand, Result>
    {
        private readonly IOrderDbContext _context;
        public UpdateOrderItemStatusHandler(IOrderDbContext context)
        {
            _context = context;
        }

        public async Task<Result> Handle(UpdateOrderItemStatusCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var order = await _context.Orders.FindAsync(request.OrderId);
                order.ChangeItemStatus(request.OrderItemId, request.NewStatus);

                var result = await _context.SaveChangesAsync(cancellationToken);

                return result > 0
                    ? Result.Success()
                    : Result.Failure("The order item status was not changed.");
            }
            catch(Exception ex)
            {
                return Result.Failure(ex.Message);
            }
        }
    }
}
