using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.RespositroyContracts
{
    /// <summary>
    /// Defines a contract for retrieving application settings asynchronously.
    /// </summary>
    public interface ISettingsRepository
    {
        Task<IEnumerable<Setting>> GetAllSettingsAsync (CancellationToken cancellationToken = default);
    }
}
