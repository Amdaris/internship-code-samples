using AmdarisEshop.Application.Commands;
using AmdarisEshop.Dal;
using AmdarisEshop.Domain.Models;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace AmdarisEshop.Application.CommandHandlers
{
    public class UpdateCategoryHandler : IRequestHandler<UpdateCategory, Category>
    {
        private readonly DataContext _ctx;
        public UpdateCategoryHandler(DataContext ctx)
        {
            _ctx = ctx;
        }
        public async Task<Category> Handle(UpdateCategory request, CancellationToken cancellationToken)
        {
            var toUpdate = new Category();
            toUpdate.CategoryName = request.CategoryName;
            toUpdate.CategoryDescription = request.CategoryDescription;
            toUpdate.CategoryId = request.CatetgoryId;

            _ctx.Categories.Update(toUpdate);
            await _ctx.SaveChangesAsync();

            return toUpdate;
        }
    }
}
