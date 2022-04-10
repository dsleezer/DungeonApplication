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
            #region Character Creation

            #region Asset Initialization

            Weapon w1 = new Weapon("Greatsword", 2, 12, 3, 4, true, WeaponType.Greatsword);
            // str  int  dex  con hpmod
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
                raceSelection = Console.ReadKey(true).Key.ToString();
                bool menuSuccess = true;

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

            #region Monster Creation

            Monster flyingcat = new Monster("Flying Cat", 4, 12, 16, 10, 9, 9, 2, 2, 18, 10, 200, "Dexterity", "A housecat with wings.");
            Monster flumph = new Monster("Flumph", 8, 14, 16, 12, 10, 10, 2, 8, 4, 12, 25, "Dexterity", "The childlike whimsy of it hides the intent of it's tentacles.");
            Monster kobold = new Monster("Kobold", 8, 8, 16, 10, 11, 11, 3, 7, 4, 12, 25, "Dexterity", "A small humanoid reptile.");
            Monster magmin = new Monster("Magmin", 6, 8, 10, 12, 12, 12, 12, 2, 12, 4, 14, "Dexterity", "Imp-like with flames for hair.");
            Monster troglodyt = new Monster("Troglodyte", 14, 6, 10, 14, 13, 13, 3, 7, 4, 13, 30, "Strength", "Oozing with slime and covered in scales.");
            Monster modron = new Monster("Modron", 6, 14, 8, 12, 14, 14, 2, 8, 5, 12, 30, "Intelligence", "Mechanical with a clock ticking in the center of it's body.");
            Monster skeleton = new Monster("Skeleton", 10, 6, 14, 16, 15, 15, 3, 7, 4, 13, 30, "Dexterity", "Reanimated bones.");
            Monster hobgoblin = new Monster("Hobgoblin", 12, 10, 12, 12, 18, 18, 2, 9, 3, 18, 40, "Strength", "A large goblin that appears stronger than normal.");
            Monster gnoll = new Monster("Gnoll", 14, 6, 12, 8, 22, 22, 3, 10, 4, 15, 40, "Strength", "A ravenous hyena like creature.");
            Monster dryad = new Monster("Dryad", 10, 14, 12, 10, 22, 22, 5, 13, 6, 11, 40, "Intelligence", "As if it was a part of the forest, this humanoid being has plants growing all over it.");
            Monster willOWisp = new Monster("Will-o-Whisp", 0, 14, 28, 10, 22, 22, 2, 16, 4, 19, 40, "Dexterity", "The soul of a creature that has taken shape as a glowing sphere hanging in the air.");
            Monster bandit = new Monster("Bandit", 11, 10, 12, 12, 24, 24, 2, 7, 3, 12, 40, "Strength", "A person who has fallen down on their luck, or loves the thrill of stealing.");
            Monster zombie = new Monster("Zombie", 14, 4, 6, 16, 26, 26, 2, 7, 3, 8, 50, "Strength", "This person looks dead but it's moving.");
            Monster harpy = new Monster("Harpy", 12, 8, 14, 12, 38, 38, 5, 14, 3, 11, 60, "Dexterity", "Entrancing you with the sound of their voice, this feathered creature looks charming.");
            Monster warewolf = new Monster("Warewolf", 16, 10, 14, 14, 50, 50, 10, 24, 4, 11, 60, "Strength", "A man that has turned into a wolf under the full moon.");
            Monster basilisk = new Monster("Basilisk", 16, 2, 8, 16, 52, 52, 6, 17, 5, 15, 70, "Strength", "A large lizard with scales that seem to be made out of stone.");
            Monster griffon = new Monster("Griffon", 18, 2, 16, 16, 55, 55, 10, 20, 6, 12, 70, "Strength", "A four legged bird with the face of an owl.");
            Monster gibberingMouther = new Monster("Gibbering Mouther", 10, 4, 8, 16, 67, 67, 5, 25, 2, 9, 80, "Strength", "An amoeba covered in eyes and mouths chittering as it moves.");
            Monster troll = new Monster("Troll", 18, 8, 14, 20, 80, 80, 7, 26, 7, 15, 80, "Strength", "Gigantic with green skin and large claws.");
            Monster gelatinousCube = new Monster("Gelatinous Cube", 14, 2, 4, 20, 84, 84, 3, 18, 4, 6, 90, "Strength", "A large transparent cube filled with the remains of adventurers.");
            Monster bulette = new Monster("Boulette", 20, 2, 12, 20, 90, 90, 8, 36, 7, 17, 90, "Strength", "Lives underground and has developed a hard shell.");
            Monster couatl = new Monster("Couatl", 16, 18, 20, 16, 95, 95, 5, 15, 8, 19, 100, "Intelligence", "Seperntlike with feathered wings.");
            Monster treant = new Monster("Treant", 24, 12, 8, 22, 115, 115, 9, 25, 10, 16, 120, "Strength", "This tree seems to have come to life.");
            Monster vampire = new Monster("Vampire", 18, 16, 18, 18, 100, 100, 8, 28, 9, 16, 140, "Strength", "Pale with pointed fangs. It seems to fade into the shadows.");
            Monster hydra = new Monster("Hydra", 20, 2, 12, 20, 140, 140, 12, 30, 8, 15, 180, "Strength", "A three headed serpent with sharp teeth.");
            Monster remorhaz = new Monster("Remorhaz", 24, 4, 14, 22, 160, 16, 13, 35, 11, 17, 200, "Strength", "Hundreds of legs support this massive centipede.");


            List<Monster> level1 = new List<Monster>()
            {
                flyingcat,
                flumph,
                kobold,
                magmin,
                troglodyt,
                modron,
                skeleton,
            };
            /*
             * Level 1
             *  flyingcat,
             *  flumph,         remove at level 4
             *  kobold,         remove at level 4
             *  magmin,         remove at level 4
             *  troglodyt,      remove at level 5
             *  modron,         remove at level 5
             *  skeleton        
             *  
             * Level 3 
             *  hobgoblin,      remove at level 7
             *  gnoll,          remove at level 7
             *  dryad,          remove at level 7
             *  willOWisp,      remove at level 7
             *  bandit,         remove at level 7
             *  zombie          
             * 
             * Level 5
             *  harpy,
             *  warewolf,
             *  basilisk,
             *  griffon,
             *  
             * Level 7
             *  gibberingMouther,
             *  troll,
             *  gelatinousCube,
             *  bulette,
             *  
             * Level 9
             *  couatl,
             *  treant,
             *  
             * Level 11
             *  vampire
             *  
             * Level 13
             *  hydra,
             *  remorhaz
             * 
             */



            #endregion







            //int score = 1





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
