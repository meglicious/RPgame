using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPgame
{
    public class Hero : Points
    {
        public int ExperiencePoints { get; set; }
        public int Level { get; set; }

        public Hero(int expreriencePoints, int level, int maximumHitPoints, int currentHitPoints) : base(MaxHitPoints, CurrentHitPoints)
        {
            ExperiencePoints = expreriencePoints;
            Level = level;
        }
    }
}