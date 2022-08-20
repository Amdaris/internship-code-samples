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
    public class DeleteCategoryHandler : IRequestHandler<DeleteCategory, Category>
    {
        private readonly DataContext _ctx;
        public DeleteCategoryHandler(DataContext ctx)
        {
            _ctx = ctx;
        }

        public async Task<Category> Handle(DeleteCategory request, CancellationToken cancellationToken)
        {
            var category = await _ctx.Categories.SingleOrDefaultAsync(c => c.CategoryId == request.CategoryId);

            if (category == null) return null;

            _ctx.Categories.Remove(category);
            await _ctx.SaveChangesAsync();

            return category;
        }
    }
}
