using Domain.Entities;


namespace Domain.RespositroyContracts
{
    /// <summary>
    /// Defines methods for retrieving booking data.
    /// </summary>
    public interface IBookingsRepository
    {
        Task<IEnumerable<Booking>> GetAllBookingsAsync(CancellationToken cancellationToken = default);
    }
}
