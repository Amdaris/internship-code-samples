using AmdarisEshop.Application.Abstract;
using AmdarisEshop.Application.Commands;
using AmdarisEshop.Domain.Models;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace AmdarisEshop.Application.CommandHandlers
{
    public class UpdateCategoryHandler : IRequestHandler<UpdateCategory, Category>
    {
        private readonly IUnitOfWork _unitOfWork;
        public UpdateCategoryHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Category> Handle(UpdateCategory request, CancellationToken cancellationToken)
        {
            var toUpdate = new Category();
            toUpdate.CategoryName = request.CategoryName;
            toUpdate.CategoryDescription = request.CategoryDescription;
            toUpdate.CategoryId = request.CatetgoryId;

            await _unitOfWork.CategoryRepository.Update(toUpdate);
            await _unitOfWork.Save();

            return toUpdate;
        }
    }
}
