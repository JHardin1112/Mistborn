using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mistborn.Models;

namespace Mistborn.Actions
{
    public interface IAllomanticActions
    {
        System.Timers.Timer timer {get;set;}
        public void BurnMetals(IConsumableMetal metal, IPlayer player, decimal unitsConsumed);
        public void StopBurn(System.Timers.Timer timer);
    }
}
