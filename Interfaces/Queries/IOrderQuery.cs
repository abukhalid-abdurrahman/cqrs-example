using CQRS_Example.Models.Request;
using CQRS_Example.Models.Response;

namespace CQRS_Example.Interfaces.Queries
{
    public interface IOrderQuery
    {
        GetOrderResponseModel GetOrder(GetOrderRequestModel requestModel);
    }
}