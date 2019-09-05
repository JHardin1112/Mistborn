using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mistborn.Models
{
    public interface IConsumableMetal
    {
        //What properties does a Consumable Metal have?
        //burnPerSecond - how much is consumed per second when burning
        //flarePerSecond - how much is consumed per second when flaring  
        //rarity?
        //toxicity?
        //test
        double BurnRateInMilliseconds { get; set; }
        decimal BurnPerBurnRateInMilliseconds { get; set; }
        decimal FlareCost { get; set; } //should cost an initial amount/drain and then burnPerSecond kicks in.
        Push pushEffect { get; set; }
        Pull pullEffect { get; set; }


    }
}
