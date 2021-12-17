using AmdarisEshop.Domain.Models;
using MediatR;

namespace AmdarisEshop.Application.Commands
{
    public class CreateCategory : IRequest<Category>
    {
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }
    }
}
