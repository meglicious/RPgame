using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPgame
{
    public class Warrior : Hero, Equip
    {
        public Weapon WeaponUsedWarrior { get; set; }
        public Warrior(string name, int expreriencePoints, int level, int maximumHitPoints, int currentHitPoints, var weaponUsedWarrior) : base(MaxHitPoints, CurrentHitPoints, name, expreriencePoints, level)
        {
            WeaponUsedWarrior = weaponUsedWarrior;
            Warrior.AddExperiencePoints();
            this.AttributeGain = (5, 2, 1, Warrior);
            addToAttributeGain();
            {
                this.AttributeGain(3, 2, 1);
                return this;
            }
            IWeapon GetWeapon();
            try
            {
                return new(Axe, Hammer, Sword(PopulateWeaponType));
            }
            catch (System.Exception)
            {
                GetWeapon = InvalidWeaponException();
                throw;
            }


            IArmor GetArmor();
            try
            {
                return new(Mail, Plate(PopulateArmorType));
            }
            catch (System.Exception)
            {
                GetArmor = InvalidArmorException();
                throw;
            }
        }
    }
}