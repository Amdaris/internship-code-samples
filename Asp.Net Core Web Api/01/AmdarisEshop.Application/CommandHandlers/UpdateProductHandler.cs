using AmdarisEshop.Application.Commands;
using AmdarisEshop.Dal;
using AmdarisEshop.Domain.Models;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace AmdarisEshop.Application.CommandHandlers
{
    public class UpdateProductHandler : IRequestHandler<UpdateProduct, Product>
    {
        private readonly DataContext _ctx;
        public UpdateProductHandler(DataContext ctx)
        {
            _ctx = ctx;
        }
        public async Task<Product> Handle(UpdateProduct request, CancellationToken cancellationToken)
        {
            var toUpdate = new Product
            {
                AvailableQuantity = request.Quantity,
                Price = request.Price,
                ProductName = request.Name,
                ProdcutDescription = request.Description,
                ProductId = request.ProductId,
            };

            _ctx.Update(toUpdate);
            await _ctx.SaveChangesAsync();

            return toUpdate;
        }
    }
}
