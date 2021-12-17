using AmdarisEshop.Application.Commands;
using AmdarisEshop.Dal;
using AmdarisEshop.Domain.Models;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace AmdarisEshop.Application.CommandHandlers
{
    public class CreateProductHandler : IRequestHandler<CreateProduct, Product>
    {
        private readonly DataContext _ctx;
        public CreateProductHandler(DataContext ctx)
        {
            _ctx = ctx;
        }
        
        public async Task<Product> Handle(CreateProduct request, CancellationToken cancellationToken)
        {
            var product = new Product
            {
                AvailableQuantity = request.AvailableQuantity,
                ProductName = request.ProductName,
                ProdcutDescription = request.ProdcutDescription,
                Price = request.Price
            };

            _ctx.Products.Add(product);
            await _ctx.SaveChangesAsync();
            return product;
        }
    }
}
