using DungeonLibrary;



namespace Dungeon
{
    class MainGame
    {
        static void Main(string[] args)
        {
            int score = 0;

            bool loopGame = true;
            do//game loop
            {
                #region Character Creation

                Player mainPlayer = PlayerWarehouse.CreatePlayer();

                Console.WriteLine(mainPlayer);

                Console.ReadKey();

                #endregion


                bool loopEncounter = true;

                do//encounter loop
                {
                    Monster activeEnemy = EnemyWarehouse.GenerateMonster(mainPlayer);


                    Console.WriteLine(RoomGenerator.RoomCreator(0));

                    bool loopMenu = true;

                    do//BattleLoop
                    {
                        Console.Clear();

                        Console.WriteLine(activeEnemy);
                        //TODO: display the room


                        Console.WriteLine("1) Attack\n" +
                            "2) Run Away\n" +
                            "3) Character Info\n" +
                            "4) Monster Info\n" +
                            "5) Exit");
                        string menuSelection = "";
                        menuSelection = Console.ReadKey(true).Key.ToString();

                        switch (menuSelection)
                        {
                            case "D1":
                            case "NumPad1":
                                Combat.DoBattle(mainPlayer, activeEnemy);

                                //Check if the monster is dead
                                if (activeEnemy.CurrentHealth <= 0)
                                {
                                    //use green text to highlight winning combat
                                    Console.ForegroundColor = ConsoleColor.Green;

                                    //Output the result
                                    Console.WriteLine("\nYou killed {0}!\n", activeEnemy.Name);

                                    //Reset the color
                                    Console.ResetColor();

                                    Console.WriteLine($"You gained {activeEnemy.Exp} experience points!");

                                    //Add Exp
                                    mainPlayer.Exp += activeEnemy.Exp;

                                    Console.WriteLine($"Current experience {mainPlayer.Exp} / {((mainPlayer.Level == 10) ? "1000" : (mainPlayer.Level * 100))}.");
                                    //Check Levelup
                                    PlayerWarehouse.LevelUp(mainPlayer);

                                    //Update the score
                                    score++;

                                    //Flip the loopMenu bool to exit the current menu loop
                                    //so we can get a new room & monster
                                    loopMenu = false;
                                }
                                Console.WriteLine("Press any key to continue.");
                                Console.ReadKey(true);
                                break;

                            case "D2":
                            case "NumPad2":

                                Console.WriteLine("Are you sure you want to run away?\n" +
                                    "Y/N\n");
                                string runAway = "";
                                runAway = Console.ReadKey(true).Key.ToString();
                                if (runAway == "Y")
                                {
                                    Console.WriteLine($"{activeEnemy.Name} attacks you as you flee!");
                                    Combat.DoAttack(activeEnemy, mainPlayer);

                                    loopMenu = false;
                                    loopEncounter = false;
                                }
                                else
                                {
                                    Console.WriteLine("Returning to battle.");
                                }
                                Console.WriteLine("Press any key to continue.");
                                Console.ReadKey(true);
                                break;

                            case "D3":
                            case "NumPad3":
                                Console.WriteLine(mainPlayer);
                                Console.WriteLine("Enemies Defeated: " + score);
                                Console.WriteLine("\nPress any key to continue.");
                                Console.ReadKey(true);
                                Console.Clear();
                                break;

                            case "D4":
                            case "NumPad4":
                                Console.WriteLine(activeEnemy);
                                Console.WriteLine("Press any key to continue.");
                                Console.ReadKey(true);
                                Console.Clear();
                                break;

                            case "D5":
                            case "NumPad5":
                                Console.WriteLine("Are you sure you want to exit?\n" +
                                    "Progress will not be saved\n" +
                                    "Y/N\n");
                                string exitAnswer = "";
                                exitAnswer = Console.ReadKey(true).Key.ToString();
                                if (exitAnswer == "Y")
                                {
                                    loopMenu = false;
                                    loopEncounter = false;
                                    loopGame = false;
                                }
                                else
                                {
                                    Console.WriteLine("Returning to battle.");
                                }
                                Console.WriteLine("Press any key to continue.");
                                Console.ReadKey(true);
                                break;

                            default:
                                break;
                        }//end menu switch

                        //Check the Player's life
                        if (mainPlayer.CurrentHealth <= 0)
                        {
                            Console.WriteLine("You have been slain!");
                            loopMenu = false;
                            loopEncounter = false;
                        }


                    } while (loopMenu);//end battle loop


                } while (loopEncounter);//end encounter loop

            Console.WriteLine("You defeated " + score + ((score == 1) ? " enemy\n\n" : " enemies.\n\n") + mainPlayer);

            } while (loopGame);//end game loop

            //Output the final score

            Console.Write("\n\nAll code has been executed. Press any key to terminate the application...\n");
            Console.ReadKey(true);

        }//end Main()
    }//end class
}//end namespace