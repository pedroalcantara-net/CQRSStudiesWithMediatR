using ColdQuackRealSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ColdQuackRealSystem.DataAccess
{
    public class ColdQuackContext : DbContext
    {
        public ColdQuackContext(DbContextOptions<ColdQuackContext> options) : base(options)
        {

        }

        public DbSet<FrozenDuck> FrozenDuck { get; set; }

    }
}
