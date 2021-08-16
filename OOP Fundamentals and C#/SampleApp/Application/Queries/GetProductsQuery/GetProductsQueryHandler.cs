using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Queries.GetProductsQuery
{
    public class GetProductsQueryHandler : IRequestHandler<GetProductsQuery, IEnumerable<ProductViewModel>>
    {
        private readonly IProductRepository repository;

        public GetProductsQueryHandler(IProductRepository repository)
        {
            this.repository = repository;
        }
        public Task<IEnumerable<ProductViewModel>> Handle(GetProductsQuery request, CancellationToken cancellationToken)
        {
            var result = this.repository.GetProducts().Select(p => new ProductViewModel { Id = p.Id, Name = p.Name });
            return Task.FromResult(result);
        }
    }
}
