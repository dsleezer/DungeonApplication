using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;

namespace Dungeon
{
    internal class TestBed
    {
        static void Main(string[] args)
        {

            Console.SetWindowSize(159, 45);

            #region Main Layout





            #region Asset Initialization

            Weapon greatsword = new Weapon("Greatsword", 2, 12, 3, 4, true, WeaponType.Greatsword);
            Weapon staff = new Weapon("Staff", 5, 15, 2, 8, true, WeaponType.Staff);
            Weapon dagger = new Weapon("Dagger", 1, 4, 5, 2, false, WeaponType.Dagger);
            Weapon longbow = new Weapon("Longbow", 2, 12, 6, 6, true, WeaponType.Longbow);
            // str  int  dex  con hpmod
            PlayerClass warrior = new PlayerClass("Warrior", 4, 0, 2, 4, 8, greatsword, "The ultimate fighter.\nFavors strength\nHigh health.");
            PlayerClass wizard = new PlayerClass("Wizard", 0, 4, 1, 0, 4, staff, "Utilizes magic.\nFavors intelligence.\nLow health.");
            PlayerClass rogue = new PlayerClass("Rogue", 2, 0, 6, 4, 6, dagger, "Wields daggers.\nFavors Dexterity.\nAverage Health");
            PlayerClass ranger = new PlayerClass("Ranger", 0, 2, 6, 4, 4, longbow, "Fires arrows from a bow.\nFavors Dexterity.\nAverage Health");

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
            PlayerClass pClass = warrior;
            Race pRace = dwarf;
            string pName = "Tain";

            #endregion

            #region Class Selection


            ////  ___  _  _   __    __   ____  ____    _  _  __   _  _  ____    ____   __    ___  ____ 
            //// / __)/ )( \ /  \  /  \ / ___)(  __)  ( \/ )/  \ / )( \(  _ \  (  _ \ / _\  / __)(  __)
            ////( (__ ) __ ((  O )(  O )\___ \ ) _)    )  /(  O )) \/ ( )   /   )   //    \( (__  ) _) 
            //// \___)\_)(_/ \__/  \__/ (____/(____)  (__/  \__/ \____/(__\_)  (__\_)\_/\_/ \___)(____)

            //Console.WriteLine(@"
            //                   ╔═════════════════════════════════════════════════════════════════════════════════════════════════╗
            //                   ║       ___  _  _   __    __   ____  ____    _  _  __   _  _  ____    ____   __    ___  ____      ║
            //                   ║      / __)/ )( \ /  \  /  \ / ___)(  __)  ( \/ )/  \ / )( \(  _ \  (  _ \ / _\  / __)(  __)     ║
            //                   ║     ( (__ ) __ ((  O )(  O )\___ \ ) _)    )  /(  O )) \/ ( )   /   )   //    \( (__  ) _)      ║
            //                   ║      \___)\_)(_/ \__/  \__/ (____/(____)  (__/  \__/ \____/(__\_)  (__\_)\_/\_/ \___)(____)     ║
            //                   ║                                                                                                 ║
            //                   ╚═════════════════════════════════════════════════════════════════════════════════════════════════╝");
            //Console.SetCursorPosition(31, 2);
            //Console.WriteLine(@"
            //                   ╔═════════════════════════════════════════════════════════════════════════════════════════════════╗
            //                   ║    ___  _  _   __    __   ____  ____    _  _  __   _  _  ____     ___  __     __   ____  ____   ║
            //                   ║   / __)/ )( \ /  \  /  \ / ___)(  __)  ( \/ )/  \ / )( \(  _ \   / __)(  )   / _\ / ___)/ ___)  ║
            //                   ║  ( (__ ) __ ((  O )(  O )\___ \ ) _)    )  /(  O )) \/ ( )   /  ( (__ / (_/\/    \\___ \\___ \  ║
            //                   ║   \___)\_)(_/ \__/  \__/ (____/(____)  (__/  \__/ \____/(__\_)   \___)\____/\_/\_/(____/(____/  ║
            //                   ║                                                                                                 ║
            //                   ╚═════════════════════════════════════════════════════════════════════════════════════════════════╝");


            //bool classMenu = true;
            //do
            //{

            //    string[] stringWarrior = warrior.ToString().Split('\n');
            //    for (int i = 0; i < stringWarrior.Length; i++)
            //    {
            //        Console.SetCursorPosition(31, i + 11);
            //        Console.WriteLine(stringWarrior[i]);
            //    }
            //    string[] stringWizard = wizard.ToString().Split('\n');
            //    for (int i = 0; i < stringWizard.Length; i++)
            //    {
            //        Console.SetCursorPosition(57, i + 11);
            //        Console.WriteLine(stringWizard[i]);
            //    }
            //    string[] stringRogue = rogue.ToString().Split('\n');
            //    for (int i = 0; i < stringRogue.Length; i++)
            //    {
            //        Console.SetCursorPosition(83, i + 11);
            //        Console.WriteLine(stringRogue[i]);
            //    }
            //    string[] stringRanger = ranger.ToString().Split('\n');
            //    for (int i = 0; i < stringRanger.Length; i++)
            //    {
            //        Console.SetCursorPosition(109, i + 11);
            //        Console.WriteLine(stringRanger[i]);
            //    }

            //    Console.SetCursorPosition(31, 23);
            //    Console.WriteLine("1) Warrior");
            //    Console.SetCursorPosition(57, 23);
            //    Console.WriteLine("2) Wizard");
            //    Console.SetCursorPosition(83, 23);
            //    Console.WriteLine("3) Rogue");
            //    Console.SetCursorPosition(109, 23);
            //    Console.WriteLine("4) Ranger");

            //    Console.SetCursorPosition(31, 25);
            //    Console.Write("Selection: ");
            //    bool menuSuccess = true;
            //    string classSelection = "";
            //    string classConfirmation = "";
            //    classSelection = Console.ReadKey(true).Key.ToString();
            //    switch (classSelection)
            //    {
            //        case "D1":
            //        case "NumPad1":
            //            pClass = warrior;
            //            break;
            //        case "D2":
            //        case "NumPad2":
            //            pClass = wizard;
            //            break;
            //        case "D3":
            //        case "NumPad3":
            //            pClass = rogue;
            //            break;
            //        case "D4":
            //        case "NumPad4":
            //            pClass = ranger;
            //            break;
            //        default:
            //            Console.WriteLine("Input not valid...");
            //            menuSuccess = !menuSuccess;
            //            break;
            //            if (menuSuccess == true)
            //            {
            //                Console.SetCursorPosition(31, 25);
            //                Console.WriteLine($"You chose {pClass.Name}.\n{pClass}\nAre you sure? Y/N");
            //                classConfirmation = Console.ReadKey(true).Key.ToString();
            //                if (classConfirmation == "Y")
            //                {
            //                    Console.Clear();
            //                    classMenu = !classMenu;
            //                }
            //                else { }
            //            }
            //    }
            //} while (classMenu);
            //Console.WriteLine(pClass);
            #endregion

            #region Race Selection



            //bool raceMenu = true;
            //Console.SetCursorPosition(31, 2);
            //Console.WriteLine(@"
            //                   ╔═════════════════════════════════════════════════════════════════════════════════════════════════╗
            //                   ║    ___  _  _   __    __   ____  ____    _  _  __   _  _  ____     ___  __     __   ____  ____   ║
            //                   ║   / __)/ )( \ /  \  /  \ / ___)(  __)  ( \/ )/  \ / )( \(  _ \   / __)(  )   / _\ / ___)/ ___)  ║
            //                   ║  ( (__ ) __ ((  O )(  O )\___ \ ) _)    )  /(  O )) \/ ( )   /  ( (__ / (_/\/    \\___ \\___ \  ║
            //                   ║   \___)\_)(_/ \__/  \__/ (____/(____)  (__/  \__/ \____/(__\_)   \___)\____/\_/\_/(____/(____/  ║
            //                   ║                                                                                                 ║
            //                   ╚═════════════════════════════════════════════════════════════════════════════════════════════════╝");
            //do
            //{

            //    string[] stringWarrior = warrior.ToString().Split('\n');
            //    for (int i = 0; i < stringWarrior.Length; i++)
            //    {
            //        Console.SetCursorPosition(31, i + 11);
            //        Console.WriteLine(stringWarrior[i]);
            //    }
            //    string[] stringWizard = wizard.ToString().Split('\n');
            //    for (int i = 0; i < stringWizard.Length; i++)
            //    {
            //        Console.SetCursorPosition(57, i + 11);
            //        Console.WriteLine(stringWizard[i]);
            //    }
            //    string[] stringRogue = rogue.ToString().Split('\n');
            //    for (int i = 0; i < stringRogue.Length; i++)
            //    {
            //        Console.SetCursorPosition(83, i + 11);
            //        Console.WriteLine(stringRogue[i]);
            //    }
            //    string[] stringRanger = ranger.ToString().Split('\n');
            //    for (int i = 0; i < stringRanger.Length; i++)
            //    {
            //        Console.SetCursorPosition(109, i + 11);
            //        Console.WriteLine(stringRanger[i]);
            //    }
            //    string[] stringRanger = ranger.ToString().Split('\n');
            //    for (int i = 0; i < stringRanger.Length; i++)
            //    {
            //        Console.SetCursorPosition(109, i + 11);
            //        Console.WriteLine(stringRanger[i]);
            //    }
            //    string[] stringRanger = ranger.ToString().Split('\n');
            //    for (int i = 0; i < stringRanger.Length; i++)
            //    {
            //        Console.SetCursorPosition(109, i + 11);
            //        Console.WriteLine(stringRanger[i]);
            //    }
            //    string[] stringRanger = ranger.ToString().Split('\n');
            //    for (int i = 0; i < stringRanger.Length; i++)
            //    {
            //        Console.SetCursorPosition(109, i + 11);
            //        Console.WriteLine(stringRanger[i]);
            //    }
            //    string[] stringRanger = ranger.ToString().Split('\n');
            //    for (int i = 0; i < stringRanger.Length; i++)
            //    {
            //        Console.SetCursorPosition(109, i + 11);
            //        Console.WriteLine(stringRanger[i]);
            //    }
            //    string[] stringRanger = ranger.ToString().Split('\n');
            //    for (int i = 0; i < stringRanger.Length; i++)
            //    {
            //        Console.SetCursorPosition(109, i + 11);
            //        Console.WriteLine(stringRanger[i]);
            //    }

            //    Console.SetCursorPosition(31, 23);
            //    Console.WriteLine("1) Warrior");
            //    Console.SetCursorPosition(57, 23);
            //    Console.WriteLine("2) Wizard");
            //    Console.SetCursorPosition(83, 23);
            //    Console.WriteLine("3) Rogue");
            //    Console.SetCursorPosition(109, 23);
            //    Console.WriteLine("4) Ranger");


            //    //do
            //    //{
            //    //Console.WriteLine("Choose your Race\n");
            //    //foreach (var item in races)
            //    //{

            //    //    Console.WriteLine(item);
            //    //}
            //    //Console.WriteLine("1) Half-Orc\t\t2) Elf\n3) Halfling\t\t4) Gnome\n5) Human\t\t6) Dwarf\n7) Half-Elf\t\t8)Tiefling\n9) Dragonborn");

            //    string raceSelection = "";
            //    string raceConfirmation = "";
            //    raceSelection = Console.ReadKey(true).Key.ToString();
            //    bool menuSuccess = true;

            //    switch (raceSelection)
            //    {
            //        case "D1":
            //        case "NumPad1":
            //            pRace = halforc;
            //            break;
            //        case "D2":
            //        case "NumPad2":
            //            pRace = elf;
            //            break;
            //        case "D3":
            //        case "NumPad3":
            //            pRace = halfling;
            //            break;
            //        case "D4":
            //        case "NumPad4":
            //            pRace = gnome;
            //            break;
            //        case "D5":
            //        case "NumPad5":
            //            pRace = human;
            //            break;
            //        case "D6":
            //        case "NumPad6":
            //            pRace = dwarf;
            //            break;
            //        case "D7":
            //        case "NumPad7":
            //            pRace = halfelf;
            //            break;
            //        case "D8":
            //        case "NumPad8":
            //            pRace = tiefling;
            //            break;
            //        case "D9":
            //        case "NumPad9":
            //            pRace = dragonborn;
            //            break;
            //        default:
            //            Console.WriteLine("Input not valid...");
            //            menuSuccess = !menuSuccess;
            //            break;
            //    }
            //    if (menuSuccess == true)
            //    {
            //        Console.WriteLine($"You chose {pRace.Name}.\n{pRace}\nAre you sure? Y/N");
            //        raceConfirmation = Console.ReadKey(true).Key.ToString();
            //        if (raceConfirmation == "Y")
            //        {
            //            raceMenu = !raceMenu;
            //        }
            //        else { }
            //    }

            //} while (raceMenu);

            #endregion

            //#region Name Selection


            //bool nameMenu = true;
            //string nameConfirmation = "";
            //do
            //{
            //    Console.WriteLine("What is your name?");
            //    pName = Console.ReadLine().ToString();
            //    Console.WriteLine($"Your name is {pName}.\n\n Do you want to keep this? Y/N");

            //    nameConfirmation = Console.ReadKey(true).Key.ToString();
            //    if (nameConfirmation == "Y")
            //    {
            //        nameMenu = !nameMenu;
            //    }
            //    else { }
            //} while (nameMenu);

            //#endregion
            MapCoordinates pMap = new MapCoordinates(1, 1);

            Player mainPlayer = new Player(pName, pClass, pRace, 10, 10, 10, 10, pMap);

            //Console.WriteLine(player1);


            //#endregion

            //#region Monster Creation

            Monster flyingcat = new Monster("Flying Cat", 4, 12, 16, 10, 9, 9, 2, 2, 18, 10, 200, "Dexterity", "A housecat with wings.");
            Monster flumph = new Monster("Flumph", 8, 14, 16, 12, 10, 10, 2, 8, 4, 12, 25, "Dexterity", "The childlike whimsy of it hides the\nintent of it's tentacles.");
            Monster kobold = new Monster("Kobold", 8, 8, 16, 10, 11, 11, 3, 7, 4, 12, 25, "Dexterity", "A small humanoid reptile.");
            Monster magmin = new Monster("Magmin", 6, 8, 10, 12, 12, 12, 12, 2, 12, 4, 14, "Dexterity", "Imp-like with flames for hair.");
            Monster troglodyt = new Monster("Troglodyte", 14, 6, 10, 14, 13, 13, 3, 7, 4, 13, 30, "Strength", "Oozing with slime and covered\nin scales.");
            Monster modron = new Monster("Modron", 6, 14, 8, 12, 14, 14, 2, 8, 5, 12, 30, "Intelligence", "Mechanical with a clock ticking in\nthe center of it's body.");
            Monster skeleton = new Monster("Skeleton", 10, 6, 14, 16, 15, 15, 3, 7, 4, 13, 30, "Dexterity", "Reanimated bones.");
            Monster hobgoblin = new Monster("Hobgoblin", 12, 10, 12, 12, 18, 18, 2, 9, 3, 18, 40, "Strength", "A large goblin that appears\nstronger than normal.");
            Monster gnoll = new Monster("Gnoll", 14, 6, 12, 8, 22, 22, 3, 10, 4, 15, 40, "Strength", "A ravenous hyena like creature.");
            Monster dryad = new Monster("Dryad", 10, 14, 12, 10, 22, 22, 5, 13, 6, 11, 40, "Intelligence", "As if it was a part of the forest,\nthis humanoid being has plants growing all over it.");
            Monster willOWisp = new Monster("Will-o-Whisp", 0, 14, 28, 10, 22, 22, 2, 16, 4, 19, 40, "Dexterity", "The soul of a creature that has taken\nshape as a glowing sphere hanging in the air.");
            Monster bandit = new Monster("Bandit", 11, 10, 12, 12, 24, 24, 2, 7, 3, 12, 40, "Strength", "A person who has fallen down on their\nluck, or loves the thrill of stealing.");
            Monster zombie = new Monster("Zombie", 14, 4, 6, 16, 26, 26, 2, 7, 3, 8, 50, "Strength", "This person looks dead but it's moving.");
            Monster harpy = new Monster("Harpy", 12, 8, 14, 12, 38, 38, 5, 14, 3, 11, 60, "Dexterity", "Entrancing you with the sound of their\nvoice, this feathered creature looks charming.");
            Monster warewolf = new Monster("Warewolf", 16, 10, 14, 14, 50, 50, 10, 24, 4, 11, 60, "Strength", "A man that has turned into a\nwolf under the full moon.");
            Monster basilisk = new Monster("Basilisk", 16, 2, 8, 16, 52, 52, 6, 17, 5, 15, 70, "Strength", "A large lizard with scales that\nseem to be made out of stone.");
            Monster griffon = new Monster("Griffon", 18, 2, 16, 16, 55, 55, 10, 20, 6, 12, 70, "Strength", "A four legged bird with the face\nof an owl.");
            Monster gibberingMouther = new Monster("Gibbering Mouther", 10, 4, 8, 16, 67, 67, 5, 25, 2, 9, 80, "Strength", "An amoeba covered in eyes and\nmouths chittering as it moves.");
            Monster troll = new Monster("Troll", 18, 8, 14, 20, 80, 80, 7, 26, 7, 15, 80, "Strength", "Gigantic with green skin and large claws.");
            Monster gelatinousCube = new Monster("Gelatinous Cube", 14, 2, 4, 20, 84, 84, 3, 18, 4, 6, 90, "Strength", "A large transparent cube filled\nwith the remains of adventurers.");
            Monster bulette = new Monster("Boulette", 20, 2, 12, 20, 90, 90, 8, 36, 7, 17, 90, "Strength", "Lives underground and has\ndeveloped a hard shell.");
            Monster couatl = new Monster("Couatl", 16, 18, 20, 16, 95, 95, 5, 15, 8, 19, 100, "Intelligence", "Seperntlike with feathered wings.");
            Monster treant = new Monster("Treant", 24, 12, 8, 22, 115, 115, 9, 25, 10, 16, 120, "Strength", "This tree seems to have\ncome to life.");
            Monster vampire = new Monster("Vampire", 18, 16, 18, 18, 100, 100, 8, 28, 9, 16, 140, "Strength", "Pale with pointed fangs.\nIt seems to fade into the shadows.");
            Monster hydra = new Monster("Hydra", 20, 2, 12, 20, 140, 140, 12, 30, 8, 15, 180, "Strength", "A three headed serpent\nwith sharp teeth.");
            Monster remorhaz = new Monster("Remorhaz", 24, 4, 14, 22, 160, 16, 13, 35, 11, 17, 200, "Strength", "Hundreds of legs support\nthis massive centipede.");


            //List<Monster> level1 = new List<Monster>()
            //{
            //    flyingcat,
            //    flumph,
            //    kobold,
            //    magmin,
            //    troglodyt,
            //    modron,
            //    skeleton,
            //};
            ///*
            // * Level 1
            // *  flyingcat,
            // *  flumph,         remove at level 4
            // *  kobold,         remove at level 4
            // *  magmin,         remove at level 4
            // *  troglodyt,      remove at level 5
            // *  modron,         remove at level 5
            // *  skeleton        
            // *  
            // * Level 3 
            // *  hobgoblin,      remove at level 7
            // *  gnoll,          remove at level 7
            // *  dryad,          remove at level 7
            // *  willOWisp,      remove at level 7
            // *  bandit,         remove at level 7
            // *  zombie          
            // * 
            // * Level 5
            // *  harpy,
            // *  warewolf,
            // *  basilisk,
            // *  griffon,
            // *  
            // * Level 7
            // *  gibberingMouther,
            // *  troll,
            // *  gelatinousCube,
            // *  bulette,
            // *  
            // * Level 9
            // *  couatl,
            // *  treant,
            // *  
            // * Level 11
            // *  vampire
            // *  
            // * Level 13
            // *  hydra,
            // *  remorhaz
            // * 
            // */



            #endregion

            #region PlayerMenuDisplay


            ////Player Stats
            //// bottom left coordinate x=5,y=43
            ////bottom right coordinate x=30,y=43
            ////top left coordinate x=5,y=25
            ////top right coordinate x=30,y=25
            //const int MENU_START_X = 5;
            //const int MENU_END_X = 30;
            //const int MENU_LOWER_Y = 42;
            //const int MENU_UPPER_Y = 24;
            ////Vertical line left side
            //for (int i = MENU_UPPER_Y; i <= MENU_LOWER_Y; i++)
            //{
            //    Console.SetCursorPosition(MENU_START_X, i);
            //    Console.WriteLine("║");
            //};
            //for (int i = MENU_UPPER_Y; i <= MENU_LOWER_Y; i++)
            //{
            //    Console.SetCursorPosition(MENU_END_X, i);
            //    Console.WriteLine("║");
            //};
            //for (int i = MENU_START_X; i <= MENU_END_X; i++)
            //{
            //    Console.SetCursorPosition(i, MENU_LOWER_Y);
            //    Console.WriteLine("═");
            //};
            //for (int i = MENU_START_X; i <= MENU_END_X; i++)
            //{
            //    Console.SetCursorPosition(i, MENU_UPPER_Y);
            //    Console.WriteLine("═");
            //};
            //Console.SetCursorPosition(5, 42);
            //Console.WriteLine("╚");
            //Console.SetCursorPosition(30, 42);
            //Console.WriteLine("╝");
            //Console.SetCursorPosition(5, 24);
            //Console.WriteLine("╔");
            //Console.SetCursorPosition(30, 24);
            //Console.WriteLine("╗");


            //string[] stringPlayer = mainPlayer.ToString().Split('\n');
            //for (int i = 0; i < stringPlayer.Length; i++)
            //{
            //    Console.SetCursorPosition(7, i + 26);
            //    Console.WriteLine(stringPlayer[i]);
            //}
            #endregion
            DispWarehouse.ShowPlayer(mainPlayer);
            #region MonsterMenuDisplay

            ////window size x159,y45
            ////Player Stats
            //// bottom left coordinate x=115,y=20
            ////bottom right coordinate x=154,y=20
            ////top left coordinate x=124,y=2
            ////top right coordinate x=154,y=2
            //const int MENU_START_X = 115;
            //const int MENU_END_X = 154;
            //const int MENU_LOWER_Y = 20;
            //const int MENU_UPPER_Y = 2;
            ////Vertical line left side
            //for (int i = MENU_UPPER_Y; i <= MENU_LOWER_Y; i++)
            //{
            //    Console.SetCursorPosition(MENU_START_X, i);
            //    Console.WriteLine("║");
            //};
            //for (int i = MENU_UPPER_Y; i <= MENU_LOWER_Y; i++)
            //{
            //    Console.SetCursorPosition(MENU_END_X, i);
            //    Console.WriteLine("║");
            //};
            //for (int i = MENU_START_X; i <= MENU_END_X; i++)
            //{
            //    Console.SetCursorPosition(i, MENU_LOWER_Y);
            //    Console.WriteLine("═");
            //};
            //for (int i = MENU_START_X; i <= MENU_END_X; i++)
            //{
            //    Console.SetCursorPosition(i, MENU_UPPER_Y);
            //    Console.WriteLine("═");
            //};
            //Console.SetCursorPosition(MENU_START_X, MENU_LOWER_Y);
            //Console.WriteLine("╚");
            //Console.SetCursorPosition(MENU_END_X, MENU_LOWER_Y);
            //Console.WriteLine("╝");
            //Console.SetCursorPosition(MENU_START_X, MENU_UPPER_Y);
            //Console.WriteLine("╔");
            //Console.SetCursorPosition(MENU_END_X, MENU_UPPER_Y);
            //Console.WriteLine("╗");


            //string[] stringMonster = remorhaz.ToString().Split('\n');
            //for (int i = 0; i < stringMonster.Length; i++)
            //{
            //    Console.SetCursorPosition(MENU_START_X + 2, i + MENU_UPPER_Y + 2);
            //    Console.WriteLine(stringMonster[i]);
            //}

            #endregion
            DispWarehouse.ShowMonster(remorhaz);
            #region MapDisplay

            ////window size x159,y45
            ////Player Stats
            //// bottom left coordinate x=114,y=42
            ////bottom right coordinate x=154,y=42
            ////top left coordinate x=114,y=26
            ////top right coordinate x=154,y=26
            //const int MENU_START_X = 114;
            //const int MENU_END_X = 154;
            //const int MENU_LOWER_Y = 42;
            //const int MENU_UPPER_Y = 26;
            ////Vertical line left side
            //Console.ForegroundColor = ConsoleColor.Blue;
            //for (int i = MENU_UPPER_Y; i <= MENU_LOWER_Y; i++)
            //{
            //    Console.SetCursorPosition(MENU_START_X, i);
            //    Console.WriteLine("║");
            //};
            //for (int i = MENU_UPPER_Y; i <= MENU_LOWER_Y; i++)
            //{
            //    Console.SetCursorPosition(MENU_END_X, i);
            //    Console.WriteLine("║");
            //};
            //for (int i = MENU_START_X; i <= MENU_END_X; i++)
            //{
            //    Console.SetCursorPosition(i, MENU_LOWER_Y);
            //    Console.WriteLine("═");
            //};
            //for (int i = MENU_START_X; i <= MENU_END_X; i++)
            //{
            //    Console.SetCursorPosition(i, MENU_UPPER_Y);
            //    Console.WriteLine("═");
            //};
            //Console.SetCursorPosition(MENU_START_X, MENU_LOWER_Y);
            //Console.WriteLine("╚");
            //Console.SetCursorPosition(MENU_END_X, MENU_LOWER_Y);
            //Console.WriteLine("╝");
            //Console.SetCursorPosition(MENU_START_X, MENU_UPPER_Y);
            //Console.WriteLine("╔");
            //Console.SetCursorPosition(MENU_END_X, MENU_UPPER_Y);
            //Console.WriteLine("╗");
            //Console.ResetColor();


            //string map =
            //  "┌───┬───┬───┬───┬───┬───┬───┬───┬───┐\n" +
            //  "|   |   |   |   |   |   |   |   |   |\n" +
            //  "├───┼───┼───┼───┼───┼───┼───┼───┼───┤\n" +
            //  "|   |   |   |   |   |   |   |   |   |\n" +
            //  "├───┼───┼───┼───┼───┼───┼───┼───┼───┤\n" +
            //  "|   |   |   |   |   |   |   |   |   |\n" +
            //  "├───┼───┼───┼───┼───┼───┼───┼───┼───┤\n" +
            //  "|   |   |   |   |   |   |   |   |   |\n" +
            //  "├───┼───┼───┼───┼───┼───┼───┼───┼───┤\n" +
            //  "|   |   |   |   |   |   |   |   |   |\n" +
            //  "├───┼───┼───┼───┼───┼───┼───┼───┼───┤\n" +
            //  "|   |   |   |   |   |   |   |   |   |\n" +
            //  "├───┼───┼───┼───┼───┼───┼───┼───┼───┤\n" +
            //  "|   |   |   |   |   |   |   |   |   |\n" +
            //  "└───┴───┴───┴───┴───┴───┴───┴───┴───┘";

            //string[] stringMap = map.ToString().Split('\n');
            //for (int i = 0; i < stringMap.Length; i++)
            //{
            //    Console.SetCursorPosition(MENU_START_X + 2, i + MENU_UPPER_Y + 1);
            //    Console.WriteLine(stringMap[i]);
            //}


            #endregion
            DispWarehouse.ShowMap();
            #region ControlDisplay

            ////window size x159,y45
            ////Control Display
            //// bottom left coordinate x=51,y=38
            ////bottom right coordinate x=102,y=38
            ////top left coordinate x=51,y=28
            ////top right coordinate x=102,y=28
            //const int MENU_START_X = 51;
            //const int MENU_END_X = 102;
            //const int MENU_LOWER_Y = 38;
            //const int MENU_UPPER_Y = 28;
            //Console.ForegroundColor = ConsoleColor.Blue;
            //for (int i = MENU_UPPER_Y; i <= MENU_LOWER_Y; i++)
            //{
            //    Console.SetCursorPosition(MENU_START_X, i);
            //    Console.WriteLine("║");
            //};
            //for (int i = MENU_UPPER_Y; i <= MENU_LOWER_Y; i++)
            //{
            //    Console.SetCursorPosition(MENU_END_X, i);
            //    Console.WriteLine("║");
            //};
            //for (int i = MENU_START_X; i <= MENU_END_X; i++)
            //{
            //    Console.SetCursorPosition(i, MENU_LOWER_Y);
            //    Console.WriteLine("═");
            //};
            //for (int i = MENU_START_X; i <= MENU_END_X; i++)
            //{
            //    Console.SetCursorPosition(i, MENU_UPPER_Y);
            //    Console.WriteLine("═");
            //};
            //Console.SetCursorPosition(MENU_START_X, MENU_LOWER_Y);
            //Console.WriteLine("╚");
            //Console.SetCursorPosition(MENU_END_X, MENU_LOWER_Y);
            //Console.WriteLine("╝");
            //Console.SetCursorPosition(MENU_START_X, MENU_UPPER_Y);
            //Console.WriteLine("╔");
            //Console.SetCursorPosition(MENU_END_X, MENU_UPPER_Y);
            //Console.WriteLine("╗");
            //Console.ResetColor();


            //string seven = "┌───┐\n| 7 |\n└───┘";
            //string eight = "┌───┐\n| 8 |\n└───┘";
            //string nine = "┌───┐\n| 9 |\n└───┘";
            //string four = "┌───┐\n| 4 |\n└───┘";
            //string five = "┌───┐\n| 5 |\n└───┘";
            //string six = "┌───┐\n| 6 |\n└───┘";
            //string one = "┌───┐\n| 1 |\n└───┘";
            //string two = "┌───┐\n| 2 |\n└───┘";
            //string three = "┌───┐\n| 3 |\n└───┘";



            //string[] stringSeven = seven.ToString().Split('\n');
            //for (int i = 0; i < stringSeven.Length; i++)
            //{
            //    Console.SetCursorPosition(MENU_START_X + 2, i + MENU_UPPER_Y + 1);
            //    Console.WriteLine(stringSeven[i]);
            //}
            //string[] stringEight = eight.ToString().Split('\n');
            //for (int i = 0; i < stringEight.Length; i++)
            //{
            //    Console.SetCursorPosition(MENU_START_X + 18, i + MENU_UPPER_Y + 1);
            //    Console.WriteLine(stringEight[i]);
            //}
            //string[] stringNine = nine.ToString().Split('\n');
            //for (int i = 0; i < stringNine.Length; i++)
            //{
            //    Console.SetCursorPosition(MENU_START_X + 35, i + MENU_UPPER_Y + 1);
            //    Console.WriteLine(stringNine[i]);
            //}
            //string[] stringFour = four.ToString().Split('\n');
            //for (int i = 0; i < stringFour.Length; i++)
            //{
            //    Console.SetCursorPosition(MENU_START_X + 2, i + MENU_UPPER_Y + 4);
            //    Console.WriteLine(stringFour[i]);
            //}
            //string[] stringFive = five.ToString().Split('\n');
            //for (int i = 0; i < stringFive.Length; i++)
            //{
            //    Console.SetCursorPosition(MENU_START_X + 18, i + MENU_UPPER_Y + 4);
            //    Console.WriteLine(stringFive[i]);
            //}
            //string[] stringSix = six.ToString().Split('\n');
            //for (int i = 0; i < stringSix.Length; i++)
            //{
            //    Console.SetCursorPosition(MENU_START_X + 35, i + MENU_UPPER_Y + 4);
            //    Console.WriteLine(stringSix[i]);
            //}
            //string[] stringOne = one.ToString().Split('\n');
            //for (int i = 0; i < stringOne.Length; i++)
            //{
            //    Console.SetCursorPosition(MENU_START_X + 2, i + MENU_UPPER_Y + 7);
            //    Console.WriteLine(stringOne[i]);
            //}
            //string[] stringTwo = two.ToString().Split('\n');
            //for (int i = 0; i < stringTwo.Length; i++)
            //{
            //    Console.SetCursorPosition(MENU_START_X + 18, i + MENU_UPPER_Y + 7);
            //    Console.WriteLine(stringTwo[i]);
            //}
            //string[] stringThree = three.ToString().Split('\n');
            //for (int i = 0; i < stringThree.Length; i++)
            //{
            //    Console.SetCursorPosition(MENU_START_X + 35, i + MENU_UPPER_Y + 7);
            //    Console.WriteLine(stringThree[i]);
            //}


            //
            //╔══════════════════════════════════════════════════╗
            //║ ┌───┐           ┌───┐            ┌───┐           ║
            //║ | 7 |           | 8 | move north | 9 |           ║
            //║ └───┘           └───┘            └───┘           ║
            //║ ┌───┐           ┌───┐            ┌───┐           ║
            //║ | 4 | move west | 5 | rest       | 6 | move east ║
            //║ └───┘           └───┘            └───┘           ║
            //║ ┌───┐           ┌───┐            ┌───┐           ║
            //║ | 1 |           | 2 | move south | 3 | exit      ║
            //║ └───┘           └───┘            └───┘           ║
            //╚══════════════════════════════════════════════════╝
            //
            // ┌───┐         ┌───┐          ┌───┐
            // | 7 | attack  | 8 | north    | 9 | run away
            // └───┘         └───┘          └───┘
            // ┌───┐         ┌───┐          ┌───┐
            // | 4 | east    | 5 | rest     | 6 | west
            // └───┘         └───┘          └───┘
            // ┌───┐         ┌───┐          ┌───┐
            // | 1 |         | 2 | south    | 3 | exit
            // └───┘         └───┘          └───┘
            //
            //
            //


            #endregion
            DispWarehouse.ShowControl();
            #region MapMenu


            //Map Control Setup


            ////Map Menu
            //// bottom left coordinate x=51,y=38
            ////bottom right coordinate x=102,y=38
            ////top left coordinate x=51,y=28
            ////top right coordinate x=102,y=28
            //const int MENU_START_X = 51;
            //const int MENU_UPPER_Y = 28;

            //Console.SetCursorPosition(MENU_START_X + 8, MENU_UPPER_Y + 2);
            //Console.WriteLine("          ");
            //Console.SetCursorPosition(MENU_START_X + 24, MENU_UPPER_Y + 2);
            //Console.WriteLine("Move North");
            //Console.SetCursorPosition(MENU_START_X + 41, MENU_UPPER_Y + 2);
            //Console.WriteLine("          ");
            //Console.SetCursorPosition(MENU_START_X + 8, MENU_UPPER_Y + 5);
            //Console.WriteLine("Move West");
            //Console.SetCursorPosition(MENU_START_X + 24, MENU_UPPER_Y + 5);
            //Console.WriteLine("Rest");
            //Console.SetCursorPosition(MENU_START_X + 41, MENU_UPPER_Y + 5);
            //Console.WriteLine("Move East");
            //Console.SetCursorPosition(MENU_START_X + 8, MENU_UPPER_Y + 8);
            //Console.WriteLine("Inventory");
            //Console.SetCursorPosition(MENU_START_X + 24, MENU_UPPER_Y + 8);
            //Console.WriteLine("Move South");
            //Console.SetCursorPosition(MENU_START_X + 41, MENU_UPPER_Y + 8);
            //Console.WriteLine("Exit");

            #endregion
            DispWarehouse.MapMenu();
            Console.ReadKey(true);
            #region BattleMenu


            ////Battle Menu
            //// bottom left coordinate x=58,y=38
            ////bottom right coordinate x=102,y=38
            ////top left coordinate x=58,y=28
            ////top right coordinate x=102,y=28
            //const int MENU_START_X = 51;
            //const int MENU_UPPER_Y = 28;

            //Console.SetCursorPosition(MENU_START_X + 8, MENU_UPPER_Y + 2);
            //Console.WriteLine("Attack");
            //Console.SetCursorPosition(MENU_START_X + 24, MENU_UPPER_Y + 2);
            //Console.WriteLine("          ");
            //Console.SetCursorPosition(MENU_START_X + 41, MENU_UPPER_Y + 2);
            //Console.WriteLine("Run Away");
            //Console.SetCursorPosition(MENU_START_X + 8, MENU_UPPER_Y + 5);
            //Console.WriteLine("          ");
            //Console.SetCursorPosition(MENU_START_X + 24, MENU_UPPER_Y + 5);
            //Console.WriteLine("          ");
            //Console.SetCursorPosition(MENU_START_X + 41, MENU_UPPER_Y + 5);
            //Console.WriteLine("          ");
            //Console.SetCursorPosition(MENU_START_X + 8, MENU_UPPER_Y + 8);
            //Console.Write("Inventory");
            //Console.SetCursorPosition(MENU_START_X + 24, MENU_UPPER_Y + 8);
            //Console.WriteLine("          ");
            //Console.SetCursorPosition(MENU_START_X + 41, MENU_UPPER_Y + 8);
            //Console.WriteLine("Exit");

            #endregion
            DispWarehouse.BattleMenu();

            #region TextDisplay

            //// bottom left coordinate x=46,y=30
            ////bottom right coordinate x=97,y=30
            ////top left coordinate x=46,y=
            ////top right coordinate x=97,y=18
            const int MENU_START_X = 46;
            const int MENU_END_X = 97;
            const int MENU_LOWER_Y = 30;
            const int MENU_UPPER_Y = 8;

            int lineTracker = 0;
            int textLine = 0;
            string inputString = "Hello\nThis is a Test\nof the text\n\nDisplay.";
            string[] textString = inputString.Split("\n");
            for (int i = 0; i < textString.Length; i++)
            {

                Console.SetCursorPosition(MENU_START_X, MENU_UPPER_Y + textLine);
                Console.WriteLine("                                                     ");
                Console.SetCursorPosition(MENU_START_X, MENU_UPPER_Y + textLine);
                Console.WriteLine(textString[i]);

                Thread.Sleep(400);

                textLine++;

                if(textLine == MENU_LOWER_Y)
                {
                    textLine = 0;
                }

                lineTracker = textLine;
            }
            


            #endregion




            Console.ReadKey(true);

        }

        


    }
}
