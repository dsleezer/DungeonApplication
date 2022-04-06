using DungeonLibrary;



namespace Dungeon
{
    class BattleMenu
    {
        static void Main(string[] args)
        {
            //TODO: Create a Player object to track info/stats
            
            bool loopGame = true;
            do//game loop
            {
                bool loopEncounter = true;

                do//encounter loop
                {
                    //TODO: CreateEnemy()
                    Console.WriteLine(RoomGenerator.RoomCreator(0));

                    bool loopMenu = true;

                    do//loopMenu
                    {
                        Console.Clear();

                        //TODO: display the monster
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

                                Console.WriteLine("You attack");
                                //TODO AttackEnemy()
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
                                    Console.WriteLine("You run away.");
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

                                Console.WriteLine("Character Info");
                                //TODO CharacterInfo()
                                Console.WriteLine("Press any key to continue.");
                                Console.ReadKey(true);

                                break;
                            case "D4":
                            case "NumPad4":

                                Console.WriteLine("Monster Info");
                                //TODO MonsterInfo()
                                Console.WriteLine("Press any key to continue.");
                                Console.ReadKey(true);

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

                    } while (loopMenu);//end menu loop


                } while (loopEncounter);//end encounter loop



            } while (loopGame);//end game loop




            Console.Write("\n\nAll code has been executed. Press any key to terminate the application...\n");
            Console.ReadKey(true);

        }//end Main()
    }//end class
}//end namespace