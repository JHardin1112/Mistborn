using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mistborn.Models.Metals.Basic
{
    class Tin : IConsumableMetal
    {
        public double BurnRateInMilliseconds { get; set; } = 750;
        public decimal BurnPerBurnRateInMilliseconds { get; set; } = 1;
        public decimal FlareCost { get; set; } = 12;
        public Push pushEffect { get; set; }
        public Pull pullEffect { get; set; }
    }
}
