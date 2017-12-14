using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassiveView
{
    public partial class ManagePersonForm : Form, IManagePersonForm
    {
        public ManagePersonForm()
        {
            InitializeComponent();
        }

        public string FirstName
        {
            get
            {
                return FirstNameTextBox.Text;
            }
            set
            {
                FirstNameTextBox.Text = value;
            }
        }

        public string LastName
        {
            get
            {
                return LastNameTextBox.Text;
            }
            set
            {
                LastNameTextBox.Text = value;
            }
        }
    }
}
