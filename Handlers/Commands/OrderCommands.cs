using System;
using System.Threading;
using System.Threading.Tasks;
using CQRS_Example.Models.Request;
using CQRS_Example.Models.Response;
using MediatR;

namespace CQRS_Example.Handlers.Commands
{
    public class OrderCommands : IRequestHandler<CreateOrderRequestModel, CreateOrderResponseModel>
    {
        public async Task<CreateOrderResponseModel> Handle(CreateOrderRequestModel request, CancellationToken cancellationToken)
        {
            if(request == null)
                throw new ArgumentNullException();
            return await Task.Run(() => new CreateOrderResponseModel(Guid.NewGuid().ToString()), cancellationToken);
        }
    }
}