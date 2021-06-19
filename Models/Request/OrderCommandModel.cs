namespace CQRS_Example.Models.Request
{
    public class OrderCommandModel
    {
        public int ProductId { get; set; }
        public int UserId { get; set; }
    }
}