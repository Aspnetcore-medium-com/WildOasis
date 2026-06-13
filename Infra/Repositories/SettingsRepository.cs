using Domain.Entities;
using Domain.RespositroyContracts;
using Microsoft.EntityFrameworkCore;


namespace Infra.Repositories
{
    /// <summary>
    ///     
    /// </summary>
    /// <param name="applicationDBContext"></param>
    public class SettingsRepository(ApplicationDBContext applicationDBContext) : ISettingsRepository
    {
        public async Task<Setting> GetAllSettingsAsync(CancellationToken cancellationToken = default)
        {
            Setting settings = await applicationDBContext.Settings.FirstOrDefaultAsync(cancellationToken);
            return settings;
        }
    }
}
