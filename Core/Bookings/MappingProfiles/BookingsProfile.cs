using AutoMapper;
using Core.Bookings.Dto;
using Domain.Entities;

namespace Core.Bookings.MappingProfiles
{
    public class BookingsProfile : Profile
    {
        public BookingsProfile() {
            CreateMap<Booking,BookingsResponseDto>()
                 .ForMember(dest => dest.Cabin, opt => opt.MapFrom(src => src.Cabin))
                 .ForMember(dest => dest.Guest, opt => opt.MapFrom(src => src.Guest));
        }
    }

}
