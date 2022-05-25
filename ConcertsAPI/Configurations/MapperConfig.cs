using AutoMapper;
using ConcertsAPI.Data;
using ConcertsAPI.Models.Artists;
using ConcertsAPI.Models.Concerts;
using ConcertsAPI.Models.Places;
using ConcertsAPI.Models.Users;

namespace ConcertsAPI.Configurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<Concert, GetConcertsDto>().ReverseMap();
            CreateMap<Concert, GetConcertDetailsDto>().ReverseMap();
            CreateMap<Concert, CreateConcertDto>().ReverseMap();
            CreateMap<Concert, UpdateConcertDto>().ReverseMap();

            CreateMap<Artist, UpdateArtistDto>().ReverseMap();
            CreateMap<Artist, CreateArtistDto>().ReverseMap();

            CreateMap<Place, CreatePlaceDto>().ReverseMap();
            CreateMap<Place, UpdatePlaceDto>().ReverseMap();

            CreateMap<ApiUser, ApiUserDto>().ReverseMap();
            CreateMap<ApiUser, LoginDto>().ReverseMap();
            CreateMap<ApiUser, AuthResponseDto>().ReverseMap();







        }

    }
}
