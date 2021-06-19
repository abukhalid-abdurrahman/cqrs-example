namespace CQRS_Example.Models.Response
{
    public class CreateOrderResponseModel
    {
        public string OrderId { get; set; }
        public CreateOrderResponseModel() {}
        public CreateOrderResponseModel(string orderId)
        {
            OrderId = orderId;
        }
    }
}