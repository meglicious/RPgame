using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPgame
{
    public class Rogue : Hero, Equip
    {
        public Weapon WeaponUsedRogue { get; set; }

        public Rogue(string name, int expreriencePoints, int level, int maximumHitPoints, int currentHitPoints, var weaponUsedRogue) : base(MaxHitPoints, CurrentHitPoints, name, expreriencePoints, level)
        {
            WeaponUsedRogue = weaponUsedRogue;
            Rogue.AddExperiencePoints();
            this.AttributeGain = (2, 6, 1, Rogue);
            addToAttributeGain();
            {
                this.AttributeGain(1, 4, 1);
                return this;
            }
            IWeapon GetWeapon();
            try
            {
                return new(Dagger, Sword(PopulateWeaponType));
            }
            catch (System.Exception)
            {
                GetWeapon = InvalidWeaponException();
                throw;
            }

            IArmor GetArmor();
            try
            {
                return new(Leather, Mail(PopulateArmorType));
            }
            catch (System.Exception)
            {
                GetArmor = InvalidArmorException();
                throw;
            }
        }
    }
}

