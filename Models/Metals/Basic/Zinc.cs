using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mistborn.Models.Metals.Basic
{
    class Zinc:IConsumableMetal 
    {
        public double BurnRateInMilliseconds { get; set; } = 800;
        public decimal BurnPerBurnRateInMilliseconds { get; set; } = 12;
        public decimal FlareCost { get; set; } = 50;
        public Push pushEffect { get; set; }
        public Pull pullEffect { get; set; }
    }
}
