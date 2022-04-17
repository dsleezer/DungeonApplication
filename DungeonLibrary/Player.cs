using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public sealed class Player : Character
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
        public MapCoordinates Map { get; set; }
        public int Armor
        {
            get { return _armor; }
            set
            {
                if(PClass.Name == "Warrior")
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
                _maxHealth = value + PClass.HealthModifier + (Constitution - 10) / 2;
            }
        }
        public int CurrentHealth
        {
            get { return _currentHealth; }
            set
            {
                //if(value > MaxHealth)
                //{
                //_currentHealth = MaxHealth;
                //}
                //else
                //{
                    _currentHealth = value;
                //}
            }
        }

        //CONSTRUCTORS
        public Player(string name, PlayerClass pClass, Race pRace, int strength, int intelligence, int dexterity, int constitution, MapCoordinates map) : base(name, strength, intelligence, dexterity, constitution)
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
            MaxHealth = 10;
            CurrentHealth = MaxHealth;
            Armor = 0;
            Map = map;
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
            return $"------{((Name == "" )? "-------" : Name)}------\n\nLevel {Level} {PClass.Name}\nHealth: {CurrentHealth} / {MaxHealth}\n" +
                $"Race: {PRace.Name}\nArmor: {Armor}\nWeapon: {EquippedWeapon.Name}\n\n" +
                $"Attributes\n\nStrength: {Strength}\nIntelligence: {Intelligence}\n" +
                $"Dexterity: {Dexterity}\nConstitution: {Constitution}\nExperience: {Exp} / {((Level == 10) ? "1000" : (Level * 100))}";
        }
    }
}
