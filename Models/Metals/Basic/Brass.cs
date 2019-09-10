using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mistborn.Models.Metals.Basic
{
    class Brass: IConsumableMetal
    {
        public double BurnRateInMilliseconds { get; set; } = 1000;
        public decimal BurnPerBurnRateInMilliseconds { get; set; } = 5;
        public decimal FlareCost { get; set; } = 20;
        public Push pushEffect { get; set; }
        public Pull pullEffect { get; set; }
    }
}
