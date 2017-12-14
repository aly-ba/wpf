using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using TranslateTransformWPF.Extensions;

namespace TranslateTransformWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private int _zIndex;
        private void UIElement_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            var element = e.OriginalSource as FrameworkElement;
            if (element != null)
            {
                element.SetValue(Panel.ZIndexProperty, ++_zIndex);
                GeneralTransform generalTransform = targetElement.TransformToVisual(element);
                Point point = generalTransform.Transform(new Point());

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
                //translateTransform.X = point.X;
                //translateTransform.Y = point.Y;
            }
        }
    }
}
