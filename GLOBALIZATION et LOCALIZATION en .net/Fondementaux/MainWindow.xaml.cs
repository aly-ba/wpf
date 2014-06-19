using System;
using System.Globalization;
using System.Threading;
using System.Windows;

namespace ChangeUICulture
{
    public partial class MainWindow : Window
    {
        DateTime displayDate = new DateTime(2014, 2, 28);

        public MainWindow()
        {
            InitializeComponent();
            UpdateUIElements();
        }

        private void UpdateUIElements()
        {
            CurrentCultureTextBlock.Text = string.Format(
                Properties.Resources.CurrentCulture,
                CultureInfo.CurrentCulture.ToString());
            DateTextBlock.Text = displayDate.ToString("d");
            LongDateTextBlock.Text = displayDate.ToString("D");
        }

        private void USButton_Click(object sender, RoutedEventArgs e)
        {
            App.ChangeCulture(new CultureInfo("en-US"));
        }

        private void GBButton_Click(object sender, RoutedEventArgs e)
        {
            App.ChangeCulture(new CultureInfo("en-GB"));
        }

        private void AUButton_Click(object sender, RoutedEventArgs e)
        {
            App.ChangeCulture(new CultureInfo("en-AU"));
        }

        private void NZButton_Click(object sender, RoutedEventArgs e)
        {
            App.ChangeCulture(new CultureInfo("en-NZ"));
        }

    }
}
