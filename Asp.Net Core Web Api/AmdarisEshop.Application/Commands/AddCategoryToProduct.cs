using AmdarisEshop.Domain.Models;
using MediatR;
using System.Collections.Generic;

namespace AmdarisEshop.Application.Commands
{
    public class AddCategoryToProduct : IRequest<Product>
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; } 
    }
}
