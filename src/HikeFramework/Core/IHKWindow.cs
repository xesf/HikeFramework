using System;

namespace HikeFramework.Core
{
	public interface IHKWindow
	{
		string Title { get; set; }

		int Width { get; set; }
		int Height { get; set; }

		bool IsFullScreen { get; set; }

		void Initialize();
		void ProcessEvents();
	}
}

