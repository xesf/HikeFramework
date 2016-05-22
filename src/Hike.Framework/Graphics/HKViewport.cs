﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hike.Framework.Graphics
{
    public struct HKViewport
    {
        public int X;
        public int Y;
        public int Width;
        public int Height;

        public HKViewport(int x, int y, int width, int height)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
        }
    }
}
