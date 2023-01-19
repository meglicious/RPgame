using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace RPgame
{
    public class AttributeGain : Equip
    {
        public string Strenght { get; set; }
        public string Dexterity { get; set; }
        public string Intelligence { get; set; }

        public AttributeGain(string strenght, string dexterity, string intelligence, string name) : base(name)
        {
            Strenght = strenght;
            Dexterity = dexterity;
            Intelligence = intelligence;

            DamagingAttribute = AttributeGain + amountToHeal;
        }

    }
}