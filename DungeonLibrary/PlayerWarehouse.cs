using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class PlayerWarehouse
    {
        public static Player CreatePlayer()
        {

            #region Asset Initialization

            Weapon greatsword = new Weapon("Greatsword", 2, 12, 3, 4, true, WeaponType.Greatsword);
            Weapon staff = new Weapon("Staff", 5, 15, 2, 8, true, WeaponType.Staff);
            Weapon dagger = new Weapon("Dagger", 1, 4, 5, 2, false, WeaponType.Dagger);
            Weapon longbow = new Weapon("Longbow", 2, 12, 6, 6, true, WeaponType.Longbow);


            PlayerClass warrior = new PlayerClass("Warrior", 4, 0, 2, 4, 8, greatsword, "The ultimate fighter.\nFavors strength.\nHigh Health");
            PlayerClass wizard = new PlayerClass("Wizard", 0, 4, 1, 0, 4, staff, "Utilizes magic.\nFavors intelligence.\nLow health.");
            PlayerClass rogue = new PlayerClass("Rogue", 2, 0, 6, 4, 6, dagger, "Fast dagger attacks.\nFavors Dexterity.\nAverage Health");
            PlayerClass ranger = new PlayerClass("Ranger", 0, 2, 6, 4, 4, longbow, "Fires arrows.\nFavors Dexterity.\nAverage Health");

            List<PlayerClass> classes = new List<PlayerClass> { warrior, wizard, rogue, ranger };

            Race halforc = new Race("HalfOrc", 3, 0, 0, 1, "Green tinted skin.\nGreat in a fight.");
            Race elf = new Race("Elf", 0, 2, 1, 1, "Pointed ears.\nWell studied.");
            Race halfling = new Race("Halfling", 0, 1, 3, 0, "Child sized.\nQuick by size.");
            Race gnome = new Race("Gnome", 0, 2, 0, 2, "Barely up to you knee.\nEnjoys tricks.");
            Race human = new Race("Human", 1, 1, 0, 2, "Nothing unique.\nVery young race.");
            Race dwarf = new Race("Dwarf", 1, 0, 0, 3, "Glorious beards.\nCan take a hit.");
            Race halfelf = new Race("Half-Elf", 1, 1, 1, 1, "An elf but a human\nBalanced in everything.");
            Race tiefling = new Race("Tiefling", 0, 2, 2, 0, "Part demon with horns.\nQuick and smart.");
            Race dragonborn = new Race("Dragonborn", 1, 3, 0, 0, "Scaly like a dragon\nInherited knowledge.");

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
                Console.SetCursorPosition(31, 2);
                Console.WriteLine(@"
                               ╔═════════════════════════════════════════════════════════════════════════════════════════════════╗
                               ║    ___  _  _   __    __   ____  ____    _  _  __   _  _  ____     ___  __     __   ____  ____   ║
                               ║   / __)/ )( \ /  \  /  \ / ___)(  __)  ( \/ )/  \ / )( \(  _ \   / __)(  )   / _\ / ___)/ ___)  ║
                               ║  ( (__ ) __ ((  O )(  O )\___ \ ) _)    )  /(  O )) \/ ( )   /  ( (__ / (_/\/    \\___ \\___ \  ║
                               ║   \___)\_)(_/ \__/  \__/ (____/(____)  (__/  \__/ \____/(__\_)   \___)\____/\_/\_/(____/(____/  ║
                               ║                                                                                                 ║
                               ╚═════════════════════════════════════════════════════════════════════════════════════════════════╝");

                string[] stringWarrior = warrior.ToString().Split('\n');
                for (int i = 0; i < stringWarrior.Length; i++)
                {
                    Console.SetCursorPosition(31, i + 11);
                    Console.WriteLine(stringWarrior[i]);
                }
                string[] stringWizard = wizard.ToString().Split('\n');
                for (int i = 0; i < stringWizard.Length; i++)
                {
                    Console.SetCursorPosition(57, i + 11);
                    Console.WriteLine(stringWizard[i]);
                }
                string[] stringRogue = rogue.ToString().Split('\n');
                for (int i = 0; i < stringRogue.Length; i++)
                {
                    Console.SetCursorPosition(83, i + 11);
                    Console.WriteLine(stringRogue[i]);
                }
                string[] stringRanger = ranger.ToString().Split('\n');
                for (int i = 0; i < stringRanger.Length; i++)
                {
                    Console.SetCursorPosition(109, i + 11);
                    Console.WriteLine(stringRanger[i]);
                }

                Console.SetCursorPosition(31, 23);
                Console.WriteLine("1) Warrior");
                Console.SetCursorPosition(57, 23);
                Console.WriteLine("2) Wizard");
                Console.SetCursorPosition(83, 23);
                Console.WriteLine("3) Rogue");
                Console.SetCursorPosition(109, 23);
                Console.WriteLine("4) Ranger");




                //Console.WriteLine("Choose your Class\n");
                //foreach (var item in classes)
                //{

                //    Console.WriteLine(item);
                //}
                //Console.WriteLine("1) Warrior\n2) Wizard\n3) Rogue\n4) Ranger\n");
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
                }
                if (menuSuccess == true)
                {
                    Console.SetCursorPosition(31, 25);
                    Console.WriteLine($"You chose {pClass.Name}. Are you sure? Y/N");
                    classConfirmation = Console.ReadKey(true).Key.ToString();
                    Console.Clear();
                    if (classConfirmation == "Y")
                    {
                        classMenu = !classMenu;
                    }
                }
            } while (classMenu);

            #endregion

            #region Race Selection


            bool raceMenu = true;
            do
            {
                Console.SetCursorPosition(31, 2);
                Console.WriteLine(@"
                               ╔═════════════════════════════════════════════════════════════════════════════════════════════════╗
                               ║       ___  _  _   __    __   ____  ____    _  _  __   _  _  ____    ____   __    ___  ____      ║
                               ║      / __)/ )( \ /  \  /  \ / ___)(  __)  ( \/ )/  \ / )( \(  _ \  (  _ \ / _\  / __)(  __)     ║
                               ║     ( (__ ) __ ((  O )(  O )\___ \ ) _)    )  /(  O )) \/ ( )   /   )   //    \( (__  ) _)      ║
                               ║      \___)\_)(_/ \__/  \__/ (____/(____)  (__/  \__/ \____/(__\_)  (__\_)\_/\_/ \___)(____)     ║
                               ║                                                                                                 ║
                               ╚═════════════════════════════════════════════════════════════════════════════════════════════════╝");

                string[] stringHalforc = halforc.ToString().Split('\n');
                for (int i = 0; i < stringHalforc.Length; i++)
                {
                    Console.SetCursorPosition(19, i + 11);
                    Console.WriteLine(stringHalforc[i]);
                }
                string[] stringElf = elf.ToString().Split('\n');
                for (int i = 0; i < stringElf.Length; i++)
                {
                    Console.SetCursorPosition(45, i + 11);
                    Console.WriteLine(stringElf[i]);
                }
                string[] stringHalfling = halfling.ToString().Split('\n');
                for (int i = 0; i < stringHalfling.Length; i++)
                {
                    Console.SetCursorPosition(71, i + 11);
                    Console.WriteLine(stringHalfling[i]);
                }
                string[] stringGnome = gnome.ToString().Split('\n');
                for (int i = 0; i < stringGnome.Length; i++)
                {
                    Console.SetCursorPosition(97, i + 11);
                    Console.WriteLine(stringGnome[i]);
                }
                string[] stringHuman = human.ToString().Split('\n');
                for (int i = 0; i < stringHuman.Length; i++)
                {
                    Console.SetCursorPosition(123, i + 11);
                    Console.WriteLine(stringHuman[i]);
                }
                string[] stringDwarf = dwarf.ToString().Split('\n');
                for (int i = 0; i < stringDwarf.Length; i++)
                {
                    Console.SetCursorPosition(31, i + 24);
                    Console.WriteLine(stringDwarf[i]);
                }
                string[] stringHalfelf = halfelf.ToString().Split('\n');
                for (int i = 0; i < stringHalfelf.Length; i++)
                {
                    Console.SetCursorPosition(57, i + 24);
                    Console.WriteLine(stringHalfelf[i]);
                }
                string[] stringTiefling = tiefling.ToString().Split('\n');
                for (int i = 0; i < stringGnome.Length; i++)
                {
                    Console.SetCursorPosition(83, i + 24);
                    Console.WriteLine(stringGnome[i]);
                }
                string[] stringDragonborn = dragonborn.ToString().Split('\n');
                for (int i = 0; i < stringDragonborn.Length; i++)
                {
                    Console.SetCursorPosition(109, i + 24);
                    Console.WriteLine(stringDragonborn[i]);
                }

                Console.SetCursorPosition(19, 21);
                Console.WriteLine("1) Half-Orc");
                Console.SetCursorPosition(45, 21);
                Console.WriteLine("2) Elf");
                Console.SetCursorPosition(71, 21);
                Console.WriteLine("3) Halfling");
                Console.SetCursorPosition(97, 21);
                Console.WriteLine("4) Gnome");
                Console.SetCursorPosition(123, 21);
                Console.WriteLine("5) Human");
                Console.SetCursorPosition(31, 34);
                Console.WriteLine("6) Dwarf");
                Console.SetCursorPosition(57, 34);
                Console.WriteLine("7) Half-Elf");
                Console.SetCursorPosition(83, 34);
                Console.WriteLine("8) Tiefling");
                Console.SetCursorPosition(109, 34);
                Console.WriteLine("9) Dragonborn");


                //Console.WriteLine("Choose your Race\n");
                //foreach (var item in races)
                //{

                //    Console.WriteLine(item);
                //}
                //Console.WriteLine("1) Half-Orc\t\t2) Elf\n3) Halfling\t\t4) Gnome\n5) Human\t\t6) Dwarf\n7) Half-Elf\t\t8)Tiefling\n9) Dragonborn");

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
                    Console.SetCursorPosition(31, 36);
                    Console.WriteLine($"You chose {pRace.Name}. Are you sure? Y/N");
                    raceConfirmation = Console.ReadKey(true).Key.ToString();
                    Console.Clear();
                    if (raceConfirmation == "Y")
                    {
                        raceMenu = !raceMenu;
                    }
                    else { }
                }
            } while (raceMenu);

            MapCoordinates pMap = new MapCoordinates(1, 1);

            Player mainPlayer = new Player(pName, pClass, pRace, 10, 10, 10, 10, pMap);
            #endregion

            #region Name Selection

            Console.SetCursorPosition(31, 2);
            Console.WriteLine(@"
                               ╔═════════════════════════════════════════════════════════════════════════════════════════════════╗
                               ║          _  _  __   _  _  ____     ___  _  _   __   ____   __    ___  ____  ____  ____          ║
                               ║         ( \/ )/  \ / )( \(  _ \   / __)/ )( \ / _\ (  _ \ / _\  / __)(_  _)(  __)(  _ \         ║
                               ║          )  /(  O )) \/ ( )   /  ( (__ ) __ (/    \ )   //    \( (__   )(   ) _)  )   /         ║
                               ║         (__/  \__/ \____/(__\_)   \___)\_)(_/\_/\_/(__\_)\_/\_/ \___) (__) (____)(__\_)         ║
                               ║                                                                                                 ║
                               ╚═════════════════════════════════════════════════════════════════════════════════════════════════╝");

            string[] playerClass = pClass.ToString().Split('\n');
            for (int i = 0; i < playerClass.Length; i++)
            {
                Console.SetCursorPosition(45, i + 11);
                Console.WriteLine(playerClass[i]);
            }
            string[] mainString = mainPlayer.ToString().Split('\n');
            for (int i = 0; i < mainString.Length; i++)
            {
                Console.SetCursorPosition(71, i + 11);
                Console.WriteLine(mainString[i]);
            }
            string[] playerRace = pRace.ToString().Split('\n');
            for (int i = 0; i < playerRace.Length; i++)
            {
                Console.SetCursorPosition(97, i + 11);
                Console.WriteLine(playerRace[i]);
            }




            bool nameMenu = true;
            string nameConfirmation = "";
            do
            {
                Console.WriteLine("What is your name?");
                pName = Console.ReadLine().ToString();
                mainPlayer.Name = pName;
                mainString = mainPlayer.ToString().Split('\n');
                for (int i = 0; i < mainString.Length; i++)
                {
                    Console.SetCursorPosition(71, i + 11);
                    Console.WriteLine(mainString[i]);
                }
                Console.WriteLine($"Your name is {pName}.\n\nDo you want to keep this? Y/N");
                nameConfirmation = Console.ReadKey(true).Key.ToString();


                if (nameConfirmation == "Y")
                {
                    nameMenu = !nameMenu;
                }
                else
                {
                    mainPlayer.Name = "";
                    mainString = mainPlayer.ToString().Split('\n');
                    for (int i = 0; i < mainString.Length; i++)
                    {
                        Console.SetCursorPosition(71, i + 11);
                        Console.WriteLine(mainString[i]);
                    }
                }
            } while (nameMenu);

            #endregion



            return mainPlayer;
        }


        public static void LevelMenu(Player player)
        {
            Console.Clear();
            Console.WriteLine("Congratulations! You have leveled up!");
            for (int i = 2; i > 0; i--)
            {
                bool statSelect = true;
                string menuSelect = "";

                do
                {
                    Console.WriteLine(player);

                    Console.WriteLine($"\nYou have {i} additional stat points to apply.\n" +
                        "1) Strength\n" +
                        "2) Intelligence\n" +
                        "3) Dexterity\n" +
                        "4) Constitution");
                    Console.Write("Choose which stat to increase: ");
                    menuSelect = Console.ReadKey(true).Key.ToString();
                    Console.Clear();
                    switch (menuSelect)
                    {
                        case "D1":
                        case "NumPad1":
                            Console.WriteLine("+1 Strength\n");
                            player.Strength++;
                            break;
                        case "D2":
                        case "NumPad2":
                            Console.WriteLine("+1 Intelligence\n");
                            player.Intelligence++;
                            break;
                        case "D3":
                        case "NumPad3":
                            Console.WriteLine("+1 Dexterity\n");
                            player.Dexterity++;
                            break;
                        case "D4":
                        case "NumPad4":
                            Console.WriteLine("+1 Constitution\n");
                            player.Constitution++;
                            break;
                        default:
                            Console.WriteLine("Invalid Input\n");
                            statSelect = !statSelect;
                            break;
                    }
                } while (!statSelect);
            }
            player.Level++;
            player.Exp = 0;
            player.MaxHealth = player.MaxHealth;
        }


        public static void LevelUp(Player player)
        {
            if (player.Level == 1 && player.Exp >= 100)
            {
                LevelMenu(player);
            }
            else if (player.Level == 2 && player.Exp >= 200)
            {
                LevelMenu(player);
            }
            else if (player.Level == 3 && player.Exp >= 300)
            {
                LevelMenu(player);
            }
            else if (player.Level == 4 && player.Exp >= 400)
            {
                LevelMenu(player);
            }
            else if (player.Level == 5 && player.Exp >= 500)
            {
                LevelMenu(player);
            }
            else if (player.Level == 6 && player.Exp >= 600)
            {
                LevelMenu(player);
            }
            else if (player.Level == 7 && player.Exp >= 700)
            {
                LevelMenu(player);
            }
            else if (player.Level == 8 && player.Exp >= 800)
            {
                LevelMenu(player);
            }
            else if (player.Level == 9 && player.Exp >= 900)
            {
                LevelMenu(player);
            }
            else if (player.Level >= 10 && player.Exp >= 1000)
            {
                LevelMenu(player);
            }
            else { }
        }



    }
}