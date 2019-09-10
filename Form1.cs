using Mistborn.Models;
using System;
using System.Windows.Forms;
using Mistborn.Actions;
using System.Reflection;
using System.Linq;

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
                comboBox1.Items.Add(item);
            }

        }

        private void BtnBurnStart_Click(object sender, EventArgs e)
        {
            string metalnamespace = "Mistborn.Models.Metals.Basic.";
            Type type = Type.GetType(metalnamespace + comboBox1.Text);
            IConsumableMetal metal = (IConsumableMetal)Activator.CreateInstance(type);

            IPlayer Player = new Player
            {
                IsFlaring = true
            };

            double burnRate = PropertyValue<double>(metal, "BurnRateInMilliseconds");

            var timer = new System.Timers.Timer();
            allomanticActions.timer = timer;
            allomanticActions.timer.Interval = burnRate;
            allomanticActions.timer.Enabled = true;

            allomanticActions.BurnMetals(metal, Player, Decimal.Parse(txtUnitsConsumed.Text.Trim()));
        }

        private void BtnBurnStop_Click(object sender, EventArgs e)
        {
            allomanticActions.StopBurn(allomanticActions.timer);
        }

        public static T PropertyValue<T>(object sender, string propertyName)
        {
            return (T)sender.GetType().GetProperty(propertyName).GetValue(sender, null);
        }

    }
}
