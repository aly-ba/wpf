using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupervisingController
{
    class ManagePersonFormPresenter
    {
        //not neeed to change during his lifecycle
        private readonly IManagePersonForm _view;

        public ManagePersonFormPresenter(IManagePersonForm view)
        {
            _view = view;
            _view.PersonSaved += _view_PersonSaved;
        }

        void _view_PersonSaved(object send, EventArgs e)
        {
            var person = _view.Person;
        }
    }
}
