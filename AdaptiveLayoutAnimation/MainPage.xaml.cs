using System.Numerics;
using Windows.UI;
using Windows.UI.Composition;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Continuity;
using Continuity.Extensions;
using Windows.UI.Xaml.Markup;

namespace AdaptiveLayoutAnimation
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();

            var compositor = this.Visual().Compositor;

            // Create background visuals.
            var leftBackgroundVisual = compositor.CreateSpriteVisual();
            leftBackgroundVisual.Brush = compositor.CreateColorBrush(Colors.Crimson);
            LeftGridBackgroundVisualWrapper.SetChildVisual(leftBackgroundVisual);

            var middleBackgroundVisual = compositor.CreateSpriteVisual();
            middleBackgroundVisual.Brush = compositor.CreateColorBrush(Colors.Gold);
            MiddleGridBackgroundVisualWrapper.SetChildVisual(middleBackgroundVisual);

            var rightBackgroundVisual = compositor.CreateSpriteVisual();
            rightBackgroundVisual.Brush = compositor.CreateColorBrush(Colors.DarkOrchid);
            RightGridBackgroundVisualWrapper.SetChildVisual(rightBackgroundVisual);

            // Sync background visual dimensions.
            LeftGridBackgroundVisualWrapper.SizeChanged += (s, e) => leftBackgroundVisual.Size = e.NewSize.ToVector2();
            MiddleGridBackgroundVisualWrapper.SizeChanged += (s, e) => middleBackgroundVisual.Size = e.NewSize.ToVector2();
            RightGridBackgroundVisualWrapper.SizeChanged += (s, e) => rightBackgroundVisual.Size = e.NewSize.ToVector2();

            // Enable implilcit Offset and Size animations.
            LeftText.EnableImplicitAnimation(VisualPropertyType.Offset, 400);
            MiddleText.EnableImplicitAnimation(VisualPropertyType.Offset, 400);
            RightText.EnableImplicitAnimation(VisualPropertyType.Offset, 400);
            LeftGrid.EnableImplicitAnimation(VisualPropertyType.Offset, 400);
            MiddleGrid.EnableImplicitAnimation(VisualPropertyType.Offset, 400);
            RightGrid.EnableImplicitAnimation(VisualPropertyType.Offset, 400);
            leftBackgroundVisual.EnableImplicitAnimation(VisualPropertyType.Size, 400);
            middleBackgroundVisual.EnableImplicitAnimation(VisualPropertyType.Size, 400);
            rightBackgroundVisual.EnableImplicitAnimation(VisualPropertyType.Size, 400);

            // Enable implicit Visible/Collapsed animations.
            LeftGrid.EnableFluidVisibilityAnimation(showFromScale: 0.6f, hideToScale: 0.8f, showDuration: 400, hideDuration: 250);
            MiddleGrid.EnableFluidVisibilityAnimation(showFromScale: 0.6f, hideToScale: 0.8f, showDelay: 200, showDuration: 400, hideDuration: 250);
            RightGrid.EnableFluidVisibilityAnimation(showFromScale: 0.6f, hideToScale: 0.8f, showDelay: 400, showDuration: 400, hideDuration: 250);
        }
    }
}