﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLifeSMK
{
    abstract class ReadPanel : Panel
    {
        public abstract string Read();
        public ReadPanel(OutputMatrix output) : base(output)
        {
            this.output = output;
            X = Y = 0;
            Width = Height = 0;
        }
        public override void Write()
        {
            Console.SetCursorPosition(X + Width - 2, Y);
            Console.Write(output.GetChar(X + Width - 1, Y));
            Console.MoveBufferArea(X + Width - 2, Y, 1, 1, X + Width - 1, Y);
            Console.SetCursorPosition(X, Y);
            Console.Write(output.GetLine(Y, X, X + Width - 1));
            Console.SetCursorPosition(0, 0);
        }
    }
}
