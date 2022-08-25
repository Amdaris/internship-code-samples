using AmdarisEshop.Domain.Models;
using AmdarisEshop.Presentation.Dto;
using AutoMapper;

namespace AmdarisEshop.Presentation.Profiles
{
    public class CategoryProfile : Profile
    {
        public CategoryProfile()
        {
            CreateMap<CategoryPutPostDto, Category>();
            CreateMap<Category, CategoryGetDto>();
        }
    }
}
