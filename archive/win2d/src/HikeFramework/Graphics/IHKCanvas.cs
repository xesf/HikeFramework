using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;

namespace HikeFramework.Graphics
{
    public interface IHKCanvas
    {
        void Clear(Color color);

        void DrawText(string text, Vector2 point, Color color);
        void DrawText(string text, float x, float y, Color color);
    }
}
