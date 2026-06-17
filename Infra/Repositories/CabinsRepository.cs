using Domain.Entities;
using Domain.RespositroyContracts;
using Microsoft.EntityFrameworkCore;


namespace Infra.Repositories
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="applicationDBContext"></param>
    public class CabinsRepository(ApplicationDBContext applicationDBContext) : ICabinsRepository
    {
        
        public async Task<bool> CabinsExists(Guid cabinId, CancellationToken cancellationToken = default)
        {
            var result = await applicationDBContext.Cabins.AnyAsync((c) => c.Id == cabinId,cancellationToken);
            return result;
        }

        public async Task<bool> DeleteCabin(Guid cabinId, CancellationToken cancellationToken = default)
        {

            var cabin = await GetCabinByIdAsync(cabinId);
            if (cabin == null)
            {
                return false;
            }

     
            applicationDBContext.Cabins.Remove(cabin);
            await applicationDBContext.SaveChangesAsync();
            return true;
            
        }

        public async Task<IEnumerable<Cabin>> GetAllCabinsAsync(CancellationToken cancellationToken = default)
        {
            IEnumerable<Cabin> cabins = await applicationDBContext.Cabins.ToListAsync(cancellationToken);
            return cabins;
        }

        public async Task<Cabin?> GetCabinByIdAsync(Guid guid, CancellationToken cancellationToken = default)
        {
            var cabin = await applicationDBContext.Cabins.FirstOrDefaultAsync(c => c.Id == guid,cancellationToken);
            return cabin;
        }
    }
}
