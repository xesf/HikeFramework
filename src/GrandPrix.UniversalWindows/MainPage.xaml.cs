using GrandPrix.Game;
using Hike.Framework.Platform;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace GrandPrix.UniversalWindows
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        GrandPrixGame _game;

        public MainPage()
        {
            this.InitializeComponent();

            var launchArguments = string.Empty;
            _game = HKGameUniversalWindows<GrandPrixGame>.Create(launchArguments, Window.Current.CoreWindow, swapChainPanel);
        }
    }
}
