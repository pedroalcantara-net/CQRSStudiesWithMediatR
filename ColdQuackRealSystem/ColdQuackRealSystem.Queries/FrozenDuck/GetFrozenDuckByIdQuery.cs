using ColdQuackRealSystem.Domain.DTO;
using ColdQuackRealSystem.Services.Interface;
using MediatR;

namespace ColdQuackRealSystem.Queries.FrozenDuck
{
    public record GetFrozenDuckByIdQuery : IRequest<FrozenDuckDTO>
    {
        public int Id { get; init; }
    }

    public class GetFrozenDuckQueryByIdHandler : IRequestHandler<GetFrozenDuckByIdQuery, FrozenDuckDTO>
    {
        private readonly IFrozenDuckService _service;
        public GetFrozenDuckQueryByIdHandler(IFrozenDuckService service)
        {
            _service = service;
        }

        public async Task<FrozenDuckDTO> Handle(GetFrozenDuckByIdQuery request, CancellationToken cancellationToken)
        {
            return _service.GetRecordById(request.Id);
        }
    }
}
