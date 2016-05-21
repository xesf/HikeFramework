using System.Numerics;
using HikeFramework.Graphics;
using Microsoft.Graphics.Canvas;
using Windows.UI;

namespace HikeFramework.Win2D.Graphics
{
    public class HKWin2DCanvas : HKCanvas
    {
        protected CanvasDrawingSession _ds = null;

        public HKWin2DCanvas(CanvasDrawingSession ds)
        {
            _ds = ds;
        }

        public override void Clear(Color color)
        {
            _ds.Clear(color);
        }

        public override void DrawText(string text, Vector2 point, Color color)
        {
            _ds.DrawText(text, point, color);
        }

        public override void DrawText(string text, float x, float y, Color color)
        {
            _ds.DrawText(text, x, y, color);
        }
    }
}
