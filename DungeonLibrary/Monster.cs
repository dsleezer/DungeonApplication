using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Monster : Character
    {
        //FIELDS
        private int _minDamage;

        //PROPERTIES
        public string Description { get; set; }
        public int MaxDamage { get; set; }
        public int MinDamage
        {
            get { return _minDamage; }

            set
            {
                if(value > 0 && value <= MaxDamage)
                {
                    _minDamage = value;
                }
                else
                {
                    _minDamage = 1;
                }
            }

        }
        public int BonusHit { get; set; }
        public string Type { get; set; }

        //CONSTRUCTORS
        public Monster(string name, int str, int intel, int dex, int con, int maxH, int curH, int minD, int maxD, int hit, int armor, int exp, string type, string description) : base(name, str, intel, dex, con)
        {
            MaxHealth = maxH;
            CurrentHealth = curH;
            Description = description;
            MaxDamage = maxD;
            MinDamage = minD;
            BonusHit = hit;
            Type = type;
            Armor = armor;
            Exp = exp;
        }


        //METHODS
        Random randomNbrGen = new Random();

        public override int CalcHitChance()
        {
            int roll = randomNbrGen.Next(1, 21);

            if (Type == "Strength")
            {
                return roll + BonusHit + ((Strength - 10) / 2);
            }
            else if (Type == "Dexterity")
            {
                return roll + BonusHit + ((Intelligence - 10) / 2);
            }
            else if (Type == "Intelligence")
            {
                return roll + BonusHit + ((Dexterity - 10) / 2);
            }
            else
            {
                return 0;
            }

        }
        public override int CalcDamage()
        {
            int roll = randomNbrGen.Next(MinDamage, MaxDamage + 1);

            if (Type == "Strength")
            {
                return roll + ((Strength - 10) / 2);
            }
            else if (Type == "Intelligence")
            {
                return roll + ((Intelligence - 10) / 2);
            }
            else if (Type == "Dexterity")
            {
                return roll + ((Dexterity - 10) / 2);
            }
            else
            {
                return 0;
            }
        }
        public override int CalcBlock()
        {

            if (Type == "Strength")
            {
                return Armor + ((Strength - 10) / 2);
            }
            else if (Type == "Dexterity")
            {
                return Armor + ((Dexterity - 10) / 2);
            }
            else
            {
                return Armor;
            }
        }
        public override int CalcInitiative()
        {
            int roll = randomNbrGen.Next(1, 21);

            return roll + ((Dexterity - 10) / 2);
        }

        public override string ToString()
        {
            return $"-----{Name}-----\n\nHealth: {CurrentHealth} / {MaxHealth}\nFavored Attribute: {Type}\nAverage Damage: {(MinDamage+MaxDamage)/2}\nStrength: +{Strength}\nIntelligence: +{Intelligence}\n" +
                $"Dexterity: +{Dexterity}\nConstitution: +{Constitution}\n\n{Description}\n\n";
        }

    }
}
