using Core.Bookings.Dto;
using MediatR;
using System;


namespace Core.Cabins.Queries.GetAll
{
    public class GetAllCabinsQuery : IRequest<IEnumerable<CabinResponseDto>>
    {
    }
}
