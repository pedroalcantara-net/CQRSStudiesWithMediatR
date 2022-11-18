using ColdQuackRealSystem.Repository;
using ColdQuackRealSystem.Repository.Interface;
using Microsoft.Extensions.DependencyInjection;

namespace ColdQuackRealSystem.IoC.Modules
{
    public class RepositoryModule
    {
        public static void SetModules(IServiceCollection container)
        {
            container.AddScoped<IFrozenDuckRepository, FrozenDuckRepository>();
        }
    }
}
