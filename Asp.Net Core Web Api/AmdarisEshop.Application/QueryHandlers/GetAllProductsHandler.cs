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
    public class GetAllProductsHandler : IRequestHandler<GetAllProducts, List<Product>>
    {
        private readonly DataContext _ctx;
        public GetAllProductsHandler(DataContext ctx)
        {
            _ctx = ctx; 
        }
        public async Task<List<Product>> Handle(GetAllProducts request, CancellationToken cancellationToken)
        {
            return await _ctx.Products.Include(p => p.Categories).ToListAsync();
        }
    }
}
