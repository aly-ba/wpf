using System.Collections.Generic;
using Windows.UI;
using Windows.UI.Text;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Documents;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Media3D;

namespace ThePlaneProjection.Controls
{
    public sealed partial class PlaneProjectionModifier : UserControl
    {
        public PlaneProjectionModifier()
        {
            this.InitializeComponent();
        }

        public PlaneProjection PlaneProjection
        {
            get { return (PlaneProjection)GetValue(PlaneProjectionProperty); }
            set { SetValue(PlaneProjectionProperty, value); }
        }

        // Using a DependencyProperty as the backing store for PlaneProjection.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PlaneProjectionProperty =
            DependencyProperty.Register("PlaneProjection", typeof(PlaneProjection), typeof(PlaneProjectionModifier), new PropertyMetadata(null));

        private void ButtonResetAllClick(object sender, RoutedEventArgs e)
        {
            if (PlaneProjection != null)
            {
                PlaneProjection.RotationX = 0;
                PlaneProjection.RotationY = 0;
                PlaneProjection.RotationZ = 0;

                PlaneProjection.CenterOfRotationX = 0.5;
                PlaneProjection.CenterOfRotationY = 0.5;
                PlaneProjection.CenterOfRotationZ = 0;

                PlaneProjection.LocalOffsetX = 0;
                PlaneProjection.LocalOffsetY = 0;
                PlaneProjection.LocalOffsetZ = 0;

                PlaneProjection.GlobalOffsetX = 0;
                PlaneProjection.GlobalOffsetY = 0;
                PlaneProjection.GlobalOffsetZ = 0;
            }
        }
    }

    /// <summary>
    /// Creates the Slider-Headers automatically based on the data bindings
    /// </summary>
    public static class SliderHeader
    {
        public static bool GetCreate(Slider obj)
        {
            return (bool)obj.GetValue(CreateProperty);
        }

        public static void SetCreate(Slider obj, bool value)
        {
            obj.SetValue(CreateProperty, value);
        }

        public static readonly DependencyProperty CreateProperty =
            DependencyProperty.RegisterAttached("Create", typeof(bool), typeof(SliderHeader), new PropertyMetadata(false, OnPropertyChanged));

        private static void OnPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var slider = d as Slider;
            if (slider != null)
            {
                var be = slider.GetBindingExpression(Slider.ValueProperty);
                if (be != null)
                {
                    var bindingPath = be.ParentBinding.Path.Path;

                    var propertyTextBlock = new TextBlock { Text = bindingPath + ":", Margin = new Thickness(0, 0, 0, 10) };
                    var valueTextBlock = new TextBlock { Foreground = new SolidColorBrush(Colors.Yellow) };
                    valueTextBlock.SetBinding(TextBlock.TextProperty,
                        new Binding { Path = new PropertyPath(bindingPath), Mode = BindingMode.OneWay });

                    var stackPanel = new StackPanel { Orientation = Orientation.Horizontal };
                    stackPanel.Children.Add(propertyTextBlock);
                    stackPanel.Children.Add(valueTextBlock);

                    slider.Header = stackPanel;
                }
            }
        }
    }
}
