using DungeonLibrary;



namespace Dungeon
{
    class MainGame
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(159, 45);
            TextTracker textLine = new TextTracker(0);
            int score = 0;
            //Menu
            OpeningMenu.MainMenu();
            //Story Intro
            OpeningMenu.FirstStory();
            //Player Creation
            Player mainPlayer = PlayerWarehouse.CreatePlayer();

            //Local Map Area
            bool loopArea = true;
            do
            {
                textLine.LineNumber = 0;
                Console.Clear();
                bool loopMovement = true;
                DispWarehouse.ShowMap();
                MovementWarehouse.CurrentPosition(mainPlayer);
                int encounterChance = 0;

                do//MovementLoop
                {
                    DispWarehouse.ShowPlayer(mainPlayer);
                    DispWarehouse.ShowControl();
                    DispWarehouse.MapMenu();
                    //TODO: display the room
                    //mainPlayer.CurrentHealth *= 1.

                    string menuSelection = "";
                    menuSelection = Console.ReadKey(true).Key.ToString();

                    switch (menuSelection)
                    {
                        //Attack
                        case "D8":
                        case "NumPad8":
                            MovementWarehouse.MoveNorth(mainPlayer);
                            encounterChance += EnemyWarehouse.MovementAdd();
                            break;
                        //Run Away
                        case "D2":
                        case "NumPad2":
                            MovementWarehouse.MoveSouth(mainPlayer);
                            encounterChance += EnemyWarehouse.MovementAdd();
                            break;
                        //Inventory
                        //TODO Create Inventory/Potion
                        //case "D1":
                        //case "NumPad1":

                        //    break;

                        //Exit
                        case "D4":
                        case "NumPad4":
                            MovementWarehouse.MoveWest(mainPlayer);
                            encounterChance += EnemyWarehouse.MovementAdd();
                            break;
                        case "D5":
                        case "NumPad5":
                            mainPlayer.CurrentHealth = mainPlayer.MaxHealth;
                            encounterChance += EnemyWarehouse.RestAdd();
                            break;

                        case "D6":
                        case "NumPad6":
                            MovementWarehouse.MoveEast(mainPlayer);
                            encounterChance += EnemyWarehouse.MovementAdd();
                            break;
                        case "D3":
                        case "NumPad3":
                            DispWarehouse.TextDisplay(textLine, "Are you sure you want to exit?\n" +
                                "Progress will not be saved.\n" +
                                "Y/N\n");
                            string exitAnswer = "";
                            exitAnswer = Console.ReadKey(true).Key.ToString();
                            if (exitAnswer == "Y")
                            {
                                loopMovement = false;
                            }
                            else
                            {
                                DispWarehouse.TextDisplay(textLine, "Returning to the world.");
                            }
                            DispWarehouse.TextDisplay(textLine, "Press any key to continue.");
                            Console.ReadKey(true);
                            break;

                        default:
                            break;
                    }//end menu switch
                } while (loopMovement);//end Movement loop

                bool loopEncounter = true;

                do//encounter loop
                {
                    Monster activeEnemy = EnemyWarehouse.GenerateMonster(mainPlayer);

                    //TODO: Fix room name creation
                    //textLine = DispWarehouse.TextDisplay(textLine, RoomGenerator.RoomCreator(0));

                    bool loopBattle = true;

                    do//BattleLoop
                    {
                        DispWarehouse.PlayerClear();
                        DispWarehouse.MonsterClear();
                        DispWarehouse.ShowPlayer(mainPlayer);
                        DispWarehouse.ShowMonster(activeEnemy);
                        DispWarehouse.ShowMap();
                        DispWarehouse.ShowControl();
                        DispWarehouse.BattleMenu();
                        MovementWarehouse.CurrentPosition(mainPlayer);

                        string menuSelection = "";
                        menuSelection = Console.ReadKey(true).Key.ToString();

                        switch (menuSelection)
                        {
                            //Attack
                            case "D7":
                            case "NumPad7":
                                Combat.DoBattle(mainPlayer, activeEnemy, textLine);

                                //Check if the monster is dead
                                if (activeEnemy.CurrentHealth <= 0)
                                {
                                    //SoundWarehouse.PlaySong();
                                    //use green text to highlight winning combat
                                    Console.ForegroundColor = ConsoleColor.Green;

                                    //Output the result
                                    DispWarehouse.TextDisplay(textLine, $"\nYou killed {activeEnemy.Name}!\n");

                                    //Reset the color
                                    Console.ResetColor();

                                    DispWarehouse.TextDisplay(textLine, $"You gained {activeEnemy.Exp} experience points!");

                                    //Add Exp
                                    mainPlayer.Exp += activeEnemy.Exp;

                                    DispWarehouse.TextDisplay(textLine, $"Current experience {mainPlayer.Exp} / {((mainPlayer.Level == 10) ? "1000" : (mainPlayer.Level * 100))}.");
                                    //Check Levelup
                                    PlayerWarehouse.LevelUp(mainPlayer, textLine);

                                    //Update the score
                                    score++;

                                    //Exit the current menu loop
                                    loopBattle = false;
                                    loopEncounter = false;
                                    //Clear Monster Display
                                    DispWarehouse.MonsterClear();
                                    DispWarehouse.TextDisplayClear(textLine);
                                }
                                break;
                            //Run Away
                            case "D9":
                            case "NumPad2":

                                DispWarehouse.TextDisplay(textLine, "Are you sure you want to run away?\n" +
                                    "Y/N\n");
                                string runAway = "";
                                runAway = Console.ReadKey(true).Key.ToString();
                                if (runAway == "Y")
                                {
                                    DispWarehouse.TextDisplay(textLine, $"{activeEnemy.Name} attacks you as you flee!");
                                    Combat.DoAttack(activeEnemy, mainPlayer, textLine);

                                    loopBattle = false;
                                    loopEncounter = false;
                                }
                                else
                                {
                                    DispWarehouse.TextDisplay(textLine, "Returning to battle.");
                                }
                                DispWarehouse.TextDisplay(textLine, "Press any key to continue.");
                                Console.ReadKey(true);
                                break;
                            //Inventory
                            //TODO Create Inventory/Potion
                            //case "D1":
                            //case "NumPad1":

                            //    break;

                            //Exit
                            case "D3":
                            case "NumPad3":
                                DispWarehouse.TextDisplay(textLine, "Are you sure you want to exit?\n" +
                                    "Progress will not be saved\n" +
                                    "Y/N\n");
                                string exitAnswer = "";
                                exitAnswer = Console.ReadKey(true).Key.ToString();
                                if (exitAnswer == "Y")
                                {
                                    loopBattle = false;
                                    loopEncounter = false;
                                    loopArea = false;
                                }
                                else
                                {
                                    DispWarehouse.TextDisplay(textLine, "Returning to battle.");
                                }
                                DispWarehouse.TextDisplay(textLine, "Press any key to continue.");
                                Console.ReadKey(true);
                                break;

                            default:
                                break;
                        }//end menu switch

                        //Check the Player's life
                        if (mainPlayer.CurrentHealth <= 0)
                        {
                            DispWarehouse.TextDisplay(textLine, "You have been slain!");
                            loopBattle = false;
                            loopEncounter = false;
                            loopArea = false;
                        }


                    } while (loopBattle);//end battle loop


                } while (loopEncounter);//end encounter loop


            } while (loopArea);//Loop between battles

            //Output the final score
            DispWarehouse.TextDisplay(textLine, "You defeated " + score + ((score == 1) ? " enemy\n\n" : " enemies.\n\n"));

            DispWarehouse.TextDisplay(textLine, "\n\nAll code has been executed. Press any key to terminate the application...\n");
            Console.ReadKey(true);

        }//end Main()
    }//end class
}//end namespace