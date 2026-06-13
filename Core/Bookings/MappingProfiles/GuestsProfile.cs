using AutoMapper;
using Core.Bookings.Dto;
using Domain.Entities;


namespace Core.Bookings.MappingProfiles
{
    public class GuestsProfile : Profile
    {
        public GuestsProfile() {
            CreateMap<Guest,GuestsResponseDto>();
        }
    }
}
