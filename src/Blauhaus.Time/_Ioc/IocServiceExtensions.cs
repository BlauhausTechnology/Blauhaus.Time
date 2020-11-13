using Blauhaus.Ioc.Abstractions;
using Blauhaus.Time.Service;

namespace Blauhaus.Time._Ioc
{
    public static class IocServiceExtensions
    {
        public static IIocService RegisterTimeService(this IIocService iocService)
        {
            iocService.RegisterImplementation<ITimeService, TimeService>();
            return iocService;
        }
    }
}