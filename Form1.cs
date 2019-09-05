using Mistborn.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mistborn.Actions;
using Mistborn.Models.Metals;

namespace Mistborn
{
    public partial class Form1 : Form
    {
        IAllomanticActions allomanticActions = new Mistborn.Actions.AllomanticActions();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var item in Enum.GetNames(typeof(ConsumableMetals.BasicMetals)))
            {
                lbMetals.Items.Add(item);
            }

        }

        private void BtnBurnStart_Click(object sender, EventArgs e)
        {
            IConsumableMetal bronze = new Models.Metals.Basic.Bronze();
            IPlayer Player = new Player
            {
                IsFlaring = true
            };
            var timer = new System.Timers.Timer();
            allomanticActions.timer = timer;
            allomanticActions.timer.Interval = (double)bronze.BurnRateInMilliseconds;
            allomanticActions.timer.Enabled = true;

            allomanticActions.BurnMetals(bronze, Player, 30);
        }

        private void BtnBurnStop_Click(object sender, EventArgs e)
        {
            //allomanticActions.timer.Stop();
            allomanticActions.StopBurn(allomanticActions.timer);
        }
    }
}
