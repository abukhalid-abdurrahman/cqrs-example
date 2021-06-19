namespace CQRS_Example.Models.Response
{
    public class GetOrderResponseModel
    {
        public string OrderId { get; set; }
        public int UserId { get; set; }
        public int ProductId { get; set; }
    }
}