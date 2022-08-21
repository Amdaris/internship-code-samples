using AmdarisEshop.Application.Abstract;
using AmdarisEshop.Application.Commands;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace AmdarisEshop.Application.CommandHandlers
{
    public class AddCategoryToProductHandler : IRequestHandler<AddCategoryToProduct>
    {
        private readonly IUnitOfWork _unitOfWork;
        public AddCategoryToProductHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        
        public async Task<Unit> Handle(AddCategoryToProduct request, CancellationToken cancellationToken)
        {
            var product = await _unitOfWork.ProductRepository.GetById(request.ProductId);
            var category = await _unitOfWork.CategoryRepository.GetById(request.CategoryId);

            if (product != null && category != null)
            {
                product.Categories.Add(category);
                await _unitOfWork.Save();
            }

            return new Unit();
        }
    }
}
