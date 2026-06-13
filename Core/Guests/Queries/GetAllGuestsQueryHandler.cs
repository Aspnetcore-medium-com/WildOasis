using AutoMapper;
using Core.Bookings.Dto;
using Domain.Entities;
using Domain.RespositroyContracts;
using Microsoft.Extensions.Logging;


namespace Core.Guests.Queries
{
    public class GetAllGuestsQueryHandler(IMapper mapper, IGuestsRepository guestsRepository ,ILogger<GetAllGuestsQuery> logger) : IRequestHandler<GetAllGuestsQuery, IEnumerable<GuestsResponseDto>>
    {
        public async Task<IEnumerable<GuestsResponseDto>> Handle(GetAllGuestsQuery request, CancellationToken cancellationToken)
        {
            logger.LogInformation("get all guests {Function}", nameof(Handle));
            var response =  await guestsRepository.GetAllGuestsAsync(cancellationToken);
            IEnumerable<GuestsResponseDto> guests = mapper.Map<IEnumerable<GuestsResponseDto>>(response);
            logger.LogInformation("guests response {Count}",guests.Count());    
            return guests;
        }
    }
}
