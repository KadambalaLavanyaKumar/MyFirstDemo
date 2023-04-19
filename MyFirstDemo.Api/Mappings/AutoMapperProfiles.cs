using AutoMapper;
using MyFirstDemo.Api.Models.Domain;
using MyFirstDemo.Api.Models.Dto;
using MyFirstDemo.Api.Models.RegionDto;

namespace MyFirstDemo.Api.Mappings
{
    public class AutoMapperProfiles : Profile
    {
       public AutoMapperProfiles() {
            CreateMap<Region,RegionDto>().ReverseMap();
            CreateMap<AddRegionRequestDto,Region>().ReverseMap();
            CreateMap<UpdateRegionRequestDto, Region>().ReverseMap();
            CreateMap<AddWalkRequestDto, Walk>().ReverseMap();
            CreateMap<Walk, WalkDto>().ReverseMap();
            CreateMap<Difficulty, DifficultyDto>().ReverseMap();
            CreateMap<UpdateWalkRequestDto, Walk>().ReverseMap();
        }
    }

  
}
