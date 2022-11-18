using ColdQuackRealSystem.Domain.DTO;
using ColdQuackRealSystem.Services.Interface;
using MediatR;

namespace ColdQuackRealSystem.Queries.FrozenDuck
{
    public record GetFrozenDuckQuery : IRequest<List<FrozenDuckDTO>>
    {
        public string? Breed { get; init; }
    }

    public class GetFrozenDuckQueryHandler : IRequestHandler<GetFrozenDuckQuery, List<FrozenDuckDTO>>
    {
        private readonly IFrozenDuckService _service;
        public GetFrozenDuckQueryHandler(IFrozenDuckService service)
        {
            _service = service;
        }

        public async Task<List<FrozenDuckDTO>> Handle(GetFrozenDuckQuery request, CancellationToken cancellationToken)
        {
            return _service.GetAllRecords().Where(duck => String.IsNullOrWhiteSpace(request.Breed) || duck.Breed == request.Breed).ToList();
        }
    }
}
