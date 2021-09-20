using System;
using System.Globalization;

namespace Blauhaus.Time.Abstractions
{
    public interface ITimeService
    {
        long CurrentUtcTimestampMs{ get; }
        DateTime CurrentUtcTime { get; }
        DateTimeOffset CurrentUtcOffset { get; }
        DateTime CurrentLocalTime { get; }
         
    }
}