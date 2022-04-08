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

            Player player1 = new Player();
            player1.Strength = 10;
            player1.Intelligence = 10;
            player1.Dexterity = 10;
            player1.Constitution = 10;

            bool classMenu = true;
            do
            {

                Console.WriteLine("Choose your Class\n");
                foreach (var item in classes)
                {

                    Console.WriteLine(item);
                }
                Console.WriteLine("1) Warrior\n2) Wizard\n3) Rogue\n4) Ranger\n");

                string classSelection = "";
                string classConfirmation"";
                classSelection = Console.ReadKey(true).Key.ToString();

                switch (classSelection)
                {
                    case "D1":
                    case "NumPad1":
                        Console.WriteLine($"You chose Warrior.\n{warrior}\nAre you sure? Y/N");
                        classConfirmation = Console.ReadKey(true).Key.ToString();
                        if (classConfirmation == "Y")
                        {
                            player1.PClass = warrior;
                            classMenu = !classMenu;
                        }
                        else { }
                        break;
                    case "D2":
                    case "NumPad2":
                        Console.WriteLine($"You chose Warrior.\n{wizard}\nAre you sure? Y/N");
                        classConfirmation = Console.ReadKey(true).Key.ToString();
                        if (classConfirmation == "Y")
                        {
                            player1.PClass = wizard;
                            classMenu = !classMenu;
                        }
                        else { }
                        break;
                    case "D3":
                    case "NumPad3":
                        Console.WriteLine($"You chose Warrior.\n{rogue}\nAre you sure? Y/N");
                        classConfirmation = Console.ReadKey(true).Key.ToString();
                        if (classConfirmation == "Y")
                        {
                            player1.PClass = rogue;
                            classMenu = !classMenu;
                        }
                        else { }
                        break;
                    case "D4":
                    case "NumPad4":
                        Console.WriteLine($"You chose Warrior.\n{ranger}\nAre you sure? Y/N");
                        classConfirmation = Console.ReadKey(true).Key.ToString();
                        if (classConfirmation == "Y")
                        {
                            player1.PClass = ranger;
                            classMenu = !classMenu;
                        }
                        else { }
                        break;
                    default:
                        Console.WriteLine("Input not valid...");
                        break;
                } 
            } while (classMenu);

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
                raceSelection = Console.ReadKey(true).Key.ToString();

                switch (raceSelection)
                {
                    case "D1":
                    case "NumPad1":
                        player1.PRace = halforc;
                        raceMenu = !raceMenu;
                        break;
                    case "D2":
                    case "NumPad2":
                        player1.PRace = elf;
                        raceMenu = !raceMenu;
                        break;
                    case "D3":
                    case "NumPad3":
                        player1.PRace = halfling;
                        raceMenu = !raceMenu;
                        break;
                    case "D4":
                    case "NumPad4":
                        player1.PRace = gnome;
                        raceMenu = !raceMenu;
                        break;
                    case "D5":
                    case "NumPad5":
                        player1.PRace = human;
                        raceMenu = !raceMenu;
                        break;
                    case "D6":
                    case "NumPad6":
                        player1.PRace = dwarf;
                        raceMenu = !raceMenu;
                        break;
                    case "D7":
                    case "NumPad7":
                        player1.PRace = halfelf;
                        raceMenu = !raceMenu;
                        break;
                    case "D8":
                    case "NumPad8":
                        player1.PRace = tiefling;
                        raceMenu = !raceMenu;
                        break;
                    case "D9":
                    case "NumPad9":
                        player1.PRace = dragonborn;
                        raceMenu = !raceMenu;
                        break;
                    default:
                        Console.WriteLine("Input not valid...");
                        break;
                }
            } while (raceMenu);
            Console.WriteLine(player1);



            //Player player1 = new Player("Warrior", warrior, halforc, w1, 10, 10, 10, 10);
            //Player player2 = new Player("wizard", wizard, halforc, w1, 10, 10, 10, 10);
            //Player player3 = new Player("rogue", rogue, halforc, w1, 10, 10, 10, 10);
            //Player player4 = new Player("ranger", ranger, halforc, w1, 10, 10, 10, 10);


            //Console.WriteLine(player1);
            //Console.WriteLine(player2);
            //Console.WriteLine(player3);
            //Console.WriteLine(player4);

            //Elf,
            //Halfling,
            //Gnome,
            //Human,
            //Orc,
            //Dwarf,
            //HalfElf,
            //Tiefling,
            //Dragonborn



            //Character c1 = new Character("Tain", 20, 20, 20, 20, 20);

            //Console.WriteLine(c1);


            //Console.WriteLine(w1);

            //int life = 0;
            //do
            //{
            //    do
            //    {
            //        life++;

            //    } while (false);
            //    Console.WriteLine(life);
            //} while (false);




        }
    }
}
