using Core.Bookings.Dto;
using MediatR;
using System;


namespace Core.Settings.Queries
{
    public class GetAllSettingsQuery : IRequest<IEnumerable<SettingsResponseDto>>
    {
    }
}
