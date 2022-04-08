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
        public string Name { get; set; }
        public int Strength { get; set; }
        public int Intelligence { get; set; }
        public int Dexterity { get; set; }
        public int Constitution { get; set; }
        public PlayerClass PClass { get; set; }
        public Race PRace { get; set; }
        public Weapon EquippedWeapon { get; set; }
        public int Armor 
        { 
            get { return _armor; } 
            set 
            {
                _armor = value + (Dexterity - 10) + (Strength - 10);
            } 
        }
        public int MaxHealth
        {
            get { return _maxHealth; }
            set
            {
                _maxHealth = value + (PClass.HealthModifier * ((Constitution - 10) / 2));
            }
        }
        public int CurrentHealth
        {
            get { return _currentHealth; }
            set
            {
                _currentHealth = value + (PClass.HealthModifier * ((Constitution - 10) / 2));
            }
        }
        
        //CONSTRUCTORS
        public Player(string name, PlayerClass pClass, Race pRace, Weapon eqWeapon, int strength, int intelligence, int dexterity, int constitution) : base(name, strength, intelligence, dexterity, constitution)
        {
            Name = name;
            PClass = pClass;
            PRace = pRace;
            EquippedWeapon = eqWeapon;
            Strength = strength + pClass.Strength + pRace.Strength;
            Intelligence = intelligence + pClass.Intelligence + pRace.Intelligence;
            Dexterity = dexterity + pClass.Dexterity + pRace.Dexterity;
            Constitution = constitution + pClass.Constitution + pRace.Constitution;
            MaxHealth = 20;
            CurrentHealth = 20;
            Armor = 10;
            EquippedWeapon = pClass.EqWeapon;

        }
        public Player() { }

        //METHODS
        Random randomNbrGen = new Random();
        public override int CalcDamage()
        {
            int roll = randomNbrGen.Next(1, 21);

            if (PClass.Name.ToLower() == "warrior")
            {
                return randomNbrGen.Next(EquippedWeapon.MinDamage, EquippedWeapon.MaxDamage) + ((Strength - 10) / 2);
            }
            else if (PClass.Name.ToLower() == "wizard")
            {
                return randomNbrGen.Next(EquippedWeapon.MinDamage, EquippedWeapon.MaxDamage) + ((Intelligence - 10) / 2);
            }
            else if (PClass.Name.ToLower() == "rogue")
            {
                return randomNbrGen.Next(EquippedWeapon.MinDamage, EquippedWeapon.MaxDamage) + ((Dexterity - 10) / 2);
            }
            else if (PClass.Name.ToLower() == "ranger")
            {
                return randomNbrGen.Next(EquippedWeapon.MinDamage, EquippedWeapon.MaxDamage) + ((Dexterity - 10) / 2);
            }
            else
            {
                return 0;
            }
        }
        public override int CalcHitChance()
        {
            int roll = randomNbrGen.Next(1, 21);

            if (PClass.Name.ToLower() == "warrior")
            {
                return roll + EquippedWeapon.BonusHitChance + ((Strength - 10) / 2);
            }
            else if(PClass.Name.ToLower() == "wizard")
            {
                return roll + EquippedWeapon.BonusHitChance + ((Intelligence - 10) / 2);
            }
            else if(PClass.Name.ToLower() == "rogue")
            {
                return roll + EquippedWeapon.BonusHitChance + ((Dexterity - 10) / 2);
            }
            else if(PClass.Name.ToLower() == "ranger")
            {
                return roll + EquippedWeapon.BonusHitChance + ((Dexterity - 10) / 2);
            }
            else
            {
                return 0;
            }
        }
        public override string ToString()
        {
            return $"\n------------------\nName: {Name}\nHealth: {CurrentHealth} / {MaxHealth}\nRace: {PRace.Name}\n" +
                $"Class: {PClass.Name}\nArmor: {Armor}\nWeapon: {EquippedWeapon.Name}" +
                $"Attributes\n\nStrength: {Strength}\nIntelligence: {Intelligence}\n" +
                $"Dexterity: {Dexterity}\nConstitution: {Constitution}";
        }
    }
}
