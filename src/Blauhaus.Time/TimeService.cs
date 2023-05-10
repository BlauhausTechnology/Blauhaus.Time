using System;
using System.Globalization;
using Blauhaus.Time.Abstractions;

namespace Blauhaus.Time
{
    public class TimeService : ITimeService
    {
        public long CurrentUtcTimestampMs => DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
        public DateTime CurrentUtcTime => DateTime.UtcNow;
        public DateTimeOffset CurrentUtcOffset => DateTimeOffset.UtcNow;
        
        public DateTime CurrentLocalTime => DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Local);
        
        
        public DateTime ToLocalTime(DateTimeOffset dateTimeOffset)
        {
            return dateTimeOffset.LocalDateTime;
        }
        public DateTime ToLocalTime(DateTime dateTime)
        {
            return dateTime.ToLocalTime();
        }
    }
}