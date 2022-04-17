using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class MovementWarehouse
    {
        public static int MapY(Player player)
        {
            if (player.Map.MapY == 1)
            {
                return 40;
            }
            else if (player.Map.MapY == 2)
            {
                return 38;
            }
            else if (player.Map.MapY == 3)
            {
                return 36;
            }
            else if (player.Map.MapY == 4)
            {
                return 34;
            }
            else if (player.Map.MapY == 5)
            {
                return 32;
            }
            else if (player.Map.MapY == 6)
            {
                return 30;
            }
            else if (player.Map.MapY == 7)
            {
                return 28;
            }
            else
                return 40;
        }
        public static int MapX(Player player)
        {
            if (player.Map.MapX == 1)
            {
                return 119;
            }
            else if (player.Map.MapX == 2)
            {
                return 123;
            }
            else if (player.Map.MapX == 3)
            {
                return 127;
            }
            else if (player.Map.MapX == 4)
            {
                return 131;
            }
            else if (player.Map.MapX == 5)
            {
                return 135;
            }
            else if (player.Map.MapX == 6)
            {
                return 139;
            }
            else if (player.Map.MapX == 7)
            {
                return 143;
            }
            else if (player.Map.MapX == 8)
            {
                return 147;
            }
            else if (player.Map.MapX == 9)
            {
                return 151;
            }
            else
            {
                return 119;
            }

        }
        public static void MoveUp(Player player)
        {
            Console.SetCursorPosition(MapX(player),MapY(player));
            Console.Write(" ");
            player.Map.MapY++;
            Console.SetCursorPosition(MapX(player), MapY(player));
            Console.Write("P");
        }
        public static void MoveDown(Player player)
        {
            Console.SetCursorPosition(MapX(player),MapY(player));
            Console.Write(" ");
            player.Map.MapY--;
            Console.SetCursorPosition(MapX(player), MapY(player));
            Console.Write("P");
        }
        public static void MoveRight(Player player)
        {
            Console.SetCursorPosition(MapX(player),MapY(player));
            Console.Write(" ");
            player.Map.MapX++;
            Console.SetCursorPosition(MapX(player), MapY(player));
            Console.Write("P");
        }
        public static void MoveLeft(Player player)
        {
            Console.SetCursorPosition(MapX(player),MapY(player));
            Console.Write(" ");
            player.Map.MapX--;
            Console.SetCursorPosition(MapX(player), MapY(player));
            Console.Write("P");
        }

    }
}
