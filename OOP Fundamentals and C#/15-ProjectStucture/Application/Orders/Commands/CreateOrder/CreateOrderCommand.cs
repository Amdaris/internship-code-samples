using System.Collections.Generic;
using MediatR;

namespace Application.Orders.Commands.CreateOrder
{
    public class CreateOrderCommand : IRequest<int>
    {
        public string BuyerName { get; set; }
        public List<OrderItemDto> OrderItems { get; set; }
    }
}