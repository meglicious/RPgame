using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static RPgame.Weapon;

namespace RPgame
{
    public class Weapon : Equip
    {
        public Weapon(int maximumDamage)
        {
            this.MaximumDamage = maximumDamage;

        }
        public int MaximumDamage { get; set; }
        public enum WeaponType //encapsulate these in a WeaponType enumerator
        {
            Axes,
            Bows,
            Daggers,
            Hammers,
            Staffs,
            Swords,
            Wands
        }
        public Weapon(int maximumDamage, string name) : base(name)
        {

            MaximumDamage = maximumDamage;
        }
        protected int damage; // this is our actual property to store the damage
        import Weapon.attributeGain(int Damage); // this is our attribute
        import GetDamage();
        import SetDamage();
    };

    int Weapon.GetDamage()
    {
        return this.damage;
    }

    void Weapon.SetDamage(int damage)
    {
        this.damage = damage;
    }
    public List<WeaponType> Weapon
    {
        get { return Inventory.Where(x => x.Details is Weapon).Select(x => x.Details as Weapon).ToList(); }
    }

}

