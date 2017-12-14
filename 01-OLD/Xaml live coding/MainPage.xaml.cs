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

namespace XAMLJumpstart
{
    /// <summary>
    /// Interaction logic for MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }


        private void btnSyntax_Click(object sender, RoutedEventArgs e)
        {
            var newPage = new Introduction.Syntax();
            NavigationService.GetNavigationService(this).Navigate(newPage);
        }

        private void btnPath_Click(object sender, RoutedEventArgs e)
        {
            var newPage = new BasicElements.Path();
            NavigationService.GetNavigationService(this).Navigate(newPage);
        }

        private void btnBrushes_Click(object sender, RoutedEventArgs e)
        {
            var newPage = new BasicElements.Brushes();
            NavigationService.GetNavigationService(this).Navigate(newPage);
        }

        private void btnMasks_Click(object sender, RoutedEventArgs e)
        {
            var newPage = new BasicElements.Masks();
            NavigationService.GetNavigationService(this).Navigate(newPage);
        }

        private void btnCanvas_Click(object sender, RoutedEventArgs e)
        {
            var newPage = new Panels.Canvas();
            NavigationService.GetNavigationService(this).Navigate(newPage);
        }

        private void btnStackPanel_Click(object sender, RoutedEventArgs e)
        {
            var newPage = new Panels.StackPanel();
            NavigationService.GetNavigationService(this).Navigate(newPage);
        }

        private void btnGrid_Click(object sender, RoutedEventArgs e)
        {
            var newPage = new Panels.Grid();
            NavigationService.GetNavigationService(this).Navigate(newPage);
        }

        private void btnLayoutProperties_Click(object sender, RoutedEventArgs e)
        {
            var newPage = new Panels.LayoutProperties();
            NavigationService.GetNavigationService(this).Navigate(newPage);
        }

        private void btnShapes_Click(object sender, RoutedEventArgs e)
        {
            var newPage = new BasicElements.Shapes();
            NavigationService.GetNavigationService(this).Navigate(newPage);
        }

        private void btnControlTemplates_Click(object sender, RoutedEventArgs e)
        {
            var newPage = new BasicControls.Template();
            NavigationService.GetNavigationService(this).Navigate(newPage);
        }

        private void btnRoutedEvents_Click(object sender, RoutedEventArgs e)
        {
            var newPage = new Interacting.RoutedEvents();
            NavigationService.GetNavigationService(this).Navigate(newPage);
        }

        private void btnDataBinding_Click(object sender, RoutedEventArgs e)
        {
            var newPage = new DataBinding.DataBinding();
            NavigationService.GetNavigationService(this).Navigate(newPage);

        }

        private void btnItemsControls_Click(object sender, RoutedEventArgs e)
        {
            var newPage = new ItemsControls.ItemsControls();
            NavigationService.GetNavigationService(this).Navigate(newPage);
        }

        private void btnIntroResources_Click(object sender, RoutedEventArgs e)
        {
            var newPage = new ResourcesAndStyling.IntroToResources.Intro();
            NavigationService.GetNavigationService(this).Navigate(newPage);
        }

        private void btnResDic_Click(object sender, RoutedEventArgs e)
        {
            var newPage = new ResourcesAndStyling.ResourceDictionaries.WorkingWithResourceDictionaries();
            NavigationService.GetNavigationService(this).Navigate(newPage);

        }

        private void btnStyles_Click(object sender, RoutedEventArgs e)
        {
            var newPage = new ResourcesAndStyling.Styles.Styles();
            NavigationService.GetNavigationService(this).Navigate(newPage);
        }

        private void btnStyleInheritance_Click(object sender, RoutedEventArgs e)
        {
            var newPage = new ResourcesAndStyling.StyleInheritance.StyleInheritance();
            NavigationService.GetNavigationService(this).Navigate(newPage);
        }

        private void btnDebugging_Click(object sender, RoutedEventArgs e)
        {
            var newPage = new DebuggingAndAnalyzing.Debugging();
            NavigationService.GetNavigationService(this).Navigate(newPage);
        }

        private void btnAnalyzing_Click(object sender, RoutedEventArgs e)
        {
            var newPage = new DebuggingAndAnalyzing.Analyzing();
            NavigationService.GetNavigationService(this).Navigate(newPage);
        }
    }
}
