

using System.Runtime.InteropServices;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Reflection.Emit;
using System.Threading;

namespace RPgame
{
    public class RPgame : Hero
    {
        public RPgame()
        {
            initializeComponent();
            Mage = new Hero(0, 1, 10, 20);
            Warrior = new Hero(0, 1, 18, 30);
            Ranger = new Hero(0, 1, 12, 10);
            Rogue = new Hero(0, 1, 10, 10);


            lblHitPoints.Text = _player.CurrentHitPoints.ToString();
            lblGold.Text = _player.Gold.ToString();
            lblExperience.Text = _player.ExperiencePoints.ToString();
            lblLevel.Text = _player.Level.ToString();

            bool IsPlayerStillAlive1(int currentHitPoints)
            {
                if (currentHitPoints > 0)
                {
                    return true;
                }
                return false;
            }

            int ComputeHeroLevel(int experiencePoints)
            {
                if (experiencePoints < 100)
                {
                    return 1; // Player is level 1
                }
                else if (experiencePoints < 250)
                {
                    return 2; // Player is level 2
                }
                else if (experiencePoints < 500)
                {
                    return 3; // Player is level 3
                }
                else if (experiencePoints < 1000)
                {
                    return 4; // Player is level 4
                }
                return 5; // The maximum level is 5, in this sample
            }

        }
        public int ExperiencePoints
        {
            get { return _experiencePoints; }
            private set
            {
                _experiencePoints = value;

            }
        }
        public void AddExperiencePoints(int experiencePointsToAdd)
        {

            if (Monster.MaximumHitPoints = 50)
            {
                ExperiencePoints = rewardExperiencePoints(100);
            }
            if (DamagingAttribute = 30)
            {
                ExperiencePoints++;
            }
            if (HeroDamage = 80)
            {
                ExperiencePoints--;
            }
            ExperiencePoints += experiencePointsToAdd;
            MaximumHitPoints = (Level * 10);
        }
        public int HeroDamage()
        {
            return ((WeaponDamage * (1 + DamagingAttribute / 100)));
        }

    }
}