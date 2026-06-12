using Domain.Entities;
using Domain.RespositroyContracts;
using Microsoft.EntityFrameworkCore;


namespace Infra.Repositories
{
    /// <summary>
    /// Provides data access operations for bookings using the application database context.
    /// </summary>
    /// <param name="applicationDBContext">The database context for accessing bookings data.</param>
    public class BookingsRepository(ApplicationDBContext applicationDBContext) : IBookingsRepository 
    {
        public async Task<IEnumerable<Booking>> GetAllBookingsAsync(CancellationToken cancellationToken = default)
        {
            IEnumerable<Booking> bookings  = await applicationDBContext.Bookings.Include(x => x.Cabin).Include(y => y.Guest).ToListAsync(cancellationToken);
            return bookings;
        }

       
    }
}
