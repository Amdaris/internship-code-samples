using AmdarisEshop.Application.Commands;
using AmdarisEshop.Domain.Models;
using AmdarisEshop.Dto;
using AutoMapper;

namespace AmdarisEshop.Profiles
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<Product, ProductGetDto>()
                .ForMember(p => p.Id, opt => opt.MapFrom(s => s.ProductId))
                .ForMember(p => p.Name, opt => opt.MapFrom(s => s.ProductName))
                .ForMember(p => p.Description, opt => opt.MapFrom(s => s.ProdcutDescription))
                .ForMember(p => p.Quantity, opt => opt.MapFrom(s => s.AvailableQuantity));

            CreateMap<ProductPutPostDto, CreateProduct>()
                .ForMember(cp => cp.AvailableQuantity, opt => opt.MapFrom(src => src.Quantity))
                .ForMember(cp => cp.ProdcutDescription, opt => opt.MapFrom(src => src.Description))
                .ForMember(cp => cp.ProductName, opt => opt.MapFrom(src => src.Name));

            CreateMap<Category, ProductCategoryDto>();
        }
    }
}
