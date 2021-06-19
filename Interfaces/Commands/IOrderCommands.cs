using CQRS_Example.Models.Request;
using CQRS_Example.Models.Response;

namespace CQRS_Example.Interfaces.Commands
{
    public interface IOrderCommands
    {
        CreateOrderResponseModel CreateOrder(CreateOrderRequestModel requestModel);
    }
}