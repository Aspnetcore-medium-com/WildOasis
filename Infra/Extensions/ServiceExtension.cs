using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace Infra.Extensions
{
    public static class ServiceExtension
    {
        public static IServiceCollection AddInfra(this IServiceCollection services,IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDBContext>(options => options.UseSqlServer(configuration.GetConnectionString("DB"), sql => sql.MigrationsAssembly(typeof(ApplicationDBContext).Assembly.FullName)));
            return services;
        }
    }
}
