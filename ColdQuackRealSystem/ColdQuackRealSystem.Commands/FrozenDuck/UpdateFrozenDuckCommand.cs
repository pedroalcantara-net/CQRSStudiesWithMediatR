using ColdQuackRealSystem.Domain.DTO;
using ColdQuackRealSystem.Services.Interface;
using MediatR;

namespace ColdQuackRealSystem.Commands.FrozenDuck
{
    public record UpdateFrozenDuckCommand : IRequest
    {
        public int Id { get; init; }
        public string Breed { get; init; }
        public decimal Price { get; init; }
    }

    public class UpdateFrozenDuckCommandHandler : IRequestHandler<UpdateFrozenDuckCommand>
    {
        private readonly IFrozenDuckService _service;
        public UpdateFrozenDuckCommandHandler(IFrozenDuckService service)
        {
            _service = service;
        }

        public async Task<Unit> Handle(UpdateFrozenDuckCommand request, CancellationToken cancellationToken)
        {
            var entity = new FrozenDuckDTO(request.Id, request.Breed, request.Price);

            _service.UpdateRecord(entity);

            return Unit.Value;
        }
    }
}
