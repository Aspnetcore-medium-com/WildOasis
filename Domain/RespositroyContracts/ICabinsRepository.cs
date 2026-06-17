using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.RespositroyContracts
{
    /// <summary>
    /// 
    /// </summary>
    public interface ICabinsRepository
    {
        Task<IEnumerable<Cabin>> GetAllCabinsAsync(CancellationToken cancellationToken = default);

        Task<bool> CabinsExists(Guid cabinId, CancellationToken cancellationToken = default);

        Task<bool> DeleteCabin(Guid cabinId, CancellationToken cancellationToken = default);

        Task<Cabin?> GetCabinByIdAsync(Guid guid, CancellationToken cancellationToken = default);

    }
}
