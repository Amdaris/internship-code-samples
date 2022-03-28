using System.Collections.Generic;
using MediatR;

namespace Application.Orders.Queries.GetOrdersList
{
    public class GetOrdersListQuery : IRequest<IEnumerable<OrderListVm>>
    {

    }
}