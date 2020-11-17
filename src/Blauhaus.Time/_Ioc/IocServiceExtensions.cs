using Blauhaus.Ioc.Abstractions;
using Blauhaus.Time.Abstractions;

namespace Blauhaus.Time._Ioc
{
    public static class IocServiceExtensions
    {
        public static IIocService AddTimeService(this IIocService iocService)
        {
            iocService.RegisterImplementation<ITimeService, TimeService>();
            return iocService;
        }
    }
}