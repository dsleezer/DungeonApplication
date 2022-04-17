using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class DispWarehouse
    {
        #region PlayerDisplay
        /// <summary>
        /// Displays the Player ToString in a box on the screen.
        /// </summary>
        /// <param name="mainPlayer">The active player to be displayed</param>
        public static void ShowPlayer(Player mainPlayer)
        {
            //Player Stats
            // bottom left coordinate x=5,y=43
            //bottom right coordinate x=30,y=43
            //top left coordinate x=5,y=25
            //top right coordinate x=30,y=25
            const int MENU_START_X = 5;
            const int MENU_END_X = 30;
            const int MENU_LOWER_Y = 42;
            const int MENU_UPPER_Y = 24;
            Console.ForegroundColor = ConsoleColor.Green;
            for (int i = MENU_UPPER_Y; i <= MENU_LOWER_Y; i++)
            {
                Console.SetCursorPosition(MENU_START_X, i);
                Console.WriteLine("║");
            };
            for (int i = MENU_UPPER_Y; i <= MENU_LOWER_Y; i++)
            {
                Console.SetCursorPosition(MENU_END_X, i);
                Console.WriteLine("║");
            };
            for (int i = MENU_START_X; i <= MENU_END_X; i++)
            {
                Console.SetCursorPosition(i, MENU_LOWER_Y);
                Console.WriteLine("═");
            };
            for (int i = MENU_START_X; i <= MENU_END_X; i++)
            {
                Console.SetCursorPosition(i, MENU_UPPER_Y);
                Console.WriteLine("═");
            };
            Console.SetCursorPosition(MENU_START_X, MENU_LOWER_Y);
            Console.WriteLine("╚");
            Console.SetCursorPosition(MENU_END_X, MENU_LOWER_Y);
            Console.WriteLine("╝");
            Console.SetCursorPosition(MENU_START_X, MENU_UPPER_Y);
            Console.WriteLine("╔");
            Console.SetCursorPosition(MENU_END_X, MENU_UPPER_Y);
            Console.WriteLine("╗");
            Console.ResetColor();

            string[] stringPlayer = mainPlayer.ToString().Split('\n');
            for (int i = 0; i < stringPlayer.Length; i++)
            {
                Console.SetCursorPosition(MENU_START_X + 2, i + MENU_UPPER_Y + 2);
                Console.WriteLine(stringPlayer[i]);
            }

        }

        #endregion

        #region MonsterDisplay
        /// <summary>
        /// Displays the enemy ToString in a box on the screen.
        /// </summary>
        /// <param name="monster">The Monster object that should be displayed.</param>
            public static void ShowMonster(Monster monster)
            {

                //window size x159,y45
                //Player Stats
                // bottom left coordinate x=115,y=20
                //bottom right coordinate x=154,y=20
                //top left coordinate x=115,y=3
                //top right coordinate x=154,y=3
                const int MENU_START_X = 115;
                const int MENU_END_X = 154;
                const int MENU_LOWER_Y = 20;
                const int MENU_UPPER_Y = 2;
                Console.ForegroundColor = ConsoleColor.Red;
                for (int i = MENU_UPPER_Y; i <= MENU_LOWER_Y; i++)
                {
                    Console.SetCursorPosition(MENU_START_X, i);
                    Console.WriteLine("║");
                };
                for (int i = MENU_UPPER_Y; i <= MENU_LOWER_Y; i++)
                {
                    Console.SetCursorPosition(MENU_END_X, i);
                    Console.WriteLine("║");
                };
                for (int i = MENU_START_X; i <= MENU_END_X; i++)
                {
                    Console.SetCursorPosition(i, MENU_LOWER_Y);
                    Console.WriteLine("═");
                };
                for (int i = MENU_START_X; i <= MENU_END_X; i++)
                {
                    Console.SetCursorPosition(i, MENU_UPPER_Y);
                    Console.WriteLine("═");
                };
                Console.SetCursorPosition(MENU_START_X, MENU_LOWER_Y);
                Console.WriteLine("╚");
                Console.SetCursorPosition(MENU_END_X, MENU_LOWER_Y);
                Console.WriteLine("╝");
                Console.SetCursorPosition(MENU_START_X, MENU_UPPER_Y);
                Console.WriteLine("╔");
                Console.SetCursorPosition(MENU_END_X, MENU_UPPER_Y);
                Console.WriteLine("╗");
                Console.ResetColor();

                string[] stringMonster = monster.ToString().Split('\n');
                for (int i = 0; i < stringMonster.Length; i++)
                {
                    Console.SetCursorPosition(MENU_START_X + 2, i + MENU_UPPER_Y + 2);
                    Console.WriteLine(stringMonster[i]);
                }
            }
        #endregion

        #region MapDisplay

            public static void ShowMap()
            {
                //window size x159,y45
                //Player Stats
                // bottom left coordinate x=114,y=42
                //bottom right coordinate x=154,y=42
                //top left coordinate x=114,y=26
                //top right coordinate x=154,y=26
                const int MENU_START_X = 114;
                const int MENU_END_X = 154;
                const int MENU_LOWER_Y = 42;
                const int MENU_UPPER_Y = 26;
                //Vertical line left side
                Console.ForegroundColor = ConsoleColor.Blue;
                for (int i = MENU_UPPER_Y; i <= MENU_LOWER_Y; i++)
                {
                    Console.SetCursorPosition(MENU_START_X, i);
                    Console.WriteLine("║");
                };
                for (int i = MENU_UPPER_Y; i <= MENU_LOWER_Y; i++)
                {
                    Console.SetCursorPosition(MENU_END_X, i);
                    Console.WriteLine("║");
                };
                for (int i = MENU_START_X; i <= MENU_END_X; i++)
                {
                    Console.SetCursorPosition(i, MENU_LOWER_Y);
                    Console.WriteLine("═");
                };
                for (int i = MENU_START_X; i <= MENU_END_X; i++)
                {
                    Console.SetCursorPosition(i, MENU_UPPER_Y);
                    Console.WriteLine("═");
                };
                Console.SetCursorPosition(MENU_START_X, MENU_LOWER_Y);
                Console.WriteLine("╚");
                Console.SetCursorPosition(MENU_END_X, MENU_LOWER_Y);
                Console.WriteLine("╝");
                Console.SetCursorPosition(MENU_START_X, MENU_UPPER_Y);
                Console.WriteLine("╔");
                Console.SetCursorPosition(MENU_END_X, MENU_UPPER_Y);
                Console.WriteLine("╗");
                Console.ResetColor();


                string map =
                  "┌───┬───┬───┬───┬───┬───┬───┬───┬───┐\n" +
                  "|   |   |   |   |   |   |   |   |   |\n" +
                  "├───┼───┼───┼───┼───┼───┼───┼───┼───┤\n" +
                  "|   |   |   |   |   |   |   |   |   |\n" +
                  "├───┼───┼───┼───┼───┼───┼───┼───┼───┤\n" +
                  "|   |   |   |   |   |   |   |   |   |\n" +
                  "├───┼───┼───┼───┼───┼───┼───┼───┼───┤\n" +
                  "|   |   |   |   |   |   |   |   |   |\n" +
                  "├───┼───┼───┼───┼───┼───┼───┼───┼───┤\n" +
                  "|   |   |   |   |   |   |   |   |   |\n" +
                  "├───┼───┼───┼───┼───┼───┼───┼───┼───┤\n" +
                  "|   |   |   |   |   |   |   |   |   |\n" +
                  "├───┼───┼───┼───┼───┼───┼───┼───┼───┤\n" +
                  "|   |   |   |   |   |   |   |   |   |\n" +
                  "└───┴───┴───┴───┴───┴───┴───┴───┴───┘";

                string[] stringMap = map.ToString().Split('\n');
                for (int i = 0; i < stringMap.Length; i++)
                {
                    Console.SetCursorPosition(MENU_START_X + 2, i + MENU_UPPER_Y + 1);
                    Console.WriteLine(stringMap[i]);
                }
            }
        #endregion

        #region ControlDisplay
        /// <summary>
        /// Displays the empty control menu on the screen.
        /// </summary>
        public static void ShowControl()
        {
            //window size x159,y45
            //Control Display
            // bottom left coordinate x=51,y=38
            //bottom right coordinate x=102,y=38
            //top left coordinate x=51,y=28
            //top right coordinate x=102,y=28
            const int MENU_START_X = 51;
            const int MENU_END_X = 102;
            const int MENU_LOWER_Y = 38;
            const int MENU_UPPER_Y = 28;
            Console.ForegroundColor = ConsoleColor.Blue;
            for (int i = MENU_UPPER_Y; i <= MENU_LOWER_Y; i++)
            {
                Console.SetCursorPosition(MENU_START_X, i);
                Console.WriteLine("║");
            };
            for (int i = MENU_UPPER_Y; i <= MENU_LOWER_Y; i++)
            {
                Console.SetCursorPosition(MENU_END_X, i);
                Console.WriteLine("║");
            };
            for (int i = MENU_START_X; i <= MENU_END_X; i++)
            {
                Console.SetCursorPosition(i, MENU_LOWER_Y);
                Console.WriteLine("═");
            };
            for (int i = MENU_START_X; i <= MENU_END_X; i++)
            {
                Console.SetCursorPosition(i, MENU_UPPER_Y);
                Console.WriteLine("═");
            };
            Console.SetCursorPosition(MENU_START_X, MENU_LOWER_Y);
            Console.WriteLine("╚");
            Console.SetCursorPosition(MENU_END_X, MENU_LOWER_Y);
            Console.WriteLine("╝");
            Console.SetCursorPosition(MENU_START_X, MENU_UPPER_Y);
            Console.WriteLine("╔");
            Console.SetCursorPosition(MENU_END_X, MENU_UPPER_Y);
            Console.WriteLine("╗");
            Console.ResetColor();


            string seven = "┌───┐\n| 7 |\n└───┘";
            string eight = "┌───┐\n| 8 |\n└───┘";
            string nine = "┌───┐\n| 9 |\n└───┘";
            string four = "┌───┐\n| 4 |\n└───┘";
            string five = "┌───┐\n| 5 |\n└───┘";
            string six = "┌───┐\n| 6 |\n└───┘";
            string one = "┌───┐\n| 1 |\n└───┘";
            string two = "┌───┐\n| 2 |\n└───┘";
            string three = "┌───┐\n| 3 |\n└───┘";



            string[] stringSeven = seven.ToString().Split('\n');
            for (int i = 0; i < stringSeven.Length; i++)
            {
                Console.SetCursorPosition(MENU_START_X + 2, i + MENU_UPPER_Y + 1);
                Console.WriteLine(stringSeven[i]);
            }
            string[] stringEight = eight.ToString().Split('\n');
            for (int i = 0; i < stringEight.Length; i++)
            {
                Console.SetCursorPosition(MENU_START_X + 18, i + MENU_UPPER_Y + 1);
                Console.WriteLine(stringEight[i]);
            }
            string[] stringNine = nine.ToString().Split('\n');
            for (int i = 0; i < stringNine.Length; i++)
            {
                Console.SetCursorPosition(MENU_START_X + 35, i + MENU_UPPER_Y + 1);
                Console.WriteLine(stringNine[i]);
            }
            string[] stringFour = four.ToString().Split('\n');
            for (int i = 0; i < stringFour.Length; i++)
            {
                Console.SetCursorPosition(MENU_START_X + 2, i + MENU_UPPER_Y + 4);
                Console.WriteLine(stringFour[i]);
            }
            string[] stringFive = five.ToString().Split('\n');
            for (int i = 0; i < stringFive.Length; i++)
            {
                Console.SetCursorPosition(MENU_START_X + 18, i + MENU_UPPER_Y + 4);
                Console.WriteLine(stringFive[i]);
            }
            string[] stringSix = six.ToString().Split('\n');
            for (int i = 0; i < stringSix.Length; i++)
            {
                Console.SetCursorPosition(MENU_START_X + 35, i + MENU_UPPER_Y + 4);
                Console.WriteLine(stringSix[i]);
            }
            string[] stringOne = one.ToString().Split('\n');
            for (int i = 0; i < stringOne.Length; i++)
            {
                Console.SetCursorPosition(MENU_START_X + 2, i + MENU_UPPER_Y + 7);
                Console.WriteLine(stringOne[i]);
            }
            string[] stringTwo = two.ToString().Split('\n');
            for (int i = 0; i < stringTwo.Length; i++)
            {
                Console.SetCursorPosition(MENU_START_X + 18, i + MENU_UPPER_Y + 7);
                Console.WriteLine(stringTwo[i]);
            }
            string[] stringThree = three.ToString().Split('\n');
            for (int i = 0; i < stringThree.Length; i++)
            {
                Console.SetCursorPosition(MENU_START_X + 35, i + MENU_UPPER_Y + 7);
                Console.WriteLine(stringThree[i]);
            }
        }
        #endregion

        #region BattleMenu

        public static void BattleMenu()
        {
            // bottom left coordinate x=51,y=38
            //bottom right coordinate x=102,y=38
            //top left coordinate x=51,y=28
            //top right coordinate x=102,y=28
            const int MENU_START_X = 51;
            const int MENU_UPPER_Y = 28;

            Console.SetCursorPosition(MENU_START_X + 8, MENU_UPPER_Y + 2);
            Console.WriteLine("Attack");
            Console.SetCursorPosition(MENU_START_X + 24, MENU_UPPER_Y + 2);
            Console.WriteLine("          ");
            Console.SetCursorPosition(MENU_START_X + 41, MENU_UPPER_Y + 2);
            Console.WriteLine("Run Away");
            Console.SetCursorPosition(MENU_START_X + 8, MENU_UPPER_Y + 5);
            Console.WriteLine("          ");
            Console.SetCursorPosition(MENU_START_X + 24, MENU_UPPER_Y + 5);
            Console.WriteLine("          ");
            Console.SetCursorPosition(MENU_START_X + 41, MENU_UPPER_Y + 5);
            Console.WriteLine("          ");
            Console.SetCursorPosition(MENU_START_X + 8, MENU_UPPER_Y + 8);
            Console.Write("Inventory");
            Console.SetCursorPosition(MENU_START_X + 24, MENU_UPPER_Y + 8);
            Console.WriteLine("          ");
            Console.SetCursorPosition(MENU_START_X + 41, MENU_UPPER_Y + 8);
            Console.WriteLine("Exit");
        }

        #endregion

        #region MapMenu
        public static void MapMenu()
        {
            // bottom left coordinate x=51,y=38
            //bottom right coordinate x=102,y=38
            //top left coordinate x=51,y=28
            //top right coordinate x=102,y=28
            const int MENU_START_X = 51;
            const int MENU_UPPER_Y = 28;

            Console.SetCursorPosition(MENU_START_X + 8, MENU_UPPER_Y + 2);
            Console.WriteLine("          ");
            Console.SetCursorPosition(MENU_START_X + 24, MENU_UPPER_Y + 2);
            Console.WriteLine("Move North");
            Console.SetCursorPosition(MENU_START_X + 41, MENU_UPPER_Y + 2);
            Console.WriteLine("          ");
            Console.SetCursorPosition(MENU_START_X + 8, MENU_UPPER_Y + 5);
            Console.WriteLine("Move West");
            Console.SetCursorPosition(MENU_START_X + 24, MENU_UPPER_Y + 5);
            Console.WriteLine("Rest");
            Console.SetCursorPosition(MENU_START_X + 41, MENU_UPPER_Y + 5);
            Console.WriteLine("Move East");
            Console.SetCursorPosition(MENU_START_X + 8, MENU_UPPER_Y + 8);
            Console.WriteLine("Inventory");
            Console.SetCursorPosition(MENU_START_X + 24, MENU_UPPER_Y + 8);
            Console.WriteLine("Move South");
            Console.SetCursorPosition(MENU_START_X + 41, MENU_UPPER_Y + 8);
            Console.WriteLine("Exit");
        }
        #endregion

    }
}

