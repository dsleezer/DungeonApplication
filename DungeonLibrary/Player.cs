using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Player : Character
    {
        //FIELDS

        private int _currentHealth;
        private int _maxHealth;
        private int _armor;


        //PROPERTIES
        public PlayerClass PClass { get; set; }
        public Race PRace { get; set; }
        public Weapon EquippedWeapon { get; set; }
        public int Level { get; set; }
        public int Armor
        {
            get { return _armor; }
            set
            {
                if(PClass.Name == "warrior")
                {
                _armor = value + Strength;
                }
                else if(PClass.Name == "Ranger" || PClass.Name == "Rogue")
                {
                    _armor = value + Dexterity;
                }
                else
                {
                    _armor = value + 11;
                }
            }
        }
        public int MaxHealth
        {
            get { return _maxHealth; }
            set
            {
                _maxHealth = value + PClass.HealthModifier * Level + (Constitution - 10) / 2;
            }
        }
        public int CurrentHealth
        {
            get { return _currentHealth; }
            set
            {
                _currentHealth = MaxHealth;
            }
        }

        //CONSTRUCTORS
        public Player(string name, PlayerClass pClass, Race pRace, int strength, int intelligence, int dexterity, int constitution) : base(name, strength, intelligence, dexterity, constitution)
        {
            Name = name;
            PClass = pClass;
            PRace = pRace;
            Level = 1;
            Exp = 0;
            EquippedWeapon = PClass.EqWeapon;
            Strength = strength + PClass.Strength + PRace.Strength;
            Intelligence = intelligence + PClass.Intelligence + PRace.Intelligence;
            Dexterity = dexterity + PClass.Dexterity + PRace.Dexterity;
            Constitution = constitution + PClass.Constitution + PRace.Constitution;
            MaxHealth = 20;
            CurrentHealth = 20;
            Armor = 0;

        }

        //METHODS
        Random randomNbrGen = new Random();
        public override int CalcBlock()
        {
            return Armor;
        }
        public override int CalcHitChance()
        {
            int roll = randomNbrGen.Next(1, 21);

            if (PClass.Name.ToLower() == "warrior")
            {
                return roll + EquippedWeapon.BonusHitChance + ((Strength - 10) / 2);
            }
            else if (PClass.Name.ToLower() == "wizard")
            {
                return roll + EquippedWeapon.BonusHitChance + ((Intelligence - 10) / 2);
            }
            else if (PClass.Name.ToLower() == "rogue" || PClass.Name.ToLower() == "ranger")
            {
                return roll + EquippedWeapon.BonusHitChance + ((Dexterity - 10) / 2);
            }
            else
            {
                return 0;
            }
        }
        public override int CalcDamage()
        {
            int roll = randomNbrGen.Next(EquippedWeapon.MinDamage, EquippedWeapon.MaxDamage + 1);

            if (PClass.Name.ToLower() == "warrior")
            {
                return roll + ((Strength - 10) / 2);
            }
            else if (PClass.Name.ToLower() == "wizard")
            {
                return roll + ((Intelligence - 10) / 2);
            }
            else if (PClass.Name.ToLower() == "rogue")
            {
                return roll + ((Dexterity - 10) / 2);
            }
            else if (PClass.Name.ToLower() == "ranger")
            {
                return roll + ((Dexterity - 10) / 2);
            }
            else
            {
                return 0;
            }
        }
        public override int CalcInitiative()
        {
            int roll = randomNbrGen.Next(1, 21);

            return roll + ((Dexterity - 10) / 2);
        }
        public override string ToString()
        {
            return $"\n------------------\nName: {Name}\nLevel {Level} {PClass.Name}\nHealth: {CurrentHealth} / {MaxHealth}\n" +
                $"Race: {PRace.Name}\nArmor: {Armor}\nWeapon: {EquippedWeapon.Name}" +
                $"Attributes\n\nStrength: {Strength}\nIntelligence: {Intelligence}\n" +
                $"Dexterity: {Dexterity}\nConstitution: {Constitution}\nExperience: {Exp} / {((Level == 10) ? "1000" : (Level * 100))}";
        }
    }
}
