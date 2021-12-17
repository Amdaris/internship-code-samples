using AmdarisEshop.Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmdarisEshop.Application.Commands
{
    public class UpdateProduct : IRequest<Product>
    {
        public int ProductId { get; set; }  
        public string Name { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
    }
}
