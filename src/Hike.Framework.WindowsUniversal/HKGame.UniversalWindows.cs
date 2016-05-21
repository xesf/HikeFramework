using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hike.Framework.WindowsUniversal.Types;
using Microsoft.Xna.Framework.Graphics;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Hike.Framework.WindowsUniversal
{
    /// <summary>
    /// Hike Framework Game class
    /// Extend this class to create a new game with Hike Framework default options
    /// </summary>
    public partial class HKGame : SwapChainPanel
    {
        public HKGame() : base()
        {
            if (Windows.ApplicationModel.DesignMode.DesignModeEnabled)
                return;

            Initialise();
        }

        void PlatformInitialise()
        {
            SizeChanged += ViewSizeChanged;
            Window.Current.Activated += ViewStateChanged;
        }

        void ViewStateChanged(object sender, WindowActivatedEventArgs e)
        {
            //Paused = (e.WindowActivationState == CoreWindowActivationState.Deactivated);
        }

        void ViewSizeChanged(object sender, SizeChangedEventArgs e)
        {
            ViewSize = new HKSize((float)e.NewSize.Width, (float)e.NewSize.Height);

            _graphicsDevice.PresentationParameters.BackBufferWidth = (int)ViewSize.Width;
            _graphicsDevice.PresentationParameters.BackBufferHeight = (int)ViewSize.Height;
            _graphicsDevice.CreateSizeDependentResources();
            _graphicsDevice.ApplyRenderTargets(null);

            UpdateViewport();

            //platformInitialised = true;

            //LoadGame();
        }

        void PlatformInitialiseGraphicsDevice(ref PresentationParameters presParams)
        {
#if WINDOWS_UWP
            presParams.SwapChainPanel = this;
#else
            presParams.SwapChainBackgroundPanel = this;
#endif
        }
    }
}
