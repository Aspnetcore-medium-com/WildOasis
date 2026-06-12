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
        
        public async Task<IEnumerable<Cabin>> GetAllCabinsAsync(CancellationToken cancellationToken = default)
        {
            IEnumerable<Cabin> cabins = await applicationDBContext.Cabins.ToListAsync(cancellationToken);
            return cabins;
        }
    }
}
