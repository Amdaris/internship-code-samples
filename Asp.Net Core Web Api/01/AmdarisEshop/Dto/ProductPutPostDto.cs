using System.ComponentModel.DataAnnotations;

namespace AmdarisEshop.Dto
{
    public class ProductPutPostDto
    {
        [Required]
        [MaxLength(30)]
        [MinLength(3)]
        public string Name { get; set; }

        [Required]
        [MaxLength(500)]
        [MinLength(20)]
        public string Description { get; set; }

        [Required]
        [Range(1, int.MaxValue)]
        public int Quantity { get; set; }

        [Required]
        [Range(0.1, double.MaxValue)]
        public double Price { get; set; }
    }
}
