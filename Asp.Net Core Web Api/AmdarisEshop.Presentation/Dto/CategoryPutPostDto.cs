using System.ComponentModel.DataAnnotations;

namespace AmdarisEshop.Presentation.Dto
{
    public class CategoryPutPostDto
    {
        [Required]
        [MaxLength(30)]
        [MinLength(3)]
        public string CategoryName { get; set; }

        [Required]
        [MaxLength(500)]
        [MinLength(20)]
        public string CategoryDescription { get; set; }
    }
}
