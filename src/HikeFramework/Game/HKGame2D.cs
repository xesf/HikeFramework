using System;
using System.Numerics;
using System.Threading;
using HikeFramework.Core;
using HikeFramework.Graphics;
using Windows.UI;

namespace HikeFramework.Game
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

        public override void Update(HKGameTime gameTime)
		{

		}

        public override void Draw(IHKCanvas canvas)
		{
            canvas.Clear(Colors.DarkGray);

            canvas.DrawText("Hike Framework", Vector2.One * 50, Colors.Black);
		}

		#endregion
	}
}

