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
        public void BurnMetals(IConsumableMetal metal, IPlayer player, decimal unitsConsumed);
    }
}
