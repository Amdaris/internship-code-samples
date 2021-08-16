using MediatR;
using System.Collections.Generic;

namespace Application.Queries.GetProductsQuery
{
    public class GetProductsQuery : IRequest<IEnumerable<ProductViewModel>>
    {
    }
}
