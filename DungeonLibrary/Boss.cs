using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Boss : Monster
    {
         public MapCoordinates Location { get; set; }

        Random randomNbrGen = new Random();
        public Boss(string name, int str, int intel, int dex, int con, int maxH, int curH, int minD, int maxD, int hit, int armor, int exp, string type, string description ) : base(name, str, intel, dex, con, maxH, curH, minD, maxD, hit, armor, exp, type, description   )
        {
            Location = new MapCoordinates(randomNbrGen.Next(1, 9), randomNbrGen.Next(1, 7));

        }


    }
}
