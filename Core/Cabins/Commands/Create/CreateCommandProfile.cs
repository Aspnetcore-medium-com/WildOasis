using AutoMapper;
using Domain.Entities;

namespace Core.Cabins.Commands.Create
{
    public class CreateCommandProfile : Profile
    {
        public CreateCommandProfile() {
            CreateMap<CreateCabinCommand, Cabin>();
        }
    }
}
