using AutoMapper;
using ColdQuackRealSystem.Domain.DTO;
using ColdQuackRealSystem.Domain.Entities;
using ColdQuackRealSystem.Repository.Interface;
using ColdQuackRealSystem.Services.Base;
using ColdQuackRealSystem.Services.Interface;

namespace ColdQuackRealSystem.Services
{
    public class FrozenDuckService : BaseService<FrozenDuck, FrozenDuckDTO>, IFrozenDuckService
    {
        public FrozenDuckService(IFrozenDuckRepository repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
