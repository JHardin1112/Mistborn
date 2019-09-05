using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using Mistborn.Models;

namespace Mistborn.Actions
{
    public class AllomanticActions:IAllomanticActions
    {
        static System.Timers.Timer _timer;
        IConsumableMetal Metal;
        IPlayer Player;
        decimal UnitsConsumed;

        public void BurnMetals(IConsumableMetal metal, IPlayer player, decimal unitsConsumed)
        {
            Metal = metal;
            Player = player;
            UnitsConsumed = unitsConsumed;

            var timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.Elapsed += _timer_Elapsed;
            timer.Enabled = true;
            _timer = timer;

            if (Player.IsFlaring)
            {
                UnitsConsumed -= Metal.FlareCost;
            }

        }


        private void _timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (UnitsConsumed > 0)
            {
                UnitsConsumed -= Metal.BurnPerSecond;
                Console.WriteLine("Units Remaining: " + UnitsConsumed);
            }
        }

    }
}
