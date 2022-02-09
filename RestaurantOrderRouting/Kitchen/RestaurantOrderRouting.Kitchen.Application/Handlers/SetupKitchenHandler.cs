using CSharpFunctionalExtensions;
using MediatR;
using RestaurantOrderRouting.Kitchen.Application.Commands;
using RestaurantOrderRouting.Kitchen.Application.Dtos;
using RestaurantOrderRouting.Kitchen.Application.Interfaces;
using RestaurantOrderRouting.Kitchen.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RestaurantOrderRouting.Kitchen.Application.Handlers
{
    public class SetupKitchenHandler : IRequestHandler<SetupKitchenCommand, Result<SimpleKitchenDto>>
    {
        private readonly IKitchenDbContext _context;
        public SetupKitchenHandler(IKitchenDbContext context)
        {
            _context = context;
        }

        public async Task<Result<SimpleKitchenDto>> Handle(SetupKitchenCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var email = Email.Create(request.ContactEmail);
                if (!email.IsSuccess)
                    return Result.Failure<SimpleKitchenDto>(email.Error);

                var kitchen = new RestaurantOrderRouting.Kitchen.Domain.Entities.Kitchen(request.Name, request.PointOfSaleIdentifier, email.Value);

                await _context.Kitchens.AddAsync(kitchen);

                var result = await _context.SaveChangesAsync(cancellationToken);

                return result > 0
                       ? Result.Success(new SimpleKitchenDto()
                       {
                           Id = kitchen.Id,
                           Name = kitchen.Name,
                           PointOfSaleIndetifier = kitchen.PointOfSaleIdentifier
                       })
                       : Result.Failure<SimpleKitchenDto>("There was an error to setup the kitchen.");
            }
            catch(Exception ex)
            {
                return Result.Failure<SimpleKitchenDto>(ex.InnerException != null ? ex.InnerException.Message : ex.Message);
            }
        }
    }
}
