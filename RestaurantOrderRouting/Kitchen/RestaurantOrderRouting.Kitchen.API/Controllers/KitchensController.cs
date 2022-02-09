using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestaurantOrderRouting.Kitchen.Application.Commands;
using RestaurantOrderRouting.Kitchen.Application.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantOrderRouting.Kitchen.API.Controllers
{
    [Route("api/kitchens")]
    [ApiController]
    public class KitchensController : CustomController
    {
        public KitchensController(IMediator mediator) : base(mediator) { }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] SetupKitchenCommand command)
        {
            var result = await CommandAsync(command);
            return result.IsSuccess ? Ok(result.Value) : Error(result.Error);
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] GetSimpleKitchensQuery query)
        {
            var result = await QueryAsync(query);
            return result.IsSuccess ? Ok(result.Value) : Error(result.Error);
        }

        [HttpGet("{KitchenId}/orders")]
        public async Task<IActionResult> GetKitchenOrders([FromRoute] GetKitchenOrdersQuery query)
        {
            var result = await QueryAsync(query);
            return result.IsSuccess ? Ok(result.Value) : Error(result.Error);
        }
    }
}
