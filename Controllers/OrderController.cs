using System.Threading.Tasks;
using CQRS_Example.Models.Request;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CQRS_Example.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly IMediator _mediator;

        public OrderController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> CreateOrder(CreateOrderRequestModel requestModel)
        {
            var response = await _mediator.Send(requestModel);
            return Ok(response);
        }
        
        [HttpGet("{id}")]
        public async Task<IActionResult> GetOrder(string id)
        {
            var response = await _mediator.Send(new GetOrderRequestModel() {OrderId = id});
            return Ok(response);
        }
    }
}