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
    public class AllomanticActions : IAllomanticActions
    {
        System.Timers.Timer _timer;
        IConsumableMetal Metal;
        IPlayer Player;
        decimal UnitsConsumed;

        public System.Timers.Timer timer { get; set; }

        public void BurnMetals(IConsumableMetal metal, IPlayer player, decimal unitsConsumed)
        {
            Metal = metal;
            Player = player;
            UnitsConsumed = unitsConsumed;

            timer.Elapsed += _timer_Elapsed;

            if (Player.IsFlaring)
            {
                UnitsConsumed -= Metal.FlareCost;
            }

            Console.WriteLine(Metal.ToString() + " Units Remaining: " + UnitsConsumed);

        }


        private void _timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (UnitsConsumed > 1)
            {
                UnitsConsumed -= Metal.BurnPerBurnRateInMilliseconds;
                Console.WriteLine(Metal.ToString() + " Units Remaining: " + UnitsConsumed);
            }
            else
            {
                Console.WriteLine(Metal.ToString() + " Extinguished!");
                _timer.Enabled = false;
            }

        }

        public void StopBurn(System.Timers.Timer timer)
        {
            timer.Stop();
            Console.WriteLine(Metal.ToString() + " Units Remaining: " + UnitsConsumed);
        }

    }
}
