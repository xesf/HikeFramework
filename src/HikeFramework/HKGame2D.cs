using System;
using System.Threading;
using HikeFramework.Core;

namespace HikeFramework
{
	public class HKGame2D : HKGame
	{
		private static HKGame2D _instance = null;
		public static HKGame2D Current
		{
			set { _instance = value; }
			get { return _instance; }
		}

		public HKGame2D (IHKPlatformFactory platformFactory)
			: base(platformFactory)
		{
			HKGame2D.Current = this;
		}

        #region implemented abstract members of Game


        public override void Initialize()
		{
            this._window.Initialize();
		}

        public override void LoadContent()
		{

		}

        public override void ProcessEvents()
		{

		}

        public override void Update()
		{

		}

        public override void Draw()
		{
			
		}

		#endregion
	}
}

