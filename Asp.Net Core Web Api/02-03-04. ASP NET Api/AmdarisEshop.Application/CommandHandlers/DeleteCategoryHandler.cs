using AmdarisEshop.Application.Abstract;
using AmdarisEshop.Application.Commands;
using AmdarisEshop.Domain.Models;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace AmdarisEshop.Application.CommandHandlers
{
    public class DeleteCategoryHandler : IRequestHandler<DeleteCategory, Category>
    {
        private readonly IUnitOfWork _unitOfWork;
        public DeleteCategoryHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Category> Handle(DeleteCategory request, CancellationToken cancellationToken)
        {
            var category = await _unitOfWork.CategoryRepository.GetById(request.CategoryId);
            if (category == null) return null;

            _unitOfWork.CategoryRepository.Remove(category);

            await _unitOfWork.Save();

            return category;
        }
    }
}
