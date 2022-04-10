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
            Weapon staff = new Weapon ("Staff", 5, 15, 2, 8, true, WeaponType.Staff);
            Weapon dagger = new Weapon("Dagger", 1, 4, 5, 2, false, WeaponType.Dagger);
            Weapon longbow = new Weapon("Longbow", 2, 12, 6, 6, true, WeaponType.Longbow);


            PlayerClass warrior = new PlayerClass("Warrior", 6, 0, 2, 6, 10, greatsword, "The ultimate fighter, able to hit hard and take hits.");
            PlayerClass wizard = new PlayerClass("Wizard", 0, 4, 1, 0, 4, staff, "Inherently prone to using magic but not very durable.");
            PlayerClass rogue = new PlayerClass("Rogue", 2, 0, 6, 4, 8, dagger, "Prefers sneaking up on enemies and taking them out before they know that anything's there.");
            PlayerClass ranger = new PlayerClass("Ranger", 0, 2, 6, 4, 6, longbow, "Shoots from a distance to keep from getting hurt.");

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
                Console.Clear();
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
                    Console.WriteLine($"You chose {pClass.Name}.\n{pClass}\nAre you sure? Y/N");
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
                Console.Clear();
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
                    Console.Clear();
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
                Console.WriteLine($"Your name is {pName}.\n\nDo you want to keep this? Y/N");
                nameConfirmation = Console.ReadKey(true).Key.ToString();
                Console.Clear();

                if (nameConfirmation == "Y")
                {
                    nameMenu = !nameMenu;
                }
                else { }
            } while (nameMenu);

            #endregion

            Player mainPlayer = new Player(pName, pClass, pRace, 10, 10, 10, 10);


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
            player.MaxHealth += (player.PClass.HealthModifier + ((player.Constitution - 10) / 2));
            player.CurrentHealth = player.MaxHealth;
            Console.WriteLine("Press any key to continue.");
            Console.ReadLine();
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