using AmdarisEshop.Application.Abstract;
using AmdarisEshop.Application.Commands;
using AmdarisEshop.Domain.Models;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace AmdarisEshop.Application.CommandHandlers
{
    public class UpdateProductHandler : IRequestHandler<UpdateProduct, Product>
    {
        private readonly IUnitOfWork _unitOfWork;
        public UpdateProductHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Product> Handle(UpdateProduct request, CancellationToken cancellationToken)
        {
            var toUpdate = new Product
            {
                AvailableQuantity = request.Quantity,
                Price = request.Price,
                ProductName = request.Name,
                ProdcutDescription = request.Description,
                ProductId = request.ProductId,
            };

            await _unitOfWork.ProductRepository.Update(toUpdate);

            await _unitOfWork.Save();

            return toUpdate;
        }
    }
}
