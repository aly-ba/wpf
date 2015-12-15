using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace XAMLJumpstart.ItemsControls
{
    public class PersonDataTemplateSelector : DataTemplateSelector
    {

        public DataTemplate UnderThirtyTemplate { get; set; }
        public DataTemplate ThirtyOrOlderTemplate { get; set; }

        public override System.Windows.DataTemplate SelectTemplate
            (object item, System.Windows.DependencyObject container)
        {
            var person = item as Person;

            if (person.Age < 30)
            {
                return UnderThirtyTemplate;
            }
            else
            {
                return ThirtyOrOlderTemplate;
            }
        }

    }
}
