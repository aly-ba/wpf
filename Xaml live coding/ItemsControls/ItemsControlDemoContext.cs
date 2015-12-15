using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XAMLJumpstart.ItemsControls
{
    public class ItemsControlDemoContext : BindableBase
    {

        private ObservableCollection<Person> _people;
        public ObservableCollection<Person> People
        {
            get
            {
                return _people;
            }

            set
            {
                if (value != _people)
                {
                    _people = value;
                    RaisePropertyChanged("People");
                }
            }
        }

        private Person _currentPerson;
        public Person CurrentPerson
        {
            get
            {
                return _currentPerson;
            }
            set
            {
                if (value != _currentPerson)
                {
                    _currentPerson = value;
                    RaisePropertyChanged("CurrentPerson");
                }
            }
        }





        public ItemsControlDemoContext()
        {
            People = CreateAndReturnPeople();

        }

        private ObservableCollection<Person> CreateAndReturnPeople()
        {
            return new ObservableCollection<Person>()
            {
                new Person("Kevin", 33),
                new Person("Sven", 28),
                new Person("Tom", 31)
            };
        }



    }
}
