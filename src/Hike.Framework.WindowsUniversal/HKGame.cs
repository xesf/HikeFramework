using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hike.Framework.WindowsUniversal.Graphics;
using Hike.Framework.WindowsUniversal.Types;
using Microsoft.Xna.Framework.Graphics;

namespace Hike.Framework.WindowsUniversal
{
    /// <summary>
    /// Hike Framework Game class
    /// Extend this class to create a new game with Hike Framework default options
    /// </summary>
    public partial class HKGame : IDisposable
    {
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

        public HKSize ViewSize;
        public HKViewport Viewport;

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public virtual void Initialise()
        {
            PlatformInitialise();
            InitialiseGraphicsDevice();
        }

        void InitialiseGraphicsDevice()
        {
            var presParams = new PresentationParameters();
            presParams.RenderTargetUsage = RenderTargetUsage.PreserveContents;
            presParams.DepthStencilFormat = DepthFormat.Depth24Stencil8;
            presParams.BackBufferFormat = SurfaceFormat.Color;
            PlatformInitialiseGraphicsDevice(ref presParams);

            // Try to create graphics device with hi-def profile
            try
            {
                _graphicsDevice = new GraphicsDevice(GraphicsAdapter.DefaultAdapter, GraphicsProfile.HiDef, presParams);
            }
            // Otherwise, if unsupported defer to using the low-def profile
            catch (NotSupportedException)
            {
                _graphicsDevice = new GraphicsDevice(GraphicsAdapter.DefaultAdapter, GraphicsProfile.Reach, presParams);
            }
            
            _graphicsDeviceService = new HKGraphicsDeviceService(_graphicsDevice);
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

            //viewportDirty = false;
        }
    }
}
