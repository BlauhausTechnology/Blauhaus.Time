using System;
using System.Collections.Generic;
using System.Globalization;
using Blauhaus.TestHelpers.MockBuilders;
using Blauhaus.Time.Abstractions;
using Moq;

namespace Blauhaus.Time.TestHelpers.MockBuilders
{
    public class TimeServiceMockBuilder : BaseMockBuilder<TimeServiceMockBuilder, ITimeService>
    {
        
        private static readonly DateTime DefaultTime = DateTime.SpecifyKind(new DateTime(2020, 1, 2, 3, 4, 5), DateTimeKind.Utc);
        private DateTime _currentTime = DefaultTime;

        public TimeServiceMockBuilder()
        { 
            Reset();
        }

        public DateTime  Reset()
        {
            return SetMockTime(DefaultTime);
        }

        public DateTime AddSeconds(int seconds)
        {
            return SetMockTime(_currentTime.AddSeconds(seconds)); 
        }

        public DateTime SetMockTime(DateTime time)
        {
            if (time.Kind != DateTimeKind.Utc)
            {
                time = DateTime.SpecifyKind(time, DateTimeKind.Utc);
            }

            _currentTime = time;
            With(x => x.CurrentUtcOffset, new DateTimeOffset(_currentTime));
            With(x => x.CurrentUtcTime, _currentTime);
            return _currentTime;
        }
        
        public TimeServiceMockBuilder Where_CurrentUtcTime_returns_sequence(List<DateTime> values)
        {
            var queue = new Queue<DateTime>(values);
            Mock.Setup(x => x.CurrentUtcTime).Returns(queue.Dequeue);
            return this;
        }
 

    }
}