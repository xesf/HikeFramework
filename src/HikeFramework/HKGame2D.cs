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

		public HKGame2D (IPlatformFactory platformFactory)
			: base(platformFactory)
		{
			HKGame2D.Current = this;
		}

		#region implemented abstract members of Game


		protected override void Initialize()
		{
            this._window.Initialize();
		}

		protected override void LoadContent()
		{

		}

		protected override void ProcessEvents()
		{

		}

		protected override void Update()
		{

		}

		protected override void Draw()
		{
			
		}

		#endregion
	}
}

