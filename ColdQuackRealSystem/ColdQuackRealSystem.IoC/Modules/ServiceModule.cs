using ColdQuackRealSystem.Services;
using ColdQuackRealSystem.Services.Interface;
using Microsoft.Extensions.DependencyInjection;

namespace ColdQuackRealSystem.IoC.Modules
{
    public class ServiceModule
    {
        public static void SetModules(IServiceCollection container)
        {
            container.AddScoped<IFrozenDuckService, FrozenDuckService>();
        }
    }
}
