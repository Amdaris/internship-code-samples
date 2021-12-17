using AmdarisEshop.Application.Queries;
using AmdarisEshop.Dal;
using AmdarisEshop.Domain.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace AmdarisEshop.Application.QueryHandlers
{
    public class GetAllCategoriesHandler : IRequestHandler<GetAllCategories, List<Category>>
    {
        private readonly DataContext _ctx;
        public GetAllCategoriesHandler(DataContext ctx)
        {
            _ctx = ctx;
        }
        
        public async Task<List<Category>> Handle(GetAllCategories request, CancellationToken cancellationToken)
        {
            return await _ctx.Categories.ToListAsync();
        }
    }
}
