using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace RPgame
{
    public class Mage : Hero, Equip
    {

        public Weapon WeaponUsedMage { get; set; }
        public Mage(string name, int expreriencePoints, int level, int maximumHitPoints, int currentHitPoints, var weaponUsedMage) : base(MaxHitPoints, CurrentHitPoints, name, expreriencePoints, level)
        {
            WeaponUsedMage = weaponUsedMage;
            Mage.AddExperiencePoints();

            this.AttributeGain = (1, 1, 8, Mage);
            addToAttributeGain();
            {
                this.AttributeGain(1, 1, 5);
                return this;
            }
            IWeapon GetWeapon();
            try
            {
                return new(Staff, Wand(PopulateWeaponType));
            }
            catch (System.Exception)
            {
                GetWeapon = InvalidWeaponException();
                throw;
            }

            IArmor GetArmor();
            try
            {
                return new Cloth(PopulateArmorType);
            }
            catch (System.Exception)
            {
                GetArmor = InvalidArmorException();
                throw;
            }

        }
    }
}