using CSharpFunctionalExtensions;
using MediatR;
using RestaurantOrderRouting.Kitchen.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantOrderRouting.Kitchen.Application.Queries
{
    public class GetSimpleKitchensQuery : IRequest<Result<List<SimpleKitchenDto>>>
    {
    }
}
