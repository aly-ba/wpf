using DirectCommunication.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DirectCommunication
{
    public partial class ManagePersonForm : Form, IManagePersonForm
    {
        private Person _person;
        private IManagePersonFormPresenter _presenter;

        public ManagePersonForm()
        {
            InitializeComponent();
        }

        public Person Person
        {
            get
            {
                return _person;
            }
            set
            {
                _person = value;

                FirstNameTextBox.Text = _person.FirstName;
                LastNameTextBox.Text = _person.LastName;
            }
        }


        public void AttachPresenter(IManagePersonFormPresenter presenter)
        {
            _presenter = presenter;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            _person.FirstName = FirstNameTextBox.Text;
            _person.LastName = LastNameTextBox.Text;

            _presenter.SavePerson();
        }
    }
}
