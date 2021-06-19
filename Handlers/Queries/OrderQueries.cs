using CQRS_Example.Interfaces.Queries;
using CQRS_Example.Models.Request;
using CQRS_Example.Models.Response;

namespace CQRS_Example.Handlers.Queries
{
    public class OrderQueries : IOrderQuery
    {
        public GetOrderResponseModel GetOrder(GetOrderRequestModel requestModel)
        {
            return new GetOrderResponseModel() { OrderId = "73fb5932-e20c-4ce2-baff-486bcb97e880", ProductId = 455488, UserId = 12444 };
        }
    }
}