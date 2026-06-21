using AutoMapper;
using Core.ServiceContracts;
using Domain.Entities;
using Domain.RespositroyContracts;
using MediatR;
using Microsoft.Extensions.Logging;

namespace Core.Cabins.Commands.Create
{
    public class CreateCabinCommandHandler(ILogger<CreateCabinCommandHandler> logger,IBlobStorageService blobStorageService, ICabinsRepository cabinsRepository,IMapper mapper) : IRequestHandler<CreateCabinCommand, Guid>
    {
        public async Task<Guid> Handle(CreateCabinCommand request, CancellationToken cancellationToken)
        {
            logger.LogInformation("Creat cabin request");
            var cabin = mapper.Map<Cabin>(request);
            var fileName = await blobStorageService.UploadBlobAsync(request.Image, cancellationToken);
            cabin.Id = Guid.NewGuid();
            cabin.Image = fileName;
            await cabinsRepository.CreateCabinAsync(cabin, cancellationToken);
            return cabin.Id;
        }
    }
}
