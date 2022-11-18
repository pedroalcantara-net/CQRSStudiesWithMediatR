using ColdQuackRealSystem.Base;
using ColdQuackRealSystem.DataAccess;
using ColdQuackRealSystem.Domain.Entities;
using ColdQuackRealSystem.Repository.Interface;

namespace ColdQuackRealSystem.Repository
{
    public class FrozenDuckRepository : BaseRepository<FrozenDuck>, IFrozenDuckRepository
    {
        public FrozenDuckRepository(ColdQuackContext db) : base(db)
        {
        }
    }
}
