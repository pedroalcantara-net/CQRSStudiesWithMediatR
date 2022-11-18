using ColdQuackRealSystem.Domain.DTO;
using ColdQuackRealSystem.Domain.Entities;

namespace ColdQuackRealSystem.AutoMapper.Profiles
{
    public class CoreEntities : global::AutoMapper.Profile
    {
        public CoreEntities()
        {
            CreateMap<FrozenDuck, FrozenDuckDTO>().ReverseMap();
        }
    }
}
