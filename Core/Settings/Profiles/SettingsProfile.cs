using System;
using AutoMapper;
using Core.Bookings.Dto;
using Domain.Entities;

namespace Core.Settings.Profiles
{
    public class SettingsProfile : Profile
    {
        public SettingsProfile() {
            CreateMap<Setting, SettingsResponseDto>();
        }
    }
}
