using AutoMapper;
using CleanArchitectureTemplate.Application.Features;
using CleanArchitectureTemplate.Application.ViewModels;
using CleanArchitectureTemplate.Domain.Entities;

namespace CleanArchitectureTemplate.Infrastructure.Mapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Entity, PostEntityCommand>().ReverseMap();
            CreateMap<EntityViewModels, PostEntityCommand>().ReverseMap();

            CreateMap<Entity, GetEntityModel>().ReverseMap();
            CreateMap<GetEntityModel, EntityViewModels>().ReverseMap();
            
        }
    }
}
