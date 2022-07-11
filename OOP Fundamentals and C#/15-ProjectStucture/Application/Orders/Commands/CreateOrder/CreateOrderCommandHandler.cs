using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Domain;
using MediatR;

namespace Application.Orders.Commands.CreateOrder
{
    public class CreateOrderCommandHandler : IRequestHandler<CreateOrderCommand, int>
    {
        private readonly IOrderRepository _repository;

        public CreateOrderCommandHandler(IOrderRepository repository)
        {
            _repository = repository;
        }

        public Task<int> Handle(CreateOrderCommand command, CancellationToken cancellationToken)
        {
            var orderItems = command.OrderItems.Select(orderItemDto =>
                new OrderItem(new Product(orderItemDto.ProductName, orderItemDto.Price), orderItemDto.Quantity));

            var order = new Order(command.BuyerName, orderItems.ToList());
            _repository.CreateOrder(order);

            return Task.FromResult(order.Id);
        }
    }
}