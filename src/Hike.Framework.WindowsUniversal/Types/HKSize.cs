using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hike.Framework.WindowsUniversal.Types
{
    public struct HKSize
    {
        public float Width;
        public float Height;

        public static readonly HKSize Zero = new HKSize(0, 0);
        public static readonly HKSize One = new HKSize(1, 1);

        public HKSize(float width, float height)
        {
            Width = width;
            Height = height;
        }
    }
}
