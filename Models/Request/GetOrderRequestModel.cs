using CQRS_Example.Models.Response;
using MediatR;

namespace CQRS_Example.Models.Request
{
    public class GetOrderRequestModel : IRequest<GetOrderResponseModel>
    {
        public string OrderId { get; set; }
    }
}