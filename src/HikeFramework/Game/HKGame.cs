using System;
using HikeFramework.Common;
using HikeFramework.Core;
using HikeFramework.Graphics;

namespace HikeFramework.Game
{
	public abstract class HKGame : HKCoreObject
	{
		protected bool _exiting = false;
		
		protected string _title = "Hike Framework";
		protected int _screenWidth; /** desire screen width */
		protected int _screenHeight; /** desire screen height */
		
		protected IHKWindow _window;
		protected IHKPlatformFactory _platformFactory;

		public HKGame (IHKPlatformFactory platformFactory)
		{
			this._platformFactory = platformFactory;
		}

		public IHKWindow Window { get { return _window; } }

		/** Initialize systems */
		public abstract void Initialize();

        /** Loading contents */
        public abstract void LoadContent();

        /** Handle system events */
        public abstract void ProcessEvents();

        /** main loop update */
        public abstract void Update(HKGameTime gameTime);

        /** main loop render */
        public abstract void Draw(IHKCanvas canvas);

		public virtual bool CanQuit() {
			// TODO for platforms like Android and iOS this flag should be false
			// Quit is done by the system it self
			return true;
		}
	}
}
