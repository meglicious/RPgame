using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace RPgame
{
    public class Monster : Points, Equip
    {
        public int MaximumDamage { get; set; }
        public int RewardExperiencePoints { get; set; }


        public Monster(int maximumDamage, int rewardExperiencePoints, int maximumHitPoints, int currentHitPoints, string name) : base(maximumHitPoints, currentHitPoints, name)
        {
            MaximumDamage = maximumDamage = 20;
            RewardExperiencePoints = rewardExperiencePoints();

        }
    }
}