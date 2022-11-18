using ColdQuackRealSystem.Domain.DTO;
using ColdQuackRealSystem.Services.Interface;
using MediatR;

namespace ColdQuackRealSystem.Commands.FrozenDuck
{
    public record CreateFrozenDuckCommand : IRequest
    {
        public int Id { get; init; }
        public string Breed { get; init; }
        public decimal Price { get; init; }
    }

    public class CreateFrozenDuckCommandHandler : IRequestHandler<CreateFrozenDuckCommand>
    {
        private readonly IFrozenDuckService _service;
        public CreateFrozenDuckCommandHandler(IFrozenDuckService service)
        {
            _service = service;
        }

        public async Task<Unit> Handle(CreateFrozenDuckCommand request, CancellationToken cancellationToken)
        {
            var entity = new FrozenDuckDTO(request.Id, request.Breed, request.Price);

            _service.InsertRecord(entity);

            return Unit.Value;
        }
    }
}
