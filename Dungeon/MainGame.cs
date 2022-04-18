using DungeonLibrary;



namespace Dungeon
{
    class MainGame
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(159, 45);
            int textLine = 0;
            int score = 0;

            bool loopGame = true;
            do//game loop
            {
                //Player Creation
                Player mainPlayer = PlayerWarehouse.CreatePlayer();

                bool loopArea = true;

                do
                {



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
                                textLine = DispWarehouse.TextDisplay(textLine, "Are you sure you want to exit?\n" +
                                    "Progress will not be saved\n" +
                                    "Y/N\n");
                                string exitAnswer = "";
                                exitAnswer = Console.ReadKey(true).Key.ToString();
                                if (exitAnswer == "Y")
                                {
                                    loopGame = false;
                                    loopMovement = false;
                                }
                                else
                                {
                                    textLine = DispWarehouse.TextDisplay(textLine, "Returning to battle.");
                                }
                                textLine = DispWarehouse.TextDisplay(textLine, "Press any key to continue.");
                                Console.ReadKey(true);
                                break;

                            default:
                                break;
                        }//end menu switch

                        //Check the Player's life
                        if (mainPlayer.CurrentHealth <= 0)
                        {
                            textLine = DispWarehouse.TextDisplay(textLine, "You have been slain!");
                            loopMovement = false;
                        }
                        if (encounterChance >= 35)
                        {
                            loopMovement = false;
                            encounterChance = 0;
                        }

                    } while (loopMovement);//end Movement loop

                    bool loopEncounter = true;

                    do//encounter loop
                    {
                        Monster activeEnemy = EnemyWarehouse.GenerateMonster(mainPlayer);


                        textLine = DispWarehouse.TextDisplay(textLine, RoomGenerator.RoomCreator(0));

                        bool loopBattle = true;

                        do//BattleLoop
                        {
                            DispWarehouse.ShowPlayer(mainPlayer);
                            DispWarehouse.ShowMonster(activeEnemy);
                            DispWarehouse.ShowMap();
                            DispWarehouse.ShowControl();
                            DispWarehouse.BattleMenu();
                            MovementWarehouse.CurrentPosition(mainPlayer);

                            //TODO: display the room



                            string menuSelection = "";
                            menuSelection = Console.ReadKey(true).Key.ToString();

                            switch (menuSelection)
                            {
                                //Attack
                                case "D7":
                                case "NumPad7":
                                    textLine = Combat.DoBattle(mainPlayer, activeEnemy, textLine);

                                    //Check if the monster is dead
                                    if (activeEnemy.CurrentHealth <= 0)
                                    {
                                        SoundWarehouse.PlaySong();
                                        //use green text to highlight winning combat
                                        Console.ForegroundColor = ConsoleColor.Green;

                                        //Output the result
                                        textLine = DispWarehouse.TextDisplay(textLine, $"\nYou killed {activeEnemy.Name}!\n");

                                        //Reset the color
                                        Console.ResetColor();

                                        textLine = DispWarehouse.TextDisplay(textLine, $"You gained {activeEnemy.Exp} experience points!");

                                        //Add Exp
                                        mainPlayer.Exp += activeEnemy.Exp;

                                        textLine = DispWarehouse.TextDisplay(textLine, $"Current experience {mainPlayer.Exp} / {((mainPlayer.Level == 10) ? "1000" : (mainPlayer.Level * 100))}.");
                                        //Check Levelup
                                        PlayerWarehouse.LevelUp(mainPlayer, textLine);

                                        //Update the score
                                        score++;

                                        //Exit the current menu loop
                                        loopBattle = false;
                                        loopEncounter = false;
                                        //Clear Monster Display
                                        DispWarehouse.MonsterClear();
                                    }
                                    break;
                                //Run Away
                                case "D9":
                                case "NumPad2":

                                    textLine = DispWarehouse.TextDisplay(textLine, "Are you sure you want to run away?\n" +
                                        "Y/N\n");
                                    string runAway = "";
                                    runAway = Console.ReadKey(true).Key.ToString();
                                    if (runAway == "Y")
                                    {
                                        textLine = DispWarehouse.TextDisplay(textLine, $"{activeEnemy.Name} attacks you as you flee!");
                                        textLine = Combat.DoAttack(activeEnemy, mainPlayer, textLine);

                                        loopBattle = false;
                                        loopEncounter = false;
                                    }
                                    else
                                    {
                                        textLine = DispWarehouse.TextDisplay(textLine, "Returning to battle.");
                                    }
                                    textLine = DispWarehouse.TextDisplay(textLine, "Press any key to continue.");
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
                                    textLine = DispWarehouse.TextDisplay(textLine, "Are you sure you want to exit?\n" +
                                        "Progress will not be saved\n" +
                                        "Y/N\n");
                                    string exitAnswer = "";
                                    exitAnswer = Console.ReadKey(true).Key.ToString();
                                    if (exitAnswer == "Y")
                                    {
                                        loopBattle = false;
                                        loopEncounter = false;
                                        loopGame = false;
                                        loopArea = false;
                                    }
                                    else
                                    {
                                        textLine = DispWarehouse.TextDisplay(textLine, "Returning to battle.");
                                    }
                                    textLine = DispWarehouse.TextDisplay(textLine, "Press any key to continue.");
                                    Console.ReadKey(true);
                                    break;

                                default:
                                    break;
                            }//end menu switch

                            //Check the Player's life
                            if (mainPlayer.CurrentHealth <= 0)
                            {
                                textLine = DispWarehouse.TextDisplay(textLine, "You have been slain!");
                                loopBattle = false;
                                loopEncounter = false;
                                loopArea = false;
                                loopGame = false;
                            }


                        } while (loopBattle);//end battle loop


                    } while (loopEncounter);//end encounter loop

                    textLine = DispWarehouse.TextDisplay(textLine, "You defeated " + score + ((score == 1) ? " enemy\n\n" : " enemies.\n\n") + mainPlayer);

                } while (loopArea);//Loop between battles
            } while (loopGame);//end game loop

            //Output the final score

            textLine = DispWarehouse.TextDisplay(textLine, "\n\nAll code has been executed. Press any key to terminate the application...\n");
            Console.ReadKey(true);

        }//end Main()
    }//end class
}//end namespace