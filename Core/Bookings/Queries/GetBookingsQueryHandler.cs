using AutoMapper;
using Core.Bookings.Dto;
using Domain.RespositroyContracts;
using MediatR;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Reflection.Metadata;

namespace Core.Bookings.Queries
{
    public class GetBookingsQueryHandler(IBookingsRepository bookingsRepository, ILogger<GetBookingsQueryHandler> logger, IMapper mapper) : IRequestHandler<GetBookingsQuery, IEnumerable<BookingsResponseDto>>
    {
        public async Task<IEnumerable<BookingsResponseDto>> Handle(GetBookingsQuery request, CancellationToken cancellationToken)
        {
            logger.LogInformation("Get all bookings {Function}", nameof(Handle));
            var bookings = await bookingsRepository.GetAllBookingsAsync(cancellationToken);
            logger.LogInformation("Bookind  count {Bookings}", bookings.Count());
            IEnumerable<BookingsResponseDto> response = mapper.Map<IEnumerable<BookingsResponseDto>>(bookings);
            return response;
        }


    }
}
