using AmdarisEshop.Application.Queries;
using AmdarisEshop.Dal;
using AmdarisEshop.Domain.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AmdarisEshop.Application.QueryHandlers
{
    public class GetProductByIdHandler : IRequestHandler<GetProductById, Product>
    {
        private readonly DataContext _ctx;
        public GetProductByIdHandler(DataContext ctx)
        {
            _ctx = ctx;
        }
        public async Task<Product> Handle(GetProductById request, CancellationToken cancellationToken)
        {
            return await _ctx.Products
                .Include(p => p.Categories)
                .FirstOrDefaultAsync(p => p.ProductId == request.ProductId);
        }
    }
}
