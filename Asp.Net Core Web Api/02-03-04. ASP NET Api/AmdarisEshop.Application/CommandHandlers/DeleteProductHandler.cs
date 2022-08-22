using AmdarisEshop.Application.Abstract;
using AmdarisEshop.Application.Commands;
using AmdarisEshop.Domain.Models;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace AmdarisEshop.Application.CommandHandlers
{
    public class DeleteProductHandler : IRequestHandler<DeleteProduct, Product>
    {
        private readonly IUnitOfWork _unitOfWork;
        public DeleteProductHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Product> Handle(DeleteProduct request, CancellationToken cancellationToken)
        {
            var product = await _unitOfWork.ProductRepository.GetById(request.ProductId);
            if (product == null) return null;

            _unitOfWork.ProductRepository.Remove(product);
            await _unitOfWork.Save();

            return product;
        }
    }
}
