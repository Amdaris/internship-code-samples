using AmdarisEshop.Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmdarisEshop.Application.Commands
{
    public class CreateProduct : IRequest<Product>
    {
        public string ProductName { get; set; }
        public string ProdcutDescription { get; set; }
        public int AvailableQuantity { get; set; }
        public double Price { get; set; }
    }
}
