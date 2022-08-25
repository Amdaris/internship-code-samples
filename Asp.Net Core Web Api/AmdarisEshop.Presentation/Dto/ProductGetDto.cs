using AmdarisEshop.Domain.Models;
using System.Collections.Generic;

namespace AmdarisEshop.Presentation.Dto
{
    public class ProductGetDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public ICollection<ProductCategoryDto> Categories {get; set;}
    }
}
