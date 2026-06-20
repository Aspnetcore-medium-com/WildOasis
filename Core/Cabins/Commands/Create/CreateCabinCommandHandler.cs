using MediatR;

namespace Core.Cabins.Commands.Create
{
    public class CreateCabinCommandHandler : IRequestHandler<CreateCabinCommand, Guid>
    {
        public Task<Guid> Handle(CreateCabinCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
