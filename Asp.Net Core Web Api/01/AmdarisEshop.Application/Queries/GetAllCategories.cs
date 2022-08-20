using AmdarisEshop.Domain.Models;
using MediatR;
using System.Collections.Generic;

namespace AmdarisEshop.Application.Queries
{
    public class GetAllCategories : IRequest<List<Category>>
    {
    }
}
