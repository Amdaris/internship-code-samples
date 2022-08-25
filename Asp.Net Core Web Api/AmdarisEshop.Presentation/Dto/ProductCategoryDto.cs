using System.ComponentModel.DataAnnotations;

namespace AmdarisEshop.Presentation.Dto
{
    public class ProductCategoryDto
    {
        [Required]
        [Range(1, int.MaxValue)]
        public string CategoryName { get; set; }

        [Required]
        [Range(1, int.MaxValue)]
        public string CategoryDescription { get; set; }
    }
}
