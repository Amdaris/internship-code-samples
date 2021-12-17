using AmdarisEshop.Application.Commands;
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

namespace AmdarisEshop.Application.CommandHandlers
{
    public class DeleteProductHandler : IRequestHandler<DeleteProduct, Product>
    {
        private readonly DataContext _ctx;
        public DeleteProductHandler(DataContext ctx)
        {
            _ctx = ctx;
        }

        public async Task<Product> Handle(DeleteProduct request, CancellationToken cancellationToken)
        {
            var product = await _ctx.Products.FirstOrDefaultAsync(p => p.ProductId == request.ProductId);

            if (product == null) return null;

            _ctx.Products.Remove(product);
            await _ctx.SaveChangesAsync();

            return product;
        }
    }
}
