using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace Application.Products.Queries.GetProductsList
{
    public class GetProductsListQuery: IRequest<IEnumerable<ProductListVm>>
    {
    }
}
