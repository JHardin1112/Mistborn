using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mistborn.Models.Metals.Basic
{
    class Tin:IConsumableMetal
    {
        public int BurnPerSecond { get; set; }
        public int FlarePerSecond { get; set; }
        public Push pushEffect { get; set; }
        public Pull pullEffect { get; set; }
    }
}
