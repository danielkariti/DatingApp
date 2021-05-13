using System.Linq;
using API.DTOs;
using API.Entities;
using API.Extentions;
using AutoMapper;

namespace API.Helpers
{
    public class AutoMapperProflies : Profile
    {
        public AutoMapperProflies()
        {
            CreateMap<AppUser , MemberDTO>()
            .ForMember(dest => dest.PhotoUrl, opt => opt
            .MapFrom(src => src.Photos
            .FirstOrDefault(x => x.IsMain).Url))
            .ForMember(dest => dest.Age , opt => opt
            .MapFrom(src => src.DateOfBirth.CalculateAge()));

            CreateMap<Photo , PhotoDTO>();
        }
    }
}