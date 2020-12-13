using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLifeSMK
{
    class UnknownCommandException : SystemException
    {
        public UnknownCommandException(string message) : base(message)
        {

        }
    }
}
