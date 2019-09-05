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

        private void BtnBurn_Click(object sender, EventArgs e)
        {
            IAllomanticActions allomanticActions = new Mistborn.Actions.AllomanticActions();

            IConsumableMetal bronze = new Models.Metals.Basic.Bronze();
            IPlayer Player = new Player();
            Player.IsFlaring = true;

            bronze.BurnPerSecond = 2.0M;
            bronze.FlareCost = 10.0M;

            allomanticActions.BurnMetals(bronze, Player, 30);
        }
    }
}
