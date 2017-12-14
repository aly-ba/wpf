using SupervisingController.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupervisingController
{
    interface IManagePersonForm
    {
        Person Person { get; set; }
        event EventHandler PersonSaved;
    }
}
