using FriendViewer.DataProvider;
using FriendViewer.ViewModel;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using FriendViewer.Extensions;

namespace FriendViewer
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

        private void FriendControl_MouseEnter(object sender, MouseEventArgs e)
        {
            GeneralTransform generalTransform= this.TransformToVisual(navigationGrid);
            Point point = generalTransform.Transform(new Point());

            point.X += navigationTransform.X;
            point.X -= navigationColumn.ActualWidth;
            point.Y = 0;
            navigationTransform.AnimateTo(point);
        }

        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {
            navigationTransform.AnimateTo(new Point());
        }
    }
}
