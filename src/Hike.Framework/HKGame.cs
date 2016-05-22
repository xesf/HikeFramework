using System;
using Hike.Framework.Platform;
using Hike.Framework.System;

namespace Hike.Framework
{
    /// <summary>
    /// Hike Framework Game class
    /// Extend this class to create a new game with Hike Framework default options
    /// </summary>
    public abstract class HKGame : IDisposable
    {
        protected string _title = "Hike Framework";
        protected int _screenWidth; /** desire screen width */
        protected int _screenHeight; /** desire screen height */

        private HKGameXna _xnaGame;
        public HKGameXna XnaGame { get { return _xnaGame; } set { _xnaGame = value; RegisterEvents(); } }

        public HKGame()
        { }

        public virtual void BeginRun()
        { }

        public virtual void Initialise()
        { }

        public virtual void LoadContent()
        { }

        public virtual void UnloadContent()
        { }

        public virtual void BeginUpdate()
        { }

        public virtual void Update(HKGameTime gameTime)
        { }

        public virtual void EndUpdate()
        { }

        public virtual void BeginDraw()
        { }

        public virtual void Draw(HKGameTime gameTime)
        { }

        public virtual void EndDraw()
        { }

        public virtual void EndRun()
        { }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void RegisterEvents()
        {
            var innerGame = XnaGame;

            innerGame.OnInitialise += () =>
            {
                Initialise();
            };

            innerGame.OnLoadContent += () =>
            {
                LoadContent();
            };

            innerGame.OnUnloadContent += () =>
            {
                UnloadContent();
            };

            innerGame.OnBeginRun += () =>
            {
                BeginRun();
            };

            innerGame.OnUpdate += (g) =>
            {
                BeginUpdate();
                Update(g);
                EndUpdate();
            };

            innerGame.OnEndRun += () =>
            {
                EndRun();
            };

            innerGame.OnBeginDraw += () =>
            {
                BeginDraw();
            };

            innerGame.OnDraw += (g) =>
            {
                Draw(g);
            };

            innerGame.OnEndDraw += () =>
            {
                EndDraw();
            };
        }
    }
}
