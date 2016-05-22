using System;

namespace Hike.Framework.System
{
    public class HKGameTime
    {
        public TimeSpan TotalGameTime { get; set; }

        public TimeSpan ElapsedGameTime { get; set; }

        public bool IsRunningSlowly { get; set; }

        public HKGameTime()
        {
            TotalGameTime = TimeSpan.Zero;
            ElapsedGameTime = TimeSpan.Zero;
            IsRunningSlowly = false;
        }

        public HKGameTime(TimeSpan totalGameTime, TimeSpan elapsedGameTime)
        {
            TotalGameTime = totalGameTime;
            ElapsedGameTime = elapsedGameTime;
            IsRunningSlowly = false;
        }

        public HKGameTime(TimeSpan totalRealTime, TimeSpan elapsedRealTime, bool isRunningSlowly)
        {
            TotalGameTime = totalRealTime;
            ElapsedGameTime = elapsedRealTime;
            IsRunningSlowly = isRunningSlowly;
        }
    }
}
