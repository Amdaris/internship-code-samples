using AmdarisEshop.Application.Commands;
using AmdarisEshop.Dal;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AmdarisEshop.Application.CommandHandlers
{
    public class RemoveCategoryFromProductHandler : IRequestHandler<RemoveCategoryFromProduct>
    {
        private readonly DataContext _ctx;
        public RemoveCategoryFromProductHandler(DataContext ctx)
        {
            _ctx = ctx;
        }
        public async Task<Unit> Handle(RemoveCategoryFromProduct request, CancellationToken cancellationToken)
        {
            var product = await _ctx.Products
                .Include(p => p.Categories)
                .SingleOrDefaultAsync(p => p.ProductId == request.ProductId);

            var category = await _ctx.Categories.SingleOrDefaultAsync(c => c.CategoryId == request.CategoryId);

            if (product != null && category != null)
            {
                product.Categories.Remove(category);
                _ctx.Products.Update(product);
                await _ctx.SaveChangesAsync();
            }

            return new Unit();
        }
    }
}
