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
                return 117;
            }
            else if (player.Map.MapX == 2)
            {
                return 121;
            }
            else if (player.Map.MapX == 3)
            {
                return 125;
            }
            else if (player.Map.MapX == 4)
            {
                return 129;
            }
            else if (player.Map.MapX == 5)
            {
                return 133;
            }
            else if (player.Map.MapX == 6)
            {
                return 137;
            }
            else if (player.Map.MapX == 7)
            {
                return 141;
            }
            else if (player.Map.MapX == 8)
            {
                return 145;
            }
            else if (player.Map.MapX == 9)
            {
                return 149;
            }
            else
            {
                return 117;
            }
        }
        public static void MoveNorth(Player player)
        {
            Console.SetCursorPosition(MapX(player),MapY(player));
            Console.Write(" ");
            player.Map.MapY++;
            Console.SetCursorPosition(MapX(player), MapY(player));
            Console.Write("P");
        }
        public static void MoveSouth(Player player)
        {
            Console.SetCursorPosition(MapX(player),MapY(player));
            Console.Write(" ");
            player.Map.MapY--;
            Console.SetCursorPosition(MapX(player), MapY(player));
            Console.Write("P");
        }
        public static void MoveEast(Player player)
        {
            Console.SetCursorPosition(MapX(player), MapY(player));
            Console.Write(" ");
            player.Map.MapX++;
            Console.SetCursorPosition(MapX(player), MapY(player));
            Console.Write("P");
        }
        public static void MoveWest(Player player)
        {
            Console.SetCursorPosition(MapX(player), MapY(player));
            Console.Write(" ");
            player.Map.MapX-= 1;
            Console.SetCursorPosition(MapX(player), MapY(player));
            Console.Write("P");
        }
        public static void CurrentPosition(Player player)
        {
            Console.SetCursorPosition(MapX(player), MapY(player));
            Console.Write("P");
        }

    }
}
