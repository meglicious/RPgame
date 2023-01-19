using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace RPgame
{
    public class Armor : Equip
    {

        public int AmountToHeal { get; set; }

        public Armor(int amountToHeal, string name) : base(name)
        {
            AmountToHeal = amountToHeal;
        }
    }
}

