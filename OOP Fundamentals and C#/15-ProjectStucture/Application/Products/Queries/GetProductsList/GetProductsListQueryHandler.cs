using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace Application.Products.Queries.GetProductsList
{
    public class GetProductsListQueryHandler : IRequestHandler<GetProductsListQuery, IEnumerable<ProductListVm>>
    {
        private readonly IProductRepository _repository;

        public GetProductsListQueryHandler(IProductRepository repository)
        {
            _repository = repository;
        }

        public Task<IEnumerable<ProductListVm>> Handle(GetProductsListQuery query, CancellationToken cancellationToken)
        {
            var result = _repository.GetProducts().Select(product => new ProductListVm
            {
                Id = product.Id,
                Name = product.Name
            });

            return Task.FromResult(result);
        }
    }
}
