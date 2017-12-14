using DirectCommunication.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectCommunication
{
    interface IManagePersonForm
    {
        Person Person { get; set; }
        void AttachPresenter(IManagePersonFormPresenter presenter);
    }
}
