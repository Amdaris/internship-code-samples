using AmdarisEshop.Application.Abstract;
using AmdarisEshop.Application.Commands;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace AmdarisEshop.Application.CommandHandlers
{
    public class RemoveCategoryFromProductHandler : IRequestHandler<RemoveCategoryFromProduct>
    {
        private readonly IUnitOfWork _unitOfWork;
        public RemoveCategoryFromProductHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<Unit> Handle(RemoveCategoryFromProduct request, CancellationToken cancellationToken)
        {
            var product = await _unitOfWork.ProductRepository.GetById(request.ProductId);
            var category = await _unitOfWork.CategoryRepository.GetById(request.CategoryId);

            if (product != null && category != null)
            {

                product.Categories.Remove(category);
                await _unitOfWork.Save();
            }

            return new Unit();
        }
    }
}
