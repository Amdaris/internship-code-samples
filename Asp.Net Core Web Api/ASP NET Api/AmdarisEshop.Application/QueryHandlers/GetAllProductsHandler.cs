using AmdarisEshop.Application.Abstract;
using AmdarisEshop.Application.Queries;
using AmdarisEshop.Domain.Models;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace AmdarisEshop.Application.QueryHandlers
{
    public class GetAllProductsHandler : IRequestHandler<GetAllProducts, List<Product>>
    {
        private readonly IUnitOfWork _unitOfWork;
        public GetAllProductsHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<List<Product>> Handle(GetAllProducts request, CancellationToken cancellationToken)
        {
            return await _unitOfWork.ProductRepository.GetAll();
        }
    }
}
