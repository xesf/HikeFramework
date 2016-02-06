using System;
using HikeFramework.Core;

namespace HikeFramework
{
	public interface IPlatformFactory
	{
		HKWindow CreateWindow(string title, int width, int height, bool fullscreen);
		HKFileStream CreateFileStream();
	}
}
