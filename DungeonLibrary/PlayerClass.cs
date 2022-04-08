using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class PlayerClass
    {
        //FIELDS
        private string _name;
        private int _strength;
        private int _intelligence;
        private int _dexterity;
        private int _constitution;
        private int _healthModifier;
        private string _description;
        private Weapon _eqWeapon;

        //PROPERTIES
        public string Name { get { return _name; } set { _name = value; } }
        public int Strength { get { return _strength; } set { _strength = value; } }
        public int Intelligence { get { return _intelligence; } set { _intelligence = value; } }
        public int Dexterity { get { return _dexterity; } set { _dexterity = value; } }
        public int Constitution { get { return _constitution; } set { _constitution = value; } }
        public int HealthModifier { get { return _healthModifier; } set { _healthModifier = value; } }
        public string Description { get { return _description; } set { _description = value; } }
        public Weapon EqWeapon { get { return _eqWeapon; } set { _eqWeapon = value;} }


        //CONSTRUCTORS
        public PlayerClass(string name, int str, int intel, int dex, int con, int healthModifier, Weapon eqWeapon, string description)
        {
            Name = name;
            Strength = str;
            Intelligence = intel;
            Dexterity = dex;
            Constitution = con;
            HealthModifier = healthModifier;
            Description = description;
            EqWeapon = eqWeapon;
        }
        public PlayerClass() { }

        //METHODS
        public override string ToString()
        {
            return $"-----{Name}-----\n\nStrength: +{Strength}\nIntelligence: +{Intelligence}\n" +
                $"Dexterity: +{Dexterity}\nConstitution: +{Constitution}\nHealthModifier: {HealthModifier}\n\n{Description}\n\n";
        }


    }
}
