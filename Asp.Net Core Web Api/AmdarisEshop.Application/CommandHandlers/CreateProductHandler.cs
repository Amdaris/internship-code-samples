using AmdarisEshop.Application.Abstract;
using AmdarisEshop.Application.Commands;
using AmdarisEshop.Domain.Models;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace AmdarisEshop.Application.CommandHandlers
{
    public class CreateProductHandler : IRequestHandler<CreateProduct, Product>
    {
        private readonly IUnitOfWork _unitOfWork;
        public CreateProductHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Product> Handle(CreateProduct request, CancellationToken cancellationToken)
        {
            var product = new Product
            {
                AvailableQuantity = request.AvailableQuantity,
                ProductName = request.ProductName,
                ProdcutDescription = request.ProdcutDescription,
                Price = request.Price,
            };

            await _unitOfWork.ProductRepository.Add(product);
            await _unitOfWork.Save();

            return product;
        }
    }
}
