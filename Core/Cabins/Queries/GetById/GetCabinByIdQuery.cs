

using Core.Bookings.Dto;
using MediatR;

namespace Core.Cabins.Queries.GetById
{
    public class GetCabinByIdQuery(Guid cabinId) : IRequest<CabinResponseDto>
    {
        public Guid CabinId { get; set; } = cabinId;
    }
}
