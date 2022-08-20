using AmdarisEshop.Application.Queries;
using AmdarisEshop.Dal;
using AmdarisEshop.Domain.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace AmdarisEshop.Application.QueryHandlers
{
    public class GetCategoryByIdHandler : IRequestHandler<GetCategoryById, Category>
    {
        private readonly DataContext _ctx;
        public GetCategoryByIdHandler(DataContext ctx)
        {
            _ctx = ctx;
        }
        public async Task<Category> Handle(GetCategoryById request, CancellationToken cancellationToken)
        {
            var category = await _ctx.Categories.SingleOrDefaultAsync(c => c.CategoryId == request.CategoryId);

            return category;
        }
    }
}
