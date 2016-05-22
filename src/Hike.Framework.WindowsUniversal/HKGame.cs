using System;
using Hike.Framework.WindowsUniversal.Platform;
using Hike.Framework.WindowsUniversal.System;

namespace Hike.Framework.WindowsUniversal
{
    /// <summary>
    /// Hike Framework Game class
    /// Extend this class to create a new game with Hike Framework default options
    /// </summary>
    public partial class HKGame : IDisposable
    {
        protected string _title = "Hike Framework";
        protected int _screenWidth; /** desire screen width */
        protected int _screenHeight; /** desire screen height */

        private HKGameXna _xnaGame;
        public HKGameXna XnaGame { get { return _xnaGame; } set { _xnaGame = value; RegisterEvents(); } }

        public delegate void InitialiseHandler();
        public delegate void LoadContentHandler();
        public delegate void UnloadContentHandler();
        public delegate void BeginRunHandler();
        public delegate void UpdateHandler(HKGameTime gameTime);
        public delegate void EndRunHandler();
        public delegate void BeginDrawHandler();
        public delegate void DrawHandler(HKGameTime gameTime);
        public delegate void EndDrawHandler();

        public event InitialiseHandler OnInitialise;
        public event LoadContentHandler OnLoadContent;
        public event UnloadContentHandler OnUnloadContent;

        public event BeginRunHandler OnBeginRun;
        public event UpdateHandler OnUpdate;
        public event EndRunHandler OnEndRun;

        public event BeginDrawHandler OnBeginDraw;
        public event DrawHandler OnDraw;
        public event EndDrawHandler OnEndDraw;

        public HKGame()
        {

        }

        public void RegisterEvents()
        {
            var innerGame = XnaGame;

            innerGame.OnInitialise += () =>
            {
                OnInitialise?.Invoke();
            };

            innerGame.OnLoadContent += () =>
            {
                OnLoadContent?.Invoke();
            };

            innerGame.OnUnloadContent += () =>
            {
                OnUnloadContent?.Invoke();
            };

            innerGame.OnBeginRun += () =>
            {
                OnBeginRun?.Invoke();
            };

            innerGame.OnUpdate += (g) =>
            {
                OnUpdate?.Invoke(g);
            };

            innerGame.OnEndRun += () =>
            {
                OnEndRun?.Invoke();
            };

            innerGame.OnBeginDraw += () =>
            {
                OnBeginDraw?.Invoke();
            };

            innerGame.OnDraw += (g) =>
            {
                OnDraw?.Invoke(g);
            };

            innerGame.OnEndDraw += () =>
            {
                OnEndDraw?.Invoke();
            };
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
