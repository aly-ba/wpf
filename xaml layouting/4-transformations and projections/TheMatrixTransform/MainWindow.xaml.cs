using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TheMatrixTransform
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

        private Matrix _rotateMatrix = new Matrix();
        private Matrix _scaleMatrix = new Matrix();
        
        private void RotateValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            var radian = DegreeToRadian(e.NewValue);

            _rotateMatrix = new Matrix
            {
                M11 = Math.Cos(radian),
                M12 = Math.Sin(radian),
                M21 = Math.Sin(radian) * -1,
                M22 = Math.Cos(radian)
            };

            //// or simpler like this

            //_rotateMatrix = new Matrix();
            //_rotateMatrix.Rotate(e.NewValue);
            
            matrixTransform.Matrix = _rotateMatrix * _scaleMatrix;
        }

        private void ScaleValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            _scaleMatrix = new Matrix
            {
                M11 = e.NewValue,
                M22 = e.NewValue
            };

            matrixTransform.Matrix = _rotateMatrix * _scaleMatrix;
        }

        private double DegreeToRadian(double degrees)
        {
            return Math.PI * degrees / 180.0;
        }
    }
}
