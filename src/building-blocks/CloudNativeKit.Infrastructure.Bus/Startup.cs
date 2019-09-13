using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using CloudNativeKit.Domain;
using CloudNativeKit.Infrastructure.Bus.Internal;

namespace CloudNativeKit.Infrastructure.Bus
{
    public static class Startup
    {
        public static IServiceCollection AddDomainEventBus(this IServiceCollection services)
        {
            services.Replace(ServiceDescriptor.Singleton<IDomainEventDispatcher, DomainEventDispatcher>());
            return services;
        }
    }
}