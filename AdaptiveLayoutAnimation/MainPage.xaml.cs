using Windows.UI.Xaml.Controls;
using Continuity;
using Continuity.Extensions;

namespace AdaptiveLayoutAnimation
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();

            LeftText.EnableImplicitAnimation(VisualPropertyType.Offset, 400);
            RightText.EnableImplicitAnimation(VisualPropertyType.Offset, 400);

            var compositor = this.Visual().Compositor;
            //var leftBackgroundVisual = compositor.

            LeftGrid.SizeChanged += (s, e) => { };
            RightGrid.SizeChanged += (s, e) => { };
        }
    }
}
