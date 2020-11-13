using System;
using System.Collections.Generic;
using Blauhaus.TestHelpers.MockBuilders;
using Blauhaus.Time.Abstractions;

namespace Blauhaus.Time.TestHelpers.MockBuilders
{
    public class TimeServiceMockBuilder : BaseMockBuilder<TimeServiceMockBuilder, ITimeService>
    {
        
        private readonly DateTime _defaultTime = DateTime.SpecifyKind(new DateTime(2020, 1, 2, 3, 4, 5), DateTimeKind.Utc);

        public TimeServiceMockBuilder()
        { 
            Reset();
        }

        public DateTime  Reset()
        {
            With(x => x.CurrentUtcOffset, new DateTimeOffset(_defaultTime));
            With(x => x.CurrentUtcTime, _defaultTime);
            return _defaultTime;
        }

        public DateTime AddSeconds(int seconds)
        {
            var newTime = _defaultTime.AddSeconds(seconds);
            With(x => x.CurrentUtcOffset, new DateTimeOffset(newTime));
            With(x => x.CurrentUtcTime, newTime);
            return newTime;
        }
        
        public TimeServiceMockBuilder Where_CurrentUtcTime_returns_sequence(List<DateTime> values)
        {
            var queue = new Queue<DateTime>(values);
            Mock.Setup(x => x.CurrentUtcTime).Returns(queue.Dequeue);
            return this;
        }
    }
}