using HikeFramework.Common;
using HikeFramework.Win2D.Platform;
using Microsoft.Graphics.Canvas.UI.Xaml;
using Windows.UI;

namespace HikeFramework.Win2D
{
    /// <summary>
    /// XAML Hike Framework Page with Win2D implementation
    /// </summary>
    public class HKPage : HKCoreObject
    {
        protected HKGame2D _game = null;
        protected CanvasAnimatedControl _canvas = null;

        public CanvasAnimatedControl Canvas { get { return _canvas;  } }

        public HKPage()
        {
            var win2DPlatform = new HKWin2DPlatformFactory();

            _game = new HKGame2D(win2DPlatform);
            _canvas = new CanvasAnimatedControl();

            _canvas.CreateResources += (s,a) => {
                _game.LoadContent();
            };

            _canvas.GameLoopStarting += (s, a) => {

            };

            _canvas.GameLoopStopped += (s, a) => {

            };

            _canvas.Update += (s, a) => {
                _game.Update();
            };

            _canvas.Draw += (s, a) => {
                a.DrawingSession.Clear(Colors.Blue);
                _game.Draw();
            };

            _canvas.SizeChanged += (s, a) => {

            };
        }
    }
}
