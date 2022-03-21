using System.Collections.Generic;

namespace Application.Orders.Queries.GetOrdersList
{
    public class OrderListVm
    {
        public string BuyerName { get; set; }
        public int Id { get; set; }
        public List<OrderItemListDto> OrderItems { get; set; }
    }
}