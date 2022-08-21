using AmdarisEshop.Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmdarisEshop.Application.Queries
{
    public class GetProductById : IRequest<Product>
    {
        public int ProductId { get; set; }
    }
}
