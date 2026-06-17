using AutoMapper;
using Core.Bookings.Dto;
using Domain.Options;
using Domain.RespositroyContracts;
using MediatR;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;

namespace Core.Cabins.Queries
{
    public class GetAllCabinsQueryHandler(ILogger<GetAllCabinsQueryHandler> logger,ICabinsRepository cabinsRepository, IMapper mapper, IOptions<StorageOptions> options) : IRequestHandler<GetAllCabinsQuery, IEnumerable<CabinResponseDto>>
    {
        public async Task<IEnumerable<CabinResponseDto>> Handle(GetAllCabinsQuery request, CancellationToken cancellationToken)
        {
            logger.LogInformation("Get all cabins query {Function}", nameof(Handle));
            var response = await cabinsRepository.GetAllCabinsAsync(cancellationToken);
            IEnumerable<CabinResponseDto> cabins = mapper.Map<IEnumerable<CabinResponseDto>>(response);
            foreach ( var cabin in cabins)
            {
                cabin.Image = options.Value.BaseUrl + '/' + cabin.Image;
            }
            logger.LogInformation("Get Cabins count {Count}", cabins.Count());
            return cabins;
        }
    }
}
