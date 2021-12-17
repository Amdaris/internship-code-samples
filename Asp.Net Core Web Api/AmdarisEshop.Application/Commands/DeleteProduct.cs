using AmdarisEshop.Domain.Models;
using MediatR;

namespace AmdarisEshop.Application.Commands
{
    public class DeleteProduct : IRequest<Product>
    {
        public int ProductId { get; set; }
    }
}
