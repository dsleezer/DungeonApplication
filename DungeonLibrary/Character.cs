using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public abstract class Character
    {
        //FIELDS
        private int _currentHealth
        //PROPERTIES
        public string Name { get; set; }
        public int Exp { get; set; }
        public int Strength { get; set; }
        public int Intelligence { get; set; }
        public int Dexterity { get; set; }
        public int Constitution { get; set; }
        public int MaxHealth { get; set; }
        public int CurrentHealth
        {
            get { return _currentHealth; }
            set
            {
                if (value > MaxHealth)
                {
                    _currentHealth = MaxHealth;
                }
                else
                {
                    _currentHealth = value;
                }
            }
        }
        public int Armor { get; set; }


        //CONSTRUCTORS
        public Character(string name, int strength, int intelligence, int dexterity, int constitution)
        {
            Name = name;
            Strength = strength;
            Intelligence = intelligence;
            Dexterity = dexterity;
            Constitution = constitution;
            MaxHealth = 1;
            CurrentHealth = 1;
            Exp = 0;
            Armor = 0;
        }

        //METHODS

        public virtual int CalcBlock()
        {
            return 0;
        }
        public virtual int CalcHitChance()
        {
            return 0;
        }
        public virtual int CalcDamage()
        {
            return 0;
        }
        public virtual int CalcInitiative()
        {
            return 0;
        }
    }
}
