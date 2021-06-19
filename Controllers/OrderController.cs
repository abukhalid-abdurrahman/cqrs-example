using CQRS_Example.Interfaces.Commands;
using CQRS_Example.Interfaces.Queries;
using CQRS_Example.Models.Request;
using CQRS_Example.Models.Response;
using Microsoft.AspNetCore.Mvc;

namespace CQRS_Example.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly IOrderCommands _orderCommands;
        private readonly IOrderQuery _orderQueries;

        public OrderController(IOrderCommands orderCommands, IOrderQuery orderQueries)
        {
            _orderCommands = orderCommands;
            _orderQueries = orderQueries;
        }

        [HttpPost]
        public CreateOrderResponseModel CreateOrder(CreateOrderRequestModel requestModel)
        {
            return _orderCommands.CreateOrder(requestModel);
        }
        
        [HttpGet("{id}")]
        public GetOrderResponseModel GetOrder(string id)
        {
            return _orderQueries.GetOrder(new GetOrderRequestModel() { OrderId = id});
        }
    }
}