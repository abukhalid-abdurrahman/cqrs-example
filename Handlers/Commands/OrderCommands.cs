using System;
using CQRS_Example.Interfaces.Commands;
using CQRS_Example.Models.Request;
using CQRS_Example.Models.Response;

namespace CQRS_Example.Handlers.Commands
{
    public class OrderCommands : IOrderCommands
    {
        /// <summary>
        /// Creates an order
        /// </summary>
        /// <param name="requestModel">order parameters</param>
        /// <returns>an orderId</returns>
        public CreateOrderResponseModel CreateOrder(CreateOrderRequestModel requestModel)
        {
            return new CreateOrderResponseModel(Guid.NewGuid().ToString());
        }
    }
}