using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using RestaurantOrderRouting.Order.Application.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantOrderRouting.Order.API.Controllers
{
    [Route("api/orders")]
    [ApiController]
    public class OrdersController : CustomController
    {
        public OrdersController(IMediator mediator) : base(mediator) { }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] MakeOrderCommand command)
        {
            var result = await CommandAsync(command);
            return result.IsSuccess ? Ok(result.Value) : Error(result.Error);
        }

        // The UpdateOrderItemStatus action could be a HttpPatch method
        // The HttpPost was used to simplify the MediatR command
        [HttpPost("{id}/items/{itemId}/update-status")]
        public async Task<IActionResult> UpdateOrderItemStatus([FromRoute] int id, [FromRoute] int itemId, [FromBody] UpdateOrderItemStatusCommand command)
        {
            if (id != command.OrderId || itemId != command.OrderItemId)
                return Error("Invalid operation.");

            var result = await CommandAsync(command);
            return result.IsSuccess ? Ok() : Error(result.Error);
        }
    }
}
