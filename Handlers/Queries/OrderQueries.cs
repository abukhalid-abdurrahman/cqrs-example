using System;
using System.Threading;
using System.Threading.Tasks;
using CQRS_Example.Models.Request;
using CQRS_Example.Models.Response;
using MediatR;

namespace CQRS_Example.Handlers.Queries
{
    public class OrderQueries : IRequestHandler<GetOrderRequestModel, GetOrderResponseModel>
    {
        public async Task<GetOrderResponseModel> Handle(GetOrderRequestModel request, CancellationToken cancellationToken)
        {
            if(request == null)
                throw new ArgumentNullException();
            return await Task.Run(() => new GetOrderResponseModel() { OrderId = "73fb5932-e20c-4ce2-baff-486bcb97e880", ProductId = 455488, UserId = 12444 }, cancellationToken);
        }
    }
}