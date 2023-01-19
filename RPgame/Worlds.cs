using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static RPgame.Weapon;

namespace RPgame
{
    public static class World
    {
        public static readonly List<WeaponType> Items = new List<WeaponType>();
        public static readonly List<ArmorType> Protection = new List<ArmorType>();
        public static readonly List<AttributeList> Power = new List<AttributeList>();


        public const string WeaponType_Axes = Axe;
        public const string WeaponType_Bows = Bow;
        public const string WeaponType_Daggers = Dagger;
        public const string WeaponType_Hammers = Hammer;
        public const string WeaponType_Staffs = Staff;
        public const string WeaponType_Swords = Sword;
        public const string WeaponType_Wands = Wand;

        public const string ArmorType_Cloth = Cloth;
        public const string ArmorType_Leather = Leather;
        public const string ArmorType_Mail = Mail;
        public const string ArmorType_Plate = Plate;

        public const int AttributeList_Strength = Strength;
        public const int AttributeList_Dexterity = Dexterity;
        public const int AttributeList_Intelligence = Intelligence;

        static World()
        {
            PopulateWeaponType();
            PopulateArmorType();
            PopulateAttributeList();

        }

        private static void PopulateWeaponType()
        {
            Items.Add(new Weapon(5, WeaponType_Axes));
            Items.Add(new Weapon(2, WeaponType_Bows));
            Items.Add(new Weapon(2, WeaponType_Daggers));
            Items.Add(new Weapon(2, WeaponType_Hammers));
            Items.Add(new Weapon(2, WeaponType_Staffs));
            Items.Add(new Weapon(5, WeaponType_Swords));
            Items.Add(new Weapon(5, WeaponType_Wands));

        }

        private static void PopulateArmorType()
        {
            Protection.Add(new Armor(1, ArmorType_Cloth));
            Protection.Add(new Armor(2, ArmorType_Leather));
            Protection.Add(new Armor(2, ArmorType_Mail));
            Protection.Add(new Armor(1, ArmorType_Plate));
        }

        private static void PopulateAttributeList()
        {
            Power.Add(new AttributeGain(1, AttributeList_Strength));
            Power.Add(new AttributeGain(1, AttributeList_Dexterity));
            Power.Add(new AttributeGain(1, AttributeList_Intelligence));
        }

        public static Weapon ItemByName(string name)
        {
            foreach (Weapon name in Items)
            {
                if (weapon.name == name)
                {
                    return Weapon;
                }
            }

            return null;
        }

        public static Armor MonsterByName(string name)
        {
            foreach (Armor name in Protection)
            {
                if (armor.name == name)
                {
                    return Armor;
                }
            }

            return null;
        }

        public static AttributeGain QuestByName(string name)
        {
            foreach (AttributeGain name in Power)
            {
                if (attributegain.name == name)
                {
                    return AttributeGain;
                }
            }

            return null;
        }
    }
}
