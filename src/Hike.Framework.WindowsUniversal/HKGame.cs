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
        private HKGameXna _xnaGame;
        public HKGameXna XnaGame { get { return _xnaGame; } set { _xnaGame = value; } }

        public HKGame()
        { }
        
        protected string _title = "Hike Framework";
        protected int _screenWidth; /** desire screen width */
        protected int _screenHeight; /** desire screen height */

        /** Initialize systems */
        public virtual void Initialize()
        { }

        /** Loading contents */
        public virtual void LoadContent()
        { }

        /** Handle system events */
        public virtual void ProcessEvents()
        { }

        /** main loop update */
        public virtual void Update(HKGameTime gameTime)
        { }

        /** main loop render */
        public virtual void Draw()
        { }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
