using AmdarisEshop.Application.Abstract;
using AmdarisEshop.Application.Queries;
using AmdarisEshop.Domain.Models;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace AmdarisEshop.Application.QueryHandlers
{
    public class GetCategoryByIdHandler : IRequestHandler<GetCategoryById, Category>
    {
        private readonly IUnitOfWork _unitOfWork;
        public GetCategoryByIdHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<Category> Handle(GetCategoryById request, CancellationToken cancellationToken)
        {

            var category = await _unitOfWork.CategoryRepository.GetById(request.CategoryId);

            return category;
        }
    }
}
