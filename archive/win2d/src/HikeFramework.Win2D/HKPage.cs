using HikeFramework.Common;
using HikeFramework.Game;
using HikeFramework.Win2D.Graphics;
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

        public HKPage(HKGame2D game)
        {
            _game = game;
            _canvas = new CanvasAnimatedControl();

            _canvas.CreateResources += (s,a) => {
                _game.LoadContent();
            };

            _canvas.GameLoopStarting += (s, a) => {

            };

            _canvas.GameLoopStopped += (s, a) => {

            };

            _canvas.Update += (s, a) => {

                var gameTime = new HKGameTime {
                    ElapsedTime = a.Timing.ElapsedTime,
                    IsRunningSlowly = a.Timing.IsRunningSlowly,
                    TotalTime = a.Timing.TotalTime,
                    UpdateCount = a.Timing.UpdateCount
                };

                _game.Update(gameTime); 
            };

            _canvas.Draw += (s, a) => {
                var drawingSession = new HKWin2DCanvas(a.DrawingSession);
                _game.Draw(drawingSession);
            };

            _canvas.SizeChanged += (s, a) => {

            };
        }
    }
}
