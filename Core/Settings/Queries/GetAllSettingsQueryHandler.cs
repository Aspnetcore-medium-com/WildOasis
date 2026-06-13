using AutoMapper;
using Core.Bookings.Dto;
using Domain.RespositroyContracts;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;

;

namespace Core.Settings.Queries
{
    public class GetAllSettingsQueryHandler(ILogger<GetAllSettingsQueryHandler> logger, ISettingsRepository settingsRepository,IMapper mapper) : IRequestHandler<GetAllSettingsQuery, IEnumerable<SettingsResponseDto>>
    {
        public async Task<IEnumerable<SettingsResponseDto>> Handle(GetAllSettingsQuery request, CancellationToken cancellationToken)
        {
            logger.LogInformation("get all settins {Function}", nameof(Handle));
            var response = await settingsRepository.GetAllSettingsAsync(cancellationToken);
            IEnumerable<SettingsResponseDto> settings =  mapper.Map<IEnumerable< SettingsResponseDto>>(response);
            logger.LogInformation("settings count is {Count}",settings.Count());    
            return settings;

        }
    }
}
