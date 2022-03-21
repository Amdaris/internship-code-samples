namespace Application.Orders.Commands.CreateOrder
{
    public class OrderItemDto
    {
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
    }
}