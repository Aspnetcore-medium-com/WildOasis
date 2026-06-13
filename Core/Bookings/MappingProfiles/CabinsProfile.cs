using AutoMapper;
using Core.Bookings.Dto;
using Domain.Entities;


namespace Core.Bookings.MappingProfiles
{
    public class CabinsProfile : Profile
    {
        public CabinsProfile() {
            CreateMap<Cabin,CabinResponseDto>();
        }
    }
}
