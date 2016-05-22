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

        public HKGameXna()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            base.LoadContent();
        }

        protected override void UnloadContent()
        {
            base.UnloadContent();
        }

        
        protected override void BeginRun()
        {
            base.BeginRun();
        }

        protected override void Update(GameTime gameTime)
        {
            //to avoid calling the components
            //base.Update(gameTime);
        }

        protected override void EndRun()
        {
            base.EndRun();
        }

        protected override bool BeginDraw()
        {
            var canBegin = base.BeginDraw();

            return canBegin;
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            //to avoid calling the components
            //base.Draw(gameTime);    
        }

        protected override void EndDraw()
        {
            base.EndDraw();
        }
    }
}
