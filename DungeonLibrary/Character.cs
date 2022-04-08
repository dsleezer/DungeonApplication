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

        private string _name;
        private int _strength;
        private int _intelligence;
        private int _dexterity;
        private int _constitution;


        //PROPERTIES
        public string Name { get { return _name; } set { _name = value; } }
        public int Strength { get { return _strength; } set { _strength = value; } }
        public int Intelligence { get { return _intelligence ; } set { _intelligence = value; } }
        public int Dexterity { get { return _dexterity ; } set { _dexterity = value; } }
        public int Constitution { get { return _constitution; } set { _constitution = value; } }



        //CONSTRUCTORS
        public Character(string name, int strength, int intelligence, int dexterity, int constitution)
        {
            Name = name;
            Strength = strength;
            Intelligence = intelligence;
            Dexterity = dexterity;
            Constitution = constitution;
        }
        public Character() { }

        //METHODS

        public virtual int CalcBlock()
        {
            int blockChance = 10 + Dexterity + Strength;
            return blockChance;
        }
        public virtual int CalcHitChance()
        {
            return 0;
        }
        public virtual int CalcDamage()
        {
            return 0;
        }
    }
}
