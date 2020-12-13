using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLifeSMK
{
    sealed class GamePanelField : MainPanel
    {
        public override int Width { get; set; }
        public override int Height { get; set; }
        public GamePanelField(OutputMatrix output) : base(output)
        {

        }
    }
}
