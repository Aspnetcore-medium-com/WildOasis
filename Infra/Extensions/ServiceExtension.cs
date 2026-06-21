using Azure.Storage.Blobs;
using Core.ServiceContracts;
using Domain.RespositroyContracts;
using Infra.Repositories;
using Infra.Storage;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Azure;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace Infra.Extensions
{
    public static class ServiceExtension
    {
        public static IServiceCollection AddInfra(this IServiceCollection services,IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDBContext>(options => options.UseSqlServer(configuration.GetConnectionString("DB"), sql => sql.MigrationsAssembly(typeof(ApplicationDBContext).Assembly.FullName)));
            services.AddScoped<IBookingsRepository, BookingsRepository>();
            services.AddScoped<ICabinsRepository,CabinsRepository>();
            services.AddScoped<IGuestsRepository, GuestsRepository>();
            services.AddScoped<ISettingsRepository, SettingsRepository>();
            services.AddScoped<IBlobStorageService, BlobStorageService>();
            services.AddSingleton(sp => new BlobServiceClient(configuration.GetConnectionString("Storage")));
            return services;
        }
    }
}
