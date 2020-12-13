using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLifeSMK
{
    class FileStringParseException : SystemException
    {
        public FileStringParseException(string message) : base(message)
        {

        }
    }
}
