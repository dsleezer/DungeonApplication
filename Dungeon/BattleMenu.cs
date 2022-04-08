using DungeonLibrary;



namespace Dungeon
{
    class BattleMenu
    {
        static void Main(string[] args)
        {
            int score = 0;

                bool loopGame = true;
                do//game loop
                {
            //TODO: Create a Player object to track info/stats
            #region Character Creation

            #region Asset Initialization

            Weapon w1 = new Weapon(2, 12, "Greatsword", 3, true, WeaponType.Greatsword);

            PlayerClass warrior = new PlayerClass("Warrior", 6, 0, 2, 6, 10, w1, "The ultimate fighter, able to hit hard and take hits.");
            PlayerClass wizard = new PlayerClass("Wizard", 0, 4, 1, 0, 4, w1, "Inherently prone to using magic but not very durable.");
            PlayerClass rogue = new PlayerClass("Rogue", 2, 0, 6, 4, 8, w1, "Prefers sneaking up on enemies and taking them out before they know that anything's there.");
            PlayerClass ranger = new PlayerClass("Ranger", 0, 2, 6, 4, 6, w1, "Shoots from a distance to keep from getting hurt.");

            List<PlayerClass> classes = new List<PlayerClass> { warrior, wizard, rogue, ranger };

            Race halforc = new Race("HalfOrc", 4, 0, 0, 2, "The green skinned humanoids. Quick to anger,\nslow to thought.");
            Race elf = new Race("Elf", 0, 4, 0, 2, "Older than any other race. They come from the\nethereal plain");
            Race halfling = new Race("Halfling", 0, 2, 2, 2, "Often mistaken for a large child due to both\ntheir looks and mannerisms.");
            Race gnome = new Race("Gnome", 0, 0, 4, 2, "The smallest of the humanoid races, barely coming up\nto the average person's knee.");
            Race human = new Race("Human", 2, 2, 0, 2, "Nothing particularly special but that's what makes them special.");
            Race dwarf = new Race("Dwarf", 2, 0, 0, 4, "Known for their facial hair, even on the women.");
            Race halfelf = new Race("Half-Elf", 2, 2, 2, 2, "A cross between an elf and a human.");
            Race tiefling = new Race("Tiefling", 0, 2, 4, 2, "The green skinned humanoids. Quick to anger, slow to thought.");
            Race dragonborn = new Race("Dragonborn", 2, 0, 2, 2, "Decended from ancient dragons. They retain\nsome of their ancestors traits including appearance.");

            List<Race> races = new List<Race> { halforc, elf, gnome, human, dwarf, halfelf, tiefling, dragonborn };


            //Character Creation
            PlayerClass pClass = new PlayerClass();
            Race pRace = new Race();
            string pName = "";

            #endregion

            #region Class Selection


            bool classMenu = true;
            do
            {

                Console.WriteLine("Choose your Class\n");
                foreach (var item in classes)
                {

                    Console.WriteLine(item);
                }
                Console.WriteLine("1) Warrior\n2) Wizard\n3) Rogue\n4) Ranger\n");
                bool menuSuccess = true;
                string classSelection = "";
                string classConfirmation = "";
                classSelection = Console.ReadKey(true).Key.ToString();

                switch (classSelection)
                {
                    case "D1":
                    case "NumPad1":
                        pClass = warrior;
                        break;
                    case "D2":
                    case "NumPad2":
                        pClass = wizard;
                        break;
                    case "D3":
                    case "NumPad3":
                        pClass = rogue;
                        break;
                    case "D4":
                    case "NumPad4":
                        pClass = ranger;
                        break;
                    default:
                        Console.WriteLine("Input not valid...");
                        menuSuccess = !menuSuccess;
                        break;
                        if (menuSuccess == true)
                        {
                            Console.WriteLine($"You chose {pClass.Name}.\n{pClass}\nAre you sure? Y/N");
                            classConfirmation = Console.ReadKey(true).Key.ToString();
                            if (classConfirmation == "Y")
                            {
                                classMenu = !classMenu;
                            }
                            else { }
                        }
                } while (classMenu) ;

                #endregion

                #region Race Selection


                bool raceMenu = true;
                do
                {
                    Console.WriteLine("Choose your Race\n");
                    foreach (var item in races)
                    {

                        Console.WriteLine(item);
                    }
                    Console.WriteLine("1) Half-Orc\t\t2) Elf\n3) Halfling\t\t4) Gnome\n5) Human\t\t6) Dwarf\n7) Half-Elf\t\t8)Tiefling\n9) Dragonborn");

                    string raceSelection = "";
                    string raceConfirmation = "";
                    bool menuSuccess = true;
                    raceSelection = Console.ReadKey(true).Key.ToString();

                    switch (raceSelection)
                    {
                        case "D1":
                        case "NumPad1":
                            pRace = halforc;
                            break;
                        case "D2":
                        case "NumPad2":
                            pRace = elf;
                            break;
                        case "D3":
                        case "NumPad3":
                            pRace = halfling;
                            break;
                        case "D4":
                        case "NumPad4":
                            pRace = gnome;
                            break;
                        case "D5":
                        case "NumPad5":
                            pRace = human;
                            break;
                        case "D6":
                        case "NumPad6":
                            pRace = dwarf;
                            break;
                        case "D7":
                        case "NumPad7":
                            pRace = halfelf;
                            break;
                        case "D8":
                        case "NumPad8":
                            pRace = tiefling;
                            break;
                        case "D9":
                        case "NumPad9":
                            pRace = dragonborn;
                            break;
                        default:
                            Console.WriteLine("Input not valid...");
                            menuSuccess = !menuSuccess;
                            break;
                    }
                    if (menuSuccess == true)
                    {
                        Console.WriteLine($"You chose {pRace.Name}.\n{pRace}\nAre you sure? Y/N");
                        raceConfirmation = Console.ReadKey(true).Key.ToString();
                        if (raceConfirmation == "Y")
                        {
                            raceMenu = !raceMenu;
                        }
                        else { }
                    }
                } while (raceMenu);

                #endregion

                #region Name Selection


                bool nameMenu = true;
                string nameConfirmation = "";
                do
                {
                    Console.WriteLine("What is your name?");
                    pName = Console.ReadLine().ToString();
                    Console.WriteLine($"Your name is {pName}.\n\n Do you want to keep this? Y/N");

                    nameConfirmation = Console.ReadKey(true).Key.ToString();
                    if (nameConfirmation == "Y")
                    {
                        nameMenu = !nameMenu;
                    }
                    else { }
                } while (nameMenu);

                #endregion

                Player player1 = new Player(pName, pClass, pRace, 10, 10, 10, 10);


                Console.WriteLine(player1);


                #endregion


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
                                    Combat.DoBattle(player1, monster)
    
                                        //Check if the monster is dead
                                    if (monster.Life <= 0)
                                    {
                                        //use green text to highlight winning combat
                                        Console.ForegroundColor = ConsoleColor.Green;

                                        //Output the result
                                        Console.WriteLine("\nYou killed {0}!\n", monster.Name);

                                        //Reset the color
                                        Console.ResetColor();

                                        //Update the score
                                        score++;

                                        //Flip the loopMenu bool to exit the current menu loop
                                        //so we can get a new room & monster
                                        loopMenu = false;
                                    }



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
                                        Console.WriteLine($"{monster.Name} attacks you as you flee!");
                                        Combat.DoAttack(monster, player1);

                                        //Flip the reload bool to exit the current menu
                                        //and get a new room & monster

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
                                    //TODO CharacterInfo()
                                    //Console.WriteLine(player1);
                                    Console.WriteLine("Enemies Defeated: " + score);
                                    Console.WriteLine("\nPress any key to continue.");
                                    Console.ReadKey(true);

                                    break;
                                case "D4":
                                case "NumPad4":
                                    //TODO MonsterInfo()
                                    //Console.WriteLine(monster);
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

                            //Check the Player's life
                            if (player1.CurrentHealth <= 0)
                            {
                                Console.WriteLine("You have been slain!");
                                loopMenu = false;
                                loopEncounter=false;
                            }


                        } while (loopMenu);//end menu loop


                    } while (loopEncounter);//end encounter loop




                } while (loopGame);//end game loop

                    //Output the final score
                    Console.WriteLine("You defeated " + score + ((score == 1) ? "enemy" : "enemies."));



                Console.Write("\n\nAll code has been executed. Press any key to terminate the application...\n");
                Console.ReadKey(true);

            }//end Main()
    }//end class
    }//end namespace