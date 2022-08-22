using AmdarisEshop.Domain.Models;
using MediatR;

namespace AmdarisEshop.Application.Queries
{
    public class GetCategoryById : IRequest<Category>
    {
        public int CategoryId { get; set; }
    }
}
