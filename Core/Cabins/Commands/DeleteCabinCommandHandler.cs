using Domain.RespositroyContracts;
using MediatR;
using Microsoft.Extensions.Logging;


namespace Core.Cabins.Commands
{
    public class DeleteCabinCommandHandler(ILogger<DeleteCabinCommandHandler> logger, ICabinsRepository cabinsRepository) : IRequestHandler<DeleteCabinCommand>
    {
        public async Task Handle(DeleteCabinCommand request, CancellationToken cancellationToken)
        {
            logger.LogInformation("Delete {CabinId} in {Function}", request.CabinId, nameof(Handle));
            var cabin = await cabinsRepository.GetCabinByIdAsync(request.CabinId);
            if (cabin == null) { throw new KeyNotFoundException("Cabin - Not found Exception"); }
            var deleted = await cabinsRepository.DeleteCabin(cabin.Id, cancellationToken);
            if (!deleted)
            {
                throw new KeyNotFoundException("Cabin - delete failed");
            }
        }
    }
}
