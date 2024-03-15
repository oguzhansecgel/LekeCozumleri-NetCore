using AutoMapper;
using LekeCozumleri.DtoLayer.Stain;
using LekeCozumleri.Entities.Concretes;

namespace LekeCozumleri.API.AutoMapper
{
    public class StainMapping : Profile
    {
        public StainMapping()
        {
            CreateMap<CreateStainDto, Stain>().ReverseMap();
            CreateMap<StainWithCategoryDto, Stain>().ReverseMap();
        }
    }
}
