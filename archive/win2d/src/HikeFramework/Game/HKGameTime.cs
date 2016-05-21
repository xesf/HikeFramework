using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HikeFramework.Game
{
    public struct HKGameTime
    {
        //
        // Summary:
        //     Represents the amount of time, in ticks, since the last update.
        public TimeSpan ElapsedTime;
        
        // Summary:
        //     In fixed timing mode, indicates that each iteration of the game loop is taking
        //     longer than TargetElapsedTime to complete.
        public bool IsRunningSlowly;
        
        //
        // Summary:
        //     Represents the elapsed time, in ticks, for which this control has ever been running.
        public TimeSpan TotalTime;
        
        //
        // Summary:
        //     The number of times the update event has been raised.
        public long UpdateCount;
    }
}
