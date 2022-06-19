using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class MovementWarehouse
    {
        public static int MapY(int mapY)
        {
            if (mapY == 1)
            {
                return 40;
            }
            else if (mapY == 2)
            {
                return 38;
            }
            else if (mapY == 3)
            {
                return 36;
            }
            else if (mapY == 4)
            {
                return 34;
            }
            else if (mapY == 5)
            {
                return 32;
            }
            else if (mapY == 6)
            {
                return 30;
            }
            else if (mapY == 7)
            {
                return 28;
            }
            else
                return 40;
        }
        public static int MapX(int mapX)
        {
            if (mapX == 1)
            {
                return 117;
            }
            else if (mapX == 2)
            {
                return 121;
            }
            else if (mapX == 3)
            {
                return 125;
            }
            else if (mapX == 4)
            {
                return 129;
            }
            else if (mapX == 5)
            {
                return 133;
            }
            else if (mapX == 6)
            {
                return 137;
            }
            else if (mapX == 7)
            {
                return 141;
            }
            else if (mapX == 8)
            {
                return 145;
            }
            else if (mapX == 9)
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
            Console.SetCursorPosition(MapX(player.Map.MapX),MapY(player.Map.MapY));
            Console.Write(" ");
            player.Map.MapY++;
            Console.SetCursorPosition(MapX(player.Map.MapX), MapY(player.Map.MapY));
            Console.Write("P");
        }
        public static void MoveSouth(Player player)
        {
            Console.SetCursorPosition(MapX(player.Map.MapX),MapY(player.Map.MapY));
            Console.Write(" ");
            player.Map.MapY--;
            Console.SetCursorPosition(MapX(player.Map.MapX), MapY(player.Map.MapY));
            Console.Write("P");
        }
        public static void MoveEast(Player player)
        {
            Console.SetCursorPosition(MapX(player.Map.MapX), MapY(player.Map.MapY));
            Console.Write(" ");
            player.Map.MapX++;
            Console.SetCursorPosition(MapX(player.Map.MapX), MapY(player.Map.MapY));
            Console.Write("P");
        }
        public static void MoveWest(Player player)
        {
            Console.SetCursorPosition(MapX(player.Map.MapX), MapY(player.Map.MapY));
            Console.Write(" ");
            player.Map.MapX-= 1;
            Console.SetCursorPosition(MapX(player.Map.MapX), MapY(player.Map.MapY));
            Console.Write("P");
        }
        public static void CurrentPosition(Player player)
        {
            Console.SetCursorPosition(MapX(player.Map.MapX), MapY(player.Map.MapY));
            Console.Write("P");
        }
        public static void BossPosition(Boss boss)
        {
            Console.SetCursorPosition(MapX(boss.Location.MapX), MapY(boss.Location.MapY));
            Console.Write("T");
        }

    }
}
