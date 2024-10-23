using EstudosApi.Services;
using Microsoft.Extensions.DependencyModel;
using Scrutor;
using System.Reflection;

namespace EstudosApi.Configuration
{
    public static class DepedencyInjection
    {
        public static IServiceCollection AddClassesMatchingInterfaces(this IServiceCollection services)
        {

            services.Scan(scan => scan.FromAssemblyOf<IService>()
            .AddClasses(classes => classes.AssignableTo<IService>())
            .AsImplementedInterfaces()
            .WithScopedLifetime());

            return services;
        }
    }
}
