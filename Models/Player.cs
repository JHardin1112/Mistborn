using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mistborn.Models
{
    public class Player : IPlayer
    {
        public decimal HP { get; set; }
        public decimal Strength { get; set; }
        public decimal MoveSpeed { get; set; }
        public decimal InventorySlots { get; set; }
        public bool IsFlaring { get; set; }
    }


}
