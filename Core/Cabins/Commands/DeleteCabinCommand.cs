using Domain.Entities;
using MediatR;


namespace Core.Cabins.Commands
{
    public class DeleteCabinCommand(Guid cabinId) : IRequest
    {
        public Guid CabinId { get; set; } = cabinId;
    }
}
