using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace XAMLJumpstart
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            frmMainFrame.Navigate(new MainPage());
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            if (frmMainFrame.CanGoBack)
            {
                frmMainFrame.GoBack();
            }
        }

        private void btnForward_Click(object sender, RoutedEventArgs e)
        {
            if (frmMainFrame.CanGoForward)
            {
                frmMainFrame.GoForward();
            }
        }

        private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            Process.Start(new ProcessStartInfo(e.Uri.AbsoluteUri));
            e.Handled = true;
        }
    }
}
