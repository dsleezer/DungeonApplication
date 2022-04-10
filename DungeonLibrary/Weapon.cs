using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Weapon
    {
        //FIELDS

        private int _minDamage;
    
        //PROPERTIES

        public int MaxDamage { get; set; }
        public string Name { get; set; }
        public int BonusHitChance { get; set; }
        public bool IsTwoHanded { get; set; }
        public WeaponType WeaponType { get; set; }
        public int BonusDamage { get; set; }
        public int MinDamage
        {
            get { return _minDamage; }
            set
            {
                if (MinDamage > MaxDamage)
                {
                    _minDamage = MaxDamage;
                }
                else
                {
                    _minDamage = value;
                }
            }
        }

        //CONSTRUCTORS

        public Weapon(string name, int minDamage, int maxDamage, int bonusHitChance, int bonusDamage, bool isTwoHanded, WeaponType type)
        {
            MinDamage = minDamage;
            MaxDamage = maxDamage;
            Name = name;
            BonusHitChance = bonusHitChance;
            IsTwoHanded = isTwoHanded;
            WeaponType = type;
            BonusDamage = bonusDamage;
        }

        //METHODS
        public override string ToString()
        {
            return string.Format($"Name: {Name}\nType: {WeaponType}\nDamage: {MinDamage}-{MaxDamage}\n" +
                $"Bonus: {BonusHitChance}\n{(IsTwoHanded == true ? "Two-Handed" : "One-Handed")}");
        }

    }
}