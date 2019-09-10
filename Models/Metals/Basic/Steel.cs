using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mistborn.Models.Metals
{
    class Steel: IConsumableMetal 
    {
        public double BurnRateInMilliseconds { get; set; } = 1500;
        public decimal BurnPerBurnRateInMilliseconds { get; set; } = 3;
        public decimal FlareCost { get; set; } = 5;
        public Push pushEffect { get; set; }
        public Pull pullEffect { get; set; }
    }
}
