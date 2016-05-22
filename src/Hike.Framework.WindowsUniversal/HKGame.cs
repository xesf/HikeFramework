using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hike.Framework.WindowsUniversal.Graphics;
using Hike.Framework.WindowsUniversal.System;
using Hike.Framework.WindowsUniversal.Types;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;

namespace Hike.Framework.WindowsUniversal
{
    /// <summary>
    /// Hike Framework Game class
    /// Extend this class to create a new game with Hike Framework default options
    /// </summary>
    public partial class HKGame : IDisposable
    {
        const int numOfTicksPerUpdate = 166667;
        const int maxUpdateTimeMilliseconds = 500;

        class HKGraphicsDeviceService : IGraphicsDeviceService
        {
            public GraphicsDevice GraphicsDevice { get; private set; }

            public HKGraphicsDeviceService(GraphicsDevice graphicsDevice)
            {
                GraphicsDevice = graphicsDevice;
            }

            public event EventHandler<EventArgs> DeviceCreated;
            public event EventHandler<EventArgs> DeviceDisposing;
            public event EventHandler<EventArgs> DeviceReset;
            public event EventHandler<EventArgs> DeviceResetting;
        }

        GraphicsDevice _graphicsDevice;
        HKGraphicsDeviceService _graphicsDeviceService;

        HKGameTime _gameTime;
        TimeSpan _accumulatedElapsedTime;
        TimeSpan _targetElapsedTime;
        TimeSpan _maxElapsedTime;
        Stopwatch _gameTimer;
        long _previousTicks;

        bool _viewportDirty = false;


        public HKSize ViewSize;
        public HKViewport Viewport;


        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public virtual void Initialise()
        {
            _gameTimer = Stopwatch.StartNew();
            _gameTime = new HKGameTime();

            _accumulatedElapsedTime = TimeSpan.Zero;
            _targetElapsedTime = TimeSpan.FromTicks(numOfTicksPerUpdate);
            _maxElapsedTime = TimeSpan.FromMilliseconds(maxUpdateTimeMilliseconds);
            _previousTicks = 0;

            PlatformInitialise();
            InitialiseGraphicsDevice();
            PlatformStartGame();
        }

        void InitialiseGraphicsDevice()
        {
            var presParams = new PresentationParameters();
            presParams.RenderTargetUsage = RenderTargetUsage.PreserveContents;
            presParams.DepthStencilFormat = DepthFormat.Depth24Stencil8;
            presParams.BackBufferFormat = SurfaceFormat.Color;
            PlatformInitialiseGraphicsDevice(ref presParams);

            // hi-def profile
            try
            {
                _graphicsDevice = new GraphicsDevice(GraphicsAdapter.DefaultAdapter, GraphicsProfile.HiDef, presParams);
            }
            // low-def profile
            catch (NotSupportedException)
            {
                _graphicsDevice = new GraphicsDevice(GraphicsAdapter.DefaultAdapter, GraphicsProfile.Reach, presParams);
            }
            
            _graphicsDeviceService = new HKGraphicsDeviceService(_graphicsDevice);
        }

        internal void Present()
        {
            PlatformPresent();
        }

        void UpdateViewport()
        {
            int width = (int)ViewSize.Width;
            int height = (int)ViewSize.Height;

            // The GraphicsDevice BackBuffer dimensions are used by MonoGame when laying out the viewport
            // so make sure they're updated
            _graphicsDevice.PresentationParameters.BackBufferWidth = width;
            _graphicsDevice.PresentationParameters.BackBufferHeight = height;

            Viewport = new HKViewport(0,0,width,height);

            //CCPoint center = new CCPoint(ViewSize.Width / 2.0f, ViewSize.Height / 2.0f);
            //defaultViewMatrix = XnaMatrix.CreateLookAt(new CCPoint3(center, 300.0f).XnaVector, new CCPoint3(center, 0.0f).XnaVector, Vector3.Up);
            //defaultProjMatrix = XnaMatrix.CreateOrthographic(ViewSize.Width, ViewSize.Height, 1024f, -1024);
            //defaultViewport = new Viewport(0, 0, ViewSize.Width, ViewSize.Height);

            _viewportDirty = false;
        }

        // from CocosSharp
        void Tick()
        {
            RetryTick:

            var currentTicks = _gameTimer.Elapsed.Ticks;
            _accumulatedElapsedTime += TimeSpan.FromTicks(currentTicks - _previousTicks);
            _previousTicks = currentTicks;

            if (_accumulatedElapsedTime < _targetElapsedTime)
            {
                var sleepTime = (int)(_targetElapsedTime - _accumulatedElapsedTime).TotalMilliseconds;

                Task.Delay(sleepTime).Wait();

                goto RetryTick;
            }

            if (_accumulatedElapsedTime > _maxElapsedTime)
                _accumulatedElapsedTime = _maxElapsedTime;

            _gameTime.ElapsedGameTime = _targetElapsedTime;
            var stepCount = 0;

            while (_accumulatedElapsedTime >= _targetElapsedTime)
            {
                _gameTime.TotalGameTime += _targetElapsedTime;
                _accumulatedElapsedTime -= _targetElapsedTime;
                ++stepCount;

                Update(_gameTime);
            }

            _gameTime.ElapsedGameTime = TimeSpan.FromTicks(_targetElapsedTime.Ticks * stepCount);
        }

        void Update(HKGameTime time)
        {
            float deltaTime = (float)_gameTime.ElapsedGameTime.TotalSeconds;
            
            SoundEffectInstancePool.Update();
            
            // TODO: do the update here

            ProcessInput();
        }

        void ProcessInput()
        {

        }

        void Draw()
        {
            _graphicsDevice.Clear(Color.Blue);
        }
    }
}
