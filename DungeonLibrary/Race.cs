﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Race
    {
        //FIELDS
        private string _name;
        private int _strength;
        private int _intelligence;
        private int _dexterity;
        private int _constitution;
        private string _description;

        //PROPERTIES
        public string Name { get { return _name; } set { _name = value; } }
        public int Strength { get { return _strength; } set { _strength = value; } }
        public int Intelligence { get { return _intelligence; } set { _intelligence = value; } }
        public int Dexterity { get { return _dexterity; } set { _dexterity = value; } }
        public int Constitution { get { return _constitution; } set { _constitution = value; } }
        public string Description { get { return _description; } set { _description = value; } }

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
