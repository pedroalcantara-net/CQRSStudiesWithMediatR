using ColdQuackRealSystem.Domain.DTO;
using ColdQuackRealSystem.Services.Interface;
using MediatR;

namespace ColdQuackRealSystem.Commands.FrozenDuck
{
    public record DeleteFrozenDuckCommand : IRequest
    {
        public int Id { get; init; }
        public string Breed { get; init; }
        public decimal Price { get; init; }
    }

    public class DeleteFrozenDuckCommandHandler : IRequestHandler<DeleteFrozenDuckCommand>
    {
        private readonly IFrozenDuckService _service;
        public DeleteFrozenDuckCommandHandler(IFrozenDuckService service)
        {
            _service = service;
        }

        public async Task<Unit> Handle(DeleteFrozenDuckCommand request, CancellationToken cancellationToken)
        {
            var entity = new FrozenDuckDTO(request.Id, request.Breed, request.Price);

            _service.RemoveRecord(entity);

            return Unit.Value;
        }
    }
}
