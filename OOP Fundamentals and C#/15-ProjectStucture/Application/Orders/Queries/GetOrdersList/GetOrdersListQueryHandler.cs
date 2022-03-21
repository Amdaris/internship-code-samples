using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace Application.Orders.Queries.GetOrdersList
{
    public class GetOrdersListQueryHandler : IRequestHandler<GetOrdersListQuery, IEnumerable<OrderListVm>>
    {
        private readonly IOrderRepository _repository;

        public GetOrdersListQueryHandler(IOrderRepository repository)
        {
            _repository = repository;
        }

        public Task<IEnumerable<OrderListVm>> Handle(GetOrdersListQuery query, CancellationToken cancellationToken)
        {
            var result = _repository.GetOrders().Select(order => new OrderListVm
            {
                Id = order.Id,
                BuyerName = order.BuyerName,
                OrderItems = order.OrderItems.Select(item => new OrderItemListDto
                {
                    Quantity = item.Quantity,
                    ProductName = item.Product.Name
                }).ToList()
            });

            return Task.FromResult(result);
        }
    }
}