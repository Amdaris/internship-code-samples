using AmdarisEshop.Domain.Models;
using MediatR;

namespace AmdarisEshop.Application.Commands
{
    public class DeleteCategory : IRequest<Category>
    {
        public int CategoryId { get; set; } 
    }
}
