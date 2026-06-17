using AutoMapper;
using Core.Bookings.Dto;
using Domain.RespositroyContracts;
using MediatR;
using Microsoft.Extensions.Logging;


namespace Core.Settings.Queries
{
    public class GetAllSettingsQueryHandler(ILogger<GetAllSettingsQueryHandler> logger, ISettingsRepository settingsRepository,IMapper mapper) : IRequestHandler<GetAllSettingsQuery, SettingsResponseDto>
    {
        public async Task<SettingsResponseDto> Handle(GetAllSettingsQuery request, CancellationToken cancellationToken)
        {
            logger.LogInformation("get all settins {Function}", nameof(Handle));
            var response = await settingsRepository.GetAllSettingsAsync(cancellationToken);
            SettingsResponseDto settings =  mapper.Map<SettingsResponseDto>(response);
            return settings;

        }
      
    }
}
