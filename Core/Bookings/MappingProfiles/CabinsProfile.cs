using AutoMapper;
using Core.Bookings.Dto;
using Core.Cabins.Commands.Create;
using Domain.Entities;


namespace Core.Bookings.MappingProfiles
{
    public class CabinsProfile : Profile
    {
        public CabinsProfile() {
            CreateMap<Cabin,CabinResponseDto>();

            CreateMap<CreateCabinCommand, Cabin>();
        }
    }
}
