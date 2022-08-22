using AmdarisEshop.Application.Abstract;
using AmdarisEshop.Application.Commands;
using AmdarisEshop.Domain.Models;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace AmdarisEshop.Application.CommandHandlers
{
    public class CreateCategoryCommandHandler : IRequestHandler<CreateCategory, Category>
    {
        private readonly IUnitOfWork _unitOfWork;
        public CreateCategoryCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Category> Handle(CreateCategory request, CancellationToken cancellationToken)
        {
            var category = new Category { CategoryName = request.CategoryName, CategoryDescription = request.CategoryDescription };

            await _unitOfWork.CategoryRepository.Add(category);
            await _unitOfWork.Save();

            return category;
        }
    }
}
