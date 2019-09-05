using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mistborn.Models.Metals.High
{
    class Bendalloy: IConsumableMetal
    {
        public double BurnRateInMilliseconds { get; set; }
        public decimal BurnPerBurnRateInMilliseconds { get; set; }
        public decimal FlareCost { get; set; }
        public Push pushEffect { get; set; }
        public Pull pullEffect { get; set; }
    }
}
