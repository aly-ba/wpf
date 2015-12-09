using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Media;

namespace ThePlaneProjection.Controls
{
    public sealed partial class CenterOfRotationDisplayer : UserControl
    {
        private static readonly DependencyProperty CenterOfRotationXProperty;
        private static readonly DependencyProperty CenterOfRotationYProperty;
        private static readonly DependencyProperty CenterOfRotationZProperty;
        private static readonly DependencyProperty GlobalOffsetXProperty;
        private static readonly DependencyProperty GlobalOffsetYProperty;
        private static readonly DependencyProperty GlobalOffsetZProperty;
        private static readonly DependencyProperty RotationZProperty;
        private static readonly DependencyProperty PlaneProjectionProperty;

        public CenterOfRotationDisplayer()
        {
            this.InitializeComponent();
            LayoutUpdated += CenterPointDisplayer_LayoutUpdated;
        }

        static CenterOfRotationDisplayer()
        {
            CenterOfRotationXProperty =
            DependencyProperty.Register("CenterOfRotationX", typeof(double), typeof(CenterOfRotationDisplayer), new PropertyMetadata(0.5, OnPropertyChanged));
            CenterOfRotationYProperty =
            DependencyProperty.Register("CenterOfRotationY", typeof(double), typeof(CenterOfRotationDisplayer), new PropertyMetadata(0.5, OnPropertyChanged));
            CenterOfRotationZProperty =
            DependencyProperty.Register("CenterOfRotationZ", typeof(double), typeof(CenterOfRotationDisplayer), new PropertyMetadata(0.0, OnPropertyChanged));
            GlobalOffsetXProperty =
            DependencyProperty.Register("GlobalOffsetX", typeof(double), typeof(CenterOfRotationDisplayer), new PropertyMetadata(0.0, OnPropertyChanged));
            GlobalOffsetYProperty =
            DependencyProperty.Register("GlobalOffsetY", typeof(double), typeof(CenterOfRotationDisplayer), new PropertyMetadata(0.0, OnPropertyChanged));
            GlobalOffsetZProperty =
          DependencyProperty.Register("GlobalOffsetZ", typeof(double), typeof(CenterOfRotationDisplayer), new PropertyMetadata(0.0, OnPropertyChanged));
            RotationZProperty =
                DependencyProperty.Register("RotationZ", typeof(double), typeof(CenterOfRotationDisplayer), new PropertyMetadata(0.0, OnPropertyChanged));
            PlaneProjectionProperty =
DependencyProperty.Register("PlaneProjection", typeof(PlaneProjection), typeof(CenterOfRotationDisplayer), new PropertyMetadata(null, OnPropertyChanged));
        }

        private static void OnPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var displayer = d as CenterOfRotationDisplayer;
            if (displayer != null)
            {
                if (e.Property == PlaneProjectionProperty)
                {
                    displayer.InitializeBindings();
                }
                else
                {
                    displayer.RefreshCenterPoint();
                }
            }
        }

        private void InitializeBindings()
        {
            SetBinding(CenterOfRotationXProperty, CreateBinding("CenterOfRotationX"));
            SetBinding(CenterOfRotationYProperty, CreateBinding("CenterOfRotationY"));
            SetBinding(CenterOfRotationZProperty, CreateBinding("CenterOfRotationZ"));
            SetBinding(GlobalOffsetXProperty, CreateBinding("GlobalOffsetX"));
            SetBinding(GlobalOffsetYProperty, CreateBinding("GlobalOffsetY"));
            SetBinding(GlobalOffsetZProperty, CreateBinding("GlobalOffsetZ"));
            SetBinding(RotationZProperty, CreateBinding("RotationZ"));
        }

        private BindingBase CreateBinding(string path)
        {
            return new Binding { Source = PlaneProjection, Path = new PropertyPath(path), Mode = BindingMode.TwoWay };
        }

        public PlaneProjection PlaneProjection
        {
            get { return (PlaneProjection)GetValue(PlaneProjectionProperty); }
            set { SetValue(PlaneProjectionProperty, value); }
        }

        private double CenterOfRotationX
        {
            get { return (double)GetValue(CenterOfRotationXProperty); }
            set { SetValue(CenterOfRotationXProperty, value); }
        }

        private double CenterOfRotationY
        {
            get { return (double)GetValue(CenterOfRotationYProperty); }
            set { SetValue(CenterOfRotationYProperty, value); }
        }

        private double CenterOfRotationZ
        {
            get { return (double)GetValue(CenterOfRotationZProperty); }
            set { SetValue(CenterOfRotationZProperty, value); }
        }

        private double GlobalOffsetX
        {
            get { return (double)GetValue(GlobalOffsetXProperty); }
            set { SetValue(GlobalOffsetXProperty, value); }
        }

        private double GlobalOffsetY
        {
            get { return (double)GetValue(GlobalOffsetYProperty); }
            set { SetValue(GlobalOffsetYProperty, value); }
        }

        private double GlobalOffsetZ
        {
            get { return (double)GetValue(GlobalOffsetZProperty); }
            set { SetValue(GlobalOffsetZProperty, value); }
        }

        private double RotationZ
        {
            get { return (double)GetValue(RotationZProperty); }
            set { SetValue(RotationZProperty, value); }
        }

        private void CenterPointDisplayer_LayoutUpdated(object sender, object e)
        {
            RefreshCenterPoint();
        }

        private void RefreshCenterPoint()
        {
            Canvas.SetLeft(centerPoint, (canvas.ActualWidth * CenterOfRotationX));
            Canvas.SetTop(centerPoint, (canvas.ActualHeight * CenterOfRotationY));

            centerPointProjection.GlobalOffsetX = GlobalOffsetX;
            centerPointProjection.GlobalOffsetY = GlobalOffsetY;
            centerPointProjection.GlobalOffsetZ = GlobalOffsetZ+CenterOfRotationZ;
            centerPointProjection.RotationZ = RotationZ;
        }
    }
}