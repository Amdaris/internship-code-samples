using AmdarisEshop.Application.Commands;
using AmdarisEshop.Dal;
using AmdarisEshop.Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AmdarisEshop.Application.CommandHandlers
{
    public class CreateCategoryCommandHandler : IRequestHandler<CreateCategory, Category>
    {
        private readonly DataContext _ctx;
        public CreateCategoryCommandHandler(DataContext ctx)
        {
            _ctx = ctx;
        }
        public async Task<Category> Handle(CreateCategory request, CancellationToken cancellationToken)
        {
            var category = new Category { CategoryName = request.CategoryName, CategoryDescription = request.CategoryDescription };
            _ctx.Categories.Add(category);
            await _ctx.SaveChangesAsync();
            return category;
        }
    }
}
