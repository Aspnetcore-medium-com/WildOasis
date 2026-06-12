using Domain.Entities;
using Domain.RespositroyContracts;
using Microsoft.EntityFrameworkCore;


namespace Infra.Repositories
{
    /// <summary>
    /// Provides data access operations for guest entities.
    /// </summary>
    /// <param name="applicationDBContext">The database context for accessing guest data.</param>
    public class GuestsRepository (ApplicationDBContext applicationDBContext) : IGuestsRepository
    {
        public async Task<IEnumerable<Guest>> GetAllGuestsAsync(CancellationToken cancellationToken = default)
        {
            IEnumerable<Guest> guests = await applicationDBContext.Guests.ToListAsync(cancellationToken);
            return guests;
        }
    }
}
