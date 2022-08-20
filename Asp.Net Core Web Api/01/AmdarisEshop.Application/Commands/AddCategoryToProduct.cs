using MediatR;

namespace AmdarisEshop.Application.Commands
{
    public class AddCategoryToProduct : IRequest
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; } 
    }
}
