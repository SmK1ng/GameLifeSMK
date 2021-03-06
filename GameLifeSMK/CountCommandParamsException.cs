﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLifeSMK
{
    class CountCommandParamsException : SystemException
    {
        public enum Comprasion { MORE, EQUALS }
        public CountCommandParamsException(string command, int expected, int received, Comprasion comprasion = Comprasion.EQUALS)
            : base($"{(command == null ? "" : command + ": ")}expected {(comprasion == Comprasion.MORE ? ">" : "")}{expected} parametrs, " +
                  $"but get {received}")
        {

        }
        public CountCommandParamsException(int expected, int received, Comprasion comprasion = Comprasion.EQUALS)
            : this(null, expected, received, comprasion)
        {

        }
    }
}
