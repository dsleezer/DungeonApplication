﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Weapon
    {
        //FIELDS

        private int _maxDamage;
        private int _minDamage;
        private string _name;
        private int _bonusHitChance;
        private bool _isTwoHanded;

        //PROPERTIES

        public int MaxDamage { get { return _maxDamage; } set { _maxDamage = value; } }
        public string Name { get { return _name; } set { _name = value; } }
        public int BonusHitChance { get { return _bonusHitChance; } set { _bonusHitChance = value; } }
        public bool IsTwoHanded { get { return _isTwoHanded; } set { _isTwoHanded = value; } }
        public int MinDamage
        {
            get { return _minDamage; }
            set
            {
                if (MinDamage > MaxDamage)
                {
                    _minDamage = MaxDamage;
                }
                else
                {
                    _minDamage = value;
                }
            }
        }


        //CONSTRUCTORS

        public Weapon(int minDamage, int maxDamage, string name, int bonusHitChance, bool isTwoHanded)
        {
            MinDamage = minDamage;
            MaxDamage = maxDamage;
            Name = name;
            BonusHitChance = bonusHitChance;
            IsTwoHanded = isTwoHanded;
        }

        //METHODS
        public override string ToString()
        {
            return string.Format($"Name: {Name}\nDamage: {MinDamage}-{MaxDamage}\n" +
                $"Bonus: {BonusHitChance}\n{(IsTwoHanded == true ? "Two-Handed" : "One-Handed")}");
        }

    }
}