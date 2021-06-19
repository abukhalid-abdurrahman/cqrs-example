namespace CQRS_Example.Models.Request
{
    public class CreateOrderRequestModel
    {
        public int ProductId { get; set; }
        public int UserId { get; set; }
    }
}