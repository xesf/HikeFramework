using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
