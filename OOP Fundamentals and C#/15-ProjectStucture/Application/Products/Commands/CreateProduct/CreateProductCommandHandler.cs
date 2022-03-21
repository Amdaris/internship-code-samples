using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Domain;
using MediatR;

namespace Application.Products.Commands.CreateProduct
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, int>
    {
        private readonly IProductRepository _repository;

        public CreateProductCommandHandler(IProductRepository repository)
        {
            _repository = repository;
        }

        public Task<int> Handle(CreateProductCommand command, CancellationToken cancellationToken)
        {
            var product = new Product(command.Name, command.Price);
            _repository.CreateProduct(product);

            return Task.FromResult(product.Id);
        }
    }
}
