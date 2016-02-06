using System;
using HikeFramework.Core;

namespace HikeFramework
{
	public interface IHKPlatformFactory
	{
		HKWindow CreateWindow(string title, int width, int height, bool fullscreen);
        HKFileStream CreateFileStream { get; }
    }
}
