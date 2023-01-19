using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static RPgame.Weapon;

namespace RPgame
{
    public class Ranger : Hero, Equip
    {
        public List<WeaponType> weaponName { get; set; }
        public Weapon WeaponUsedRanger { get; set; }
        public Ranger(string name, int expreriencePoints, int level, int maximumHitPoints, int currentHitPoints, var weaponUsedRanger) : base(MaxHitPoints, CurrentHitPoints, name, expreriencePoints, level)
        {
            WeaponUsedRanger = weaponUsedRanger;
            weaponName = new List<WeaponType>();
            this.AttributeGain = (1, 7, 1, Ranger);
            addToAttributeGain();
            {
                this.AttributeGain(1, 5, 1);
                return this;
            }
            Ranger.AddExperiencePoints();
            IWeapon GetWeapon();
            try
            {
                return new Bow(PopulateWeaponType);
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