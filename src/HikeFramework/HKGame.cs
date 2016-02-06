using System;
using HikeFramework.Common;
using HikeFramework.Core;

namespace HikeFramework
{
	public abstract class HKGame : HKCoreObject
	{
		protected bool _exiting = false;
		
		protected string _title = "Hike Framework";
		protected int _screenWidth; /** desire screen width */
		protected int _screenHeight; /** desire screen height */
		
		protected IHKWindow _window;
		protected IPlatformFactory _platformFactory;

		public HKGame (IPlatformFactory platformFactory)
		{
			this._platformFactory = platformFactory;
		}

		public IHKWindow Window { get { return _window; } }

		/** Initialize systems */
		protected abstract void Initialize();

		/** Loading contents */
		protected abstract void LoadContent();

		/** Handle system events */
		protected abstract void ProcessEvents();

		/** main loop update */
		protected abstract void Update();

		/** main loop render */
		protected abstract void Draw();

		public virtual bool CanQuit() {
			// TODO for platforms like Android and iOS this flag should be false
			// Quit is done by the system it self
			return true;
		}
	}
}
