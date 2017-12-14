using Windows.Foundation;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using TranslateTransformWinRT.Extensions;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace TranslateTransformWinRT
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private int _zIndex;
        private void OnTapped(object sender, TappedRoutedEventArgs e)
        {
            var element = e.OriginalSource as FrameworkElement;
            if (element != null)
            {
                element.SetValue(Canvas.ZIndexProperty, ++_zIndex);
                GeneralTransform generalTransform = targetElement.TransformToVisual(element);
                Point point = generalTransform.TransformPoint(new Point());

                TranslateTransform translateTransform
                    = element.RenderTransform as TranslateTransform;
                if (translateTransform == null)
                {
                    translateTransform = new TranslateTransform();
                    element.RenderTransform = translateTransform;
                }

                bool elementReachedOrigin = point.X == 0 && point.Y == 0;
                if (elementReachedOrigin)
                {
                    translateTransform.AnimateTo(new Point());
                }
                else
                {
                    point.X += translateTransform.X;
                    point.Y += translateTransform.Y;
                    translateTransform.AnimateTo(point);
                }
            }
        }
    }
}
