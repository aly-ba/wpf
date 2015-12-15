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

namespace XAMLJumpstart.DataBinding
{
    /// <summary>
    /// Interaction logic for DataBinding.xaml
    /// </summary>
    public partial class DataBinding : Page
    {
        Person person = new Person();
        public DataBinding()
        {
            InitializeComponent();

            this.DataContext = person;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            BindingExpression be =
                txtName.GetBindingExpression(TextBox.TextProperty);
            be.UpdateSource();

        }
 
    }
}
