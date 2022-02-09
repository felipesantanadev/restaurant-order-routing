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
    public class GetSimpleKitchensQueryHandler : IRequestHandler<GetSimpleKitchensQuery, Result<List<SimpleKitchenDto>>>
    {
        private readonly IKitchenDbContext _context;
        public GetSimpleKitchensQueryHandler(IKitchenDbContext context)
        {
            _context = context;
        }

        public async Task<Result<List<SimpleKitchenDto>>> Handle(GetSimpleKitchensQuery request, CancellationToken cancellationToken)
        {
            try
            {
                var kitchens = await _context.Kitchens.Select(x => new SimpleKitchenDto()
                {
                    Id = x.Id,
                    Name = x.Name,
                    PointOfSaleIndetifier = x.PointOfSaleIdentifier
                }).OrderBy(x => x.Name).ToListAsync();

                return Result.Success(kitchens);
            }
            catch(Exception ex)
            {
                return Result.Failure<List<SimpleKitchenDto>>(ex.Message);
            }
        }
    }
}
