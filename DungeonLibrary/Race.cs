using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Race : Character
    {
        //FIELDS
        private string _description;

        //PROPERTIES
        public string Description { get; set; }

        //CONSTRUCTORS
        public Race(string name, int str, int intel, int dex, int con, string description) : base (name, str, intel, dex, con)
        {
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
