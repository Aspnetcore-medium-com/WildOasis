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
        public async Task<IEnumerable<Setting>> GetAllSettingsAsync(CancellationToken cancellationToken = default)
        {
            IEnumerable<Setting> settings = await applicationDBContext.Settings.ToListAsync(cancellationToken);
            return settings;
        }
    }
}
