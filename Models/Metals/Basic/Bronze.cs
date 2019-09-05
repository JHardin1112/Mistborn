using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mistborn.Models.Metals.Basic
{
    class Bronze:IConsumableMetal
    {
        public double BurnRateInMilliseconds { get; set; } = 500;
        public decimal BurnPerBurnRateInMilliseconds { get; set; } = 1;
        public decimal FlareCost { get; set; } = 10;
        public Push pushEffect { get; set; }
        public Pull pullEffect { get; set; }
    }
}
