using AutoMapper;
using Core.Bookings.Dto;
using Domain.RespositroyContracts;
using MediatR;
using Microsoft.Extensions.Logging;
using System;

namespace Core.Cabins.Queries
{
    public class GetAllCabinsQueryHandler(ILogger<GetAllCabinsQueryHandler> logger,ICabinsRepository cabinsRepository, IMapper mapper) : IRequestHandler<GetAllCabinsQuery, IEnumerable<CabinResponseDto>>
    {
        public async Task<IEnumerable<CabinResponseDto>> Handle(GetAllCabinsQuery request, CancellationToken cancellationToken)
        {
            logger.LogInformation("Get all cabins query {Function}", nameof(Handle));
            var response = await cabinsRepository.GetAllCabinsAsync(cancellationToken);
            IEnumerable<CabinResponseDto> cabins = mapper.Map<IEnumerable<CabinResponseDto>>(response);
            logger.LogInformation("Get Cabins count {Count}", cabins.Count());
            return cabins;
        }
    }
}
