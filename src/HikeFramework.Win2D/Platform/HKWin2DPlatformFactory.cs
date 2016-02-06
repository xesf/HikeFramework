using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HikeFramework.Core;

namespace HikeFramework.Win2D.Platform
{
    public class HKWin2DPlatformFactory : IHKPlatformFactory
    {
        public HKFileStream CreateFileStream
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public HKWindow CreateWindow(string title, int width, int height, bool fullscreen)
        {
            throw new NotImplementedException();
        }
    }
}
