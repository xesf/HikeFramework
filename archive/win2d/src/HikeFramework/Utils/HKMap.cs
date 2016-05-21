using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HikeFramework.Utils
{
    public static class HKMap
    {
        public static T ParseEnum<T,U>(U value)
        {
            return (T)Enum.Parse(typeof(T), value.ToString());
        }
    }
}
