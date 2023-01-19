using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace RPgame
{
    public class Equip
    {
        public string Name { get; set; }
        public Equip(string name)
        {
            Name = name;
        }
        public int Level
        {
            get { return ((ExperiencePoints / 100) + 1); }
        }
    }
}