using SupervisingController.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupervisingController
{
    public partial class ManagePersonForm : Form, IManagePersonForm
    {
        private Person _person;

        public ManagePersonForm()
        {
            InitializeComponent();
        }

        public Person Person
        {
            get
            {
                _person.FirstName = FirstNameTextBox.Text;
                _person.LastName = LastNameTextBox.Text;

                return _person;
            }
            set
            {
                _person = value;

                FirstNameTextBox.Text = _person.FirstName;
                LastNameTextBox.Text = _person.LastName;
            }
        }
    }
}
