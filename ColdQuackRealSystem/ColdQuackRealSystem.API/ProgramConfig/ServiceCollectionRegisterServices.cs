using ColdQuackRealSystem.AutoMapper;
using ColdQuackRealSystem.Commands.FrozenDuck;
using ColdQuackRealSystem.IoC;
using ColdQuackRealSystem.Queries.FrozenDuck;
using MediatR;

namespace ColdQuackRealSystem.API.ProgramConfig
{
    public static class ServiceCollectionRegisterServices
    {
        public static IServiceCollection StartRegisterServices(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(BootstraperAutoMapper).Assembly);

            // Ioc 
            Bootstraper.RegisterServices(services);

            services.AddMediatR(typeof(GetFrozenDuckQuery).Assembly);
            services.AddMediatR(typeof(CreateFrozenDuckCommand).Assembly);

            return services;
        }
    }
}
