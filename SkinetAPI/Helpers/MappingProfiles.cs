using AutoMapper;
using Core.Entities;
using SkinetAPI.Dtos;

namespace SkinetAPI.Helpers
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Product, ProductToReturnDto>();
        }
    }
}
