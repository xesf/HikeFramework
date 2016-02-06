using HikeFramework.Win2D.Platform;
using Microsoft.Graphics.Canvas.UI.Xaml;

namespace HikeFramework.Win2D
{
    /// <summary>
    /// XAML Hike Framework Page with Win2D implementation
    /// </summary>
    public class HKPage
    {
        HKGame2D _game;
        CanvasAnimatedControl _canvas;

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
                _game.Draw();
            };

            _canvas.SizeChanged += (s, a) => {

            };
        }
    }
}
