using Core.Bookings.MappingProfiles;
using Core.Cabins.Commands.Create.Validations;
using Core.Settings.Profiles;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Extensions
{
    public static class ServiceExtension
    {
        public static IServiceCollection AddCore(this IServiceCollection services)
        {
            // Explicitly add the profile
            services.AddAutoMapper(config =>
            {
                config.AddProfile<BookingsProfile>();
                config.AddProfile<CabinsProfile>();
                config.AddProfile<GuestsProfile>();
                config.AddProfile<SettingsProfile>();
            });

            services.AddMediatR(config => config.RegisterServicesFromAssembly(typeof(ServiceExtension).Assembly));

            services.AddValidatorsFromAssemblyContaining<CreateCabinCommandValidator>();

            return services;
        }
    }
}
