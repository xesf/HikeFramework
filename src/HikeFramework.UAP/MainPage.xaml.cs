using HikeFramework.UAP.Game;
using HikeFramework.Win2D;
using HikeFramework.Win2D.Platform;
using Windows.UI.Xaml.Controls;

namespace HikeFramework.UAP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        protected HKPage _page = null;

        public HKPage Page { get { return _page; } }

        public MainPage()
        {
            this.InitializeComponent();

            var game = new TestGame(new HKWin2DPlatformFactory());
            _page = new HKPage(game);

            canvasGrid.Children.Add(Page.Canvas);
        }
    }
}
