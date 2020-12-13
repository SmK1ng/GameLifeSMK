using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLifeSMK
{
    interface ICommandEvent
    {
        Dictionary<string, CommandEventDescription> GetCommandEvents();
    }
}
