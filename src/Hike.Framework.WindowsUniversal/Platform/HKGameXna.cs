using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Hike.Framework.WindowsUniversal.Platform
{
    public class HKGameXna : Game
    {
        GraphicsDeviceManager _graphics;
        SpriteBatch _spriteBatch;

        public event EventHandler OnLoadContent;
        public event EventHandler OnUnloadContent;

        public event EventHandler OnBeginRun;
        public event EventHandler OnUpdate;
        public event EventHandler OnEndRun;

        public event EventHandler OnBeginDraw;
        public event EventHandler OnDraw;
        public event EventHandler OnEndDraw;

        public GraphicsDeviceManager Graphics { get { return _graphics; } }
        public SpriteBatch DefaultSpriteBatch { get { return _spriteBatch; } }

        public HKGameXna()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            base.LoadContent();
            OnLoadContent?.Invoke(this, null);
        }

        protected override void UnloadContent()
        {
            OnUnloadContent?.Invoke(this, null);
            base.UnloadContent();
        }

        
        protected override void BeginRun()
        {
            base.BeginRun();
            OnBeginRun?.Invoke(this, null);
        }

        protected override void Update(GameTime gameTime)
        {
            //to avoid calling the components
            //base.Update(gameTime);

            OnUpdate?.Invoke(this, null);
        }

        protected override void EndRun()
        {
            OnEndRun?.Invoke(this, null);
            base.EndRun();
        }

        protected override bool BeginDraw()
        {
            var canBegin = base.BeginDraw();
            OnBeginDraw?.Invoke(this, null);
            return canBegin;
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            OnDraw?.Invoke(this, null);

            //to avoid calling the components
            //base.Draw(gameTime);    
        }

        protected override void EndDraw()
        {
            OnEndDraw?.Invoke(this, null);
            base.EndDraw();
        }
    }
}
