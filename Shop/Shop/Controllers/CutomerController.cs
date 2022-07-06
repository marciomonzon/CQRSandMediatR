using MediatR;
using Microsoft.AspNetCore.Mvc;
using Shop.Domain.Commands.Requests;
using Shop.Domain.Commands.Responses;

namespace Shop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CutomerController : ControllerBase
    {
        //[HttpPost]
        //public CreateCustomerResponse Create([FromServices]ICreateCustomerHandler handler,
        //                                     [FromBody] CreateCustomerRequest command)
        //{
        //    return handler.Handle(command);
        //}

        [HttpPost]
        public Task<CreateCustomerResponse> Create([FromServices] IMediator mediator,
                                             [FromBody] CreateCustomerRequest command)
        {
            return mediator.Send(command);
        }
    }
}
