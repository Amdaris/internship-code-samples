using AmdarisEshop.Domain.Models;
using AmdarisEshop.Dto;
using AutoMapper;

namespace AmdarisEshop.Profiles
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
