using HikeFramework.Win2D;
using Windows.UI.Xaml.Controls;

namespace HikeFramework.UAP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        protected HKPage _page = null;

        public HKPage Page { get { return _page = _page ?? new HKPage(); } }

        public MainPage()
        {
            this.InitializeComponent();

            canvasGrid.Children.Add(Page.Canvas);
        }
    }
}
