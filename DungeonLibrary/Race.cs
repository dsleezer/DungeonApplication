using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Race
    {
        //FIELDS

        //PROPERTIES
        public string Name { get; set; }
        public int Strength { get; set; }
        public int Intelligence { get; set; }
        public int Dexterity { get; set; }
        public int Constitution { get; set; }
        public string Description { get; set; }


        //CONSTRUCTORS
        public Race(string name, int str, int intel, int dex, int con, string description)
        {
            Name = name;
            Strength = str;
            Intelligence = intel;
            Dexterity = dex;
            Constitution = con;
            Description = description;

        }
        public Race() { }
        //METHODS
        public override string ToString()
        {
            return $"-----{Name}-----\n\nStrength: +{Strength}\nIntelligence: +{Intelligence}\n" +
                $"Dexterity: +{Dexterity}\nConstitution: +{Constitution}\n\n{Description}\n\n";




        }
    }
}