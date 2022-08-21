using AmdarisEshop.Application.Abstract;
using AmdarisEshop.Application.Queries;
using AmdarisEshop.Domain.Models;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace AmdarisEshop.Application.QueryHandlers
{
    public class GetAllCategoriesHandler : IRequestHandler<GetAllCategories, List<Category>>
    {
        private readonly IUnitOfWork _unitOfWork;
        public GetAllCategoriesHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<List<Category>> Handle(GetAllCategories request, CancellationToken cancellationToken)
        {
            return await _unitOfWork.CategoryRepository.GetAll();
        }
    }
}
