using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mistborn.Models
{
    public interface IPlayer
    {
        decimal HP { get; set; }
        decimal Strength { get; set; }
        decimal MoveSpeed { get; set; }
        decimal InventorySlots { get; set; }
        bool IsFlaring { get; set; }
    }
}
