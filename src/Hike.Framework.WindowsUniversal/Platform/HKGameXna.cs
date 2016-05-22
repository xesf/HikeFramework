using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hike.Framework.WindowsUniversal.System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Hike.Framework.WindowsUniversal.Platform
{
    public class HKGameXna : Game
    {
        GraphicsDeviceManager _graphics;
        SpriteBatch _spriteBatch;

        public delegate void DefaultHandler();
        public delegate void GameTimeHandler(HKGameTime gameTime);

        public event DefaultHandler OnInitialise;
        public event DefaultHandler OnLoadContent;
        public event DefaultHandler OnUnloadContent;

        public event DefaultHandler OnBeginRun;
        public event GameTimeHandler OnUpdate;
        public event DefaultHandler OnEndRun;

        public event DefaultHandler OnBeginDraw;
        public event GameTimeHandler OnDraw;
        public event DefaultHandler OnEndDraw;

        public GraphicsDeviceManager Graphics { get { return _graphics; } }
        public SpriteBatch DefaultSpriteBatch { get { return _spriteBatch; } }

        public HKGameXna()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        protected override void Initialize()
        {
            base.Initialize();
            OnInitialise?.Invoke();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            base.LoadContent();
            OnLoadContent?.Invoke();
        }

        protected override void UnloadContent()
        {
            OnUnloadContent?.Invoke();
            base.UnloadContent();
        }

        
        protected override void BeginRun()
        {
            base.BeginRun();
            OnBeginRun?.Invoke();
        }

        protected override void Update(GameTime gameTime)
        {
            //to avoid calling the components
            //base.Update(gameTime);

            HKGameTime gt = new HKGameTime();
            gt.ElapsedGameTime = gameTime.ElapsedGameTime;
            gt.IsRunningSlowly = gameTime.IsRunningSlowly;
            gt.TotalGameTime = gameTime.TotalGameTime;

            OnUpdate?.Invoke(gt);
        }

        protected override void EndRun()
        {
            OnEndRun?.Invoke();
            base.EndRun();
        }

        protected override bool BeginDraw()
        {
            var canBegin = base.BeginDraw();
            OnBeginDraw?.Invoke();
            return canBegin;
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            HKGameTime gt = new HKGameTime();
            gt.ElapsedGameTime = gameTime.ElapsedGameTime;
            gt.IsRunningSlowly = gameTime.IsRunningSlowly;
            gt.TotalGameTime = gameTime.TotalGameTime;

            OnDraw?.Invoke(gt);

            //to avoid calling the components
            //base.Draw(gameTime);    
        }

        protected override void EndDraw()
        {
            OnEndDraw?.Invoke();
            base.EndDraw();
        }
    }
}
