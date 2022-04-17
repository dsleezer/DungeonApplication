using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class SoundWarehouse
    {
        public static void PlaySong()
        {
            Console.Beep(987, 153);
            Console.Beep(987, 153);
            Console.Beep(987, 153);
            Console.Beep(987, 900);
            Console.Beep(784, 900);
            Console.Beep(880, 900);
            Console.Beep(987, 700);
            Console.Beep(880, 300);
            Console.Beep(987, 700);
            Thread.Sleep(500);
        }


    }
}
