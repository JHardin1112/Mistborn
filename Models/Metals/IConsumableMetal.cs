using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mistborn.Models
{
    interface IConsumableMetal
    {
        //What properties does a Consumable Metal have?
        //burnPerSecond - how much is consumed per second when burning
        //flarePerSecond - how much is consumed per second when flaring  
        //rarity?
        //toxicity?
        //test
        int BurnPerSecond { get; set; }
        int FlarePerSecond { get; set; }
        Push pushEffect { get; set; }
        Pull pullEffect { get; set; }


    }
}
