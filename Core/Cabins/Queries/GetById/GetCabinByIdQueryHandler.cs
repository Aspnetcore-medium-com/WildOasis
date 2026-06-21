using AutoMapper;
using Core.Bookings.Dto;
using Domain.Exceptions.NotFound;
using Domain.RespositroyContracts;
using MediatR;
using Microsoft.Extensions.Logging;


namespace Core.Cabins.Queries.GetById
{
    public class GetCabinByIdQueryHandler(ICabinsRepository cabinsRepository,ILogger<GetCabinByIdQueryHandler> logger,IMapper mapper) : IRequestHandler<GetCabinByIdQuery, CabinResponseDto>
    {
     
        public async Task<CabinResponseDto> Handle(GetCabinByIdQuery request, CancellationToken cancellationToken)
        {
            logger.LogInformation("Get cabin by id {CabinId}", request.CabinId);
            var cabin = await cabinsRepository.GetCabinByIdAsync(request.CabinId, cancellationToken);
            if (cabin == null) { throw new CabinNotfoundException(request.CabinId); }
            var response = mapper.Map<CabinResponseDto>(cabin);
            return response;
        }
    }
}
