using Blauhaus.Time.Abstractions;
using Microsoft.Extensions.DependencyInjection;

namespace Blauhaus.Time._Ioc
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection RegisterTimeService(this IServiceCollection iocService)
        {
            iocService.AddScoped<ITimeService, TimeService>();
            return iocService;
        }
    }
}