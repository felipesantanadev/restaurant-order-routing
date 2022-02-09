using MediatR;
using Microsoft.AspNetCore.Mvc;
using RestaurantOrderRouting.Crosscutting.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantOrderRouting.Order.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class CustomController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CustomController(IMediator mediator)
        {
            _mediator = mediator ?? throw new ArgumentNullException();
        }

        protected async Task<TResult> QueryAsync<TResult>(IRequest<TResult> query)
        {
            return await _mediator.Send(query);
        }

        protected async Task<TResult> CommandAsync<TResult>(IRequest<TResult> command)
        {
            return await _mediator.Send(command);
        }

        protected new IActionResult Ok()
        {
            return base.Ok(Envelope.Ok());
        }

        protected IActionResult Ok<T>(T result)
        {
            return base.Ok(Envelope.Ok(result));
        }

        protected IActionResult Error(string errorMessage)
        {
            return BadRequest(Envelope.Error(errorMessage));
        }
    }
}
