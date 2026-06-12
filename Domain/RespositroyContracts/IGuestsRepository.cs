using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.RespositroyContracts
{
    /// <summary>
    /// Defines methods for retrieving guest information from a data source asynchronously.
    /// </summary>
    public interface IGuestsRepository
    {
        Task<IEnumerable<Guest>> GetAllGuestsAsync(CancellationToken cancellationToken = default);
    }
}
