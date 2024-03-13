using AutoMapper;
using LekeCozumleri.DtoLayer.Category;
using LekeCozumleri.Entities.Concretes;

namespace LekeCozumleri.API.AutoMapper
{
    public class CategoryMapping : Profile
    {
        public CategoryMapping()
        {
            CreateMap<CreateCategoryDto, Category>().ReverseMap();
        }
    }
}
