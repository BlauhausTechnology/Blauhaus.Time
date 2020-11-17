﻿using Blauhaus.Time.Abstractions;
using Microsoft.Extensions.DependencyInjection;

namespace Blauhaus.Time._Ioc
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddTimeService(this IServiceCollection iocService)
        {
            iocService.AddSingleton<ITimeService, TimeService>();
            return iocService;
        }
    }
}