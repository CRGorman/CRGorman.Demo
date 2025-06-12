using AutoMapper;
using CRGorman.Demo.SpeedrunData.Models;
using CRGorman.Demo.ViewModels;

namespace CRGorman.Demo.ApiService
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Game, GameDto>();
            CreateMap<Act, ActDto>();
            CreateMap<Mission, MissionDto>();
            CreateMap<Game, TableOfContentsDto>();
        }
    }
}