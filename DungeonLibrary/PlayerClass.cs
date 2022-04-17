using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public sealed class PlayerClass : Race
    {
        //FIELDS

        //PROPERTIES
        public int HealthModifier { get; set; }
        public Weapon EqWeapon { get; set; }


        //CONSTRUCTORS
        public PlayerClass(string name, int str, int intel, int dex, int con, int healthModifier, Weapon eqWeapon, string description) : base(name, str, intel, dex, con, description)
        {
            HealthModifier = healthModifier;
            EqWeapon = eqWeapon;
        }
        public PlayerClass() { }
        //METHODS
        public override string ToString()
        {
            return $"-------{Name}-------\n\nStrength: +{Strength}\nIntelligence: +{Intelligence}\n" +
                $"Dexterity: +{Dexterity}\nConstitution: +{Constitution}\nHealthModifier: {HealthModifier}\n\n{Description}\n\n";
        }


    }
}