using Core.Bookings.Dto;
using MediatR;
using System;


namespace Core.Bookings.Queries
{
    public class GetBookingsQuery : IRequest<IEnumerable<BookingsResponseDto>>
    {
    }
}
