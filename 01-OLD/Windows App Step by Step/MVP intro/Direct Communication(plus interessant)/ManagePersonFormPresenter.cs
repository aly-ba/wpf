using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectCommunication
{
    public class ManagePersonFormPresenter : IManagePersonFormPresenter
    {
        private readonly IManagePersonForm _view;

        public ManagePersonFormPresenter(IManagePersonForm view)
        {
            _view = view;
        }

        public void Start()
        {
            _view.AttachPresenter(this);
        }

        public void SavePerson()
        {
            var person = _view.Person;

            // code to save person
        }
    }
}
