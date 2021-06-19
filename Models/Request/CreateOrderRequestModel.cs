using CQRS_Example.Models.Response;
using MediatR;

namespace CQRS_Example.Models.Request
{
    public class CreateOrderRequestModel : IRequest<CreateOrderResponseModel>
    {
        public int ProductId { get; set; }
        public int UserId { get; set; }
    }
}