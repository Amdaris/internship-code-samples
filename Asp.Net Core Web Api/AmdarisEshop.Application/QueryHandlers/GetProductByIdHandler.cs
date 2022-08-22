using AmdarisEshop.Application.Abstract;
using AmdarisEshop.Application.Queries;
using AmdarisEshop.Domain.Models;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace AmdarisEshop.Application.QueryHandlers
{
    public class GetProductByIdHandler : IRequestHandler<GetProductById, Product>
    {
        private readonly IUnitOfWork _unitOfWork;
        public GetProductByIdHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Product> Handle(GetProductById request, CancellationToken cancellationToken)
        {
            return await _unitOfWork.ProductRepository.GetById(request.ProductId);
        }
    }
}
