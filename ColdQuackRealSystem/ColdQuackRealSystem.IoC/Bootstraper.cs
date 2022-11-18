using ColdQuackRealSystem.IoC.Modules;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace ColdQuackRealSystem.IoC
{
    public class Bootstraper
    {
        public static void RegisterServices(IServiceCollection container)
        {

            RepositoryModule.SetModules(container);
            ServiceModule.SetModules(container);
            container.AddMediatR(Assembly.GetExecutingAssembly());
        }
    }
}
