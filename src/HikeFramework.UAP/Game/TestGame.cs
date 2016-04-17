using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using HikeFramework.Game;
using HikeFramework.Graphics;
using Windows.UI;

namespace HikeFramework.UAP.Game
{
    class TestGame : HKGame2D
    {
        public TestGame(IHKPlatformFactory platformFactory) : base(platformFactory)
        {
        }

        public override void Draw(IHKCanvas canvas)
        {
            base.Draw(canvas);

            canvas.DrawText("Hike Framework", Vector2.One * 50, Colors.Blue);
        }
    }
}
