using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;
namespace Dungeon
{
    internal class TestBed
    {
        static void Main(string[] args)
        {            
            Character c1 = new Character("Tain", 20, 20, 100, 120);

            Console.WriteLine(c1);

            Weapon w1 = new Weapon(2, 12, "Greatsword", 3, true);

            Console.WriteLine(w1);



        }
    }
}
