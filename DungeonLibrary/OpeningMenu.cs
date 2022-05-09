using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class OpeningMenu
    {
        #region Title Screen
        public static void MainMenu()
        {
            Console.SetCursorPosition(31, 2);
            Console.WriteLine(@"
                               ╔═════════════════════════════════════════════════════════════════════════════════════════════════╗
                               ║           ___  __    __  ____  ____  __   __ _     __   __ _  ____    ____  _  _  ____          ║
                               ║          / __)(  )  (  )(  __)(_  _)/  \ (  ( \   / _\ (  ( \(    \  (_  _)/ )( \(  __)         ║
                               ║         ( (__ / (_/\ )(  ) _)   )( (  O )/    /  /    \/    / ) D (    )(  ) __ ( ) _)          ║
                               ║          \___)\____/(__)(__)   (__) \__/ \_)__)  \_/\_/\_)__)(____/   (__) \_)(_/(____)         ║
                               ║                             ____  __     __   _  _  ____  ____  ____                            ║
                               ║                            / ___)(  )   / _\ ( \/ )(  __)(  _ \/ ___)                           ║
                               ║                            \___ \/ (_/\/    \ )  /  ) _)  )   /\___ \                           ║
                               ║                            (____/\____/\_/\_/(__/  (____)(__\_)(____/                           ║
                               ║                                                                                                 ║
                               ╚═════════════════════════════════════════════════════════════════════════════════════════════════╝");


            string menu = "1) New Game\n2) Exit Game";  //\n2) High Score\n3) Test Mode
            string[] stringMenu = menu.ToString().Split('\n');
            for (int i = 0; i < stringMenu.Length; i++)
            {
                Console.SetCursorPosition(70, i + 20);
                Console.WriteLine(stringMenu[i]);
            }
            string selection = "";
            bool mainMenu = true;
            string exitConfirmation = "";
            do
            {
                selection = Console.ReadKey(true).Key.ToString();
                switch (selection)
                {
                    case "D1":  //New Game
                    case "NumPad1":
                        mainMenu = !mainMenu;

                        break;
                    case "D2":
                    case "NumPad2":
                    case "ESCAPE":
                        Console.SetCursorPosition(31, 25);
                        Console.WriteLine("Are you sure you would like to exit? Y/N");
                        exitConfirmation = Console.ReadKey(true).Key.ToString().ToUpper();

                        switch (exitConfirmation)
                        {
                            case "Y":
                            case "ESCAPE":
                                Environment.Exit(0);
                                break;
                            default:
                                break;
                        }

                        //    break;
                        //case "D3":
                        //case "NumPad3":
                        //    mainMenu = !mainMenu;

                        //    break;
                        //case "D4":
                        //case "NumPad4":
                        //    mainMenu = !mainMenu;

                        break;

                    default:
                        Console.SetCursorPosition(31, 25);
                        Console.WriteLine("                                ");
                        Thread.Sleep(20);
                        Console.SetCursorPosition(31, 25);
                        Console.WriteLine("Invalid entry, please try again.");
                        break;
                }
            } while (mainMenu);
        }
        #endregion

        #region FirstStory
        public static void FirstStory()
        {
            Console.SetCursorPosition(70, 20);
            Console.WriteLine("                                        ");
            Console.SetCursorPosition(70, 21);
            Console.WriteLine("                                        ");
            Console.SetCursorPosition(31, 25);
            Console.WriteLine("                                        ");

            string text = "Wake up......";
            int lineNumber = 0;
            Console.SetCursorPosition(31, 15 + lineNumber);
            DispWarehouse.TextWrite(text);
            text = "I SAID WAKE UP!!!";
            lineNumber += 2;
            Thread.Sleep(1000);
            Console.SetCursorPosition(31, 15 + lineNumber);
            DispWarehouse.TextWrite(text);
            text = "You are jolted awake and land on the floor.";
            lineNumber += 2;
            Thread.Sleep(500);
            Console.SetCursorPosition(31, 15 + lineNumber);
            DispWarehouse.TextWrite(text);
            text = "The familiar face of the tavern keeper hovers over you.";
            lineNumber += 1;
            Thread.Sleep(500);
            Console.SetCursorPosition(31, 15 + lineNumber);
            DispWarehouse.TextWrite(text);
            text = "You and your friends made quite the mess last night. You better start cleaning it up.";
            lineNumber += 2;
            Thread.Sleep(500);
            Console.SetCursorPosition(31, 15 + lineNumber);
            DispWarehouse.TextWrite(text);
            text = "Lying on the floor, you remember the conversation of the prior night...";
            lineNumber += 2;
            Thread.Sleep(500);
            Console.SetCursorPosition(31, 15 + lineNumber);
            DispWarehouse.TextWrite(text);
            text = "You met a group of adventurers, their leader was a wizard and called himself Clifton.";
            lineNumber += 1;
            Thread.Sleep(500);
            Console.SetCursorPosition(31, 15 + lineNumber);
            DispWarehouse.TextWrite(text);
            text = "Being a new adventurer yourself you started up a conversation with them.";
            lineNumber += 1;
            Thread.Sleep(500);
            Console.SetCursorPosition(31, 15 + lineNumber);
            DispWarehouse.TextWrite(text);
            text = "They were looking for new potential members but anyone trying to apply has to prove themselves first.";
            lineNumber += 1;
            Thread.Sleep(500);
            Console.SetCursorPosition(31, 15 + lineNumber);
            DispWarehouse.TextWrite(text);
            text = "What did they want you to do again?";
            lineNumber += 2;
            Thread.Sleep(1000);
            Console.SetCursorPosition(31, 15 + lineNumber);
            DispWarehouse.TextWrite(text);
            text = "As you begin picking up the mess around you, you spot a napkin with writing on it.";
            lineNumber += 2;
            Thread.Sleep(500);
            Console.SetCursorPosition(31, 15 + lineNumber);
            DispWarehouse.TextWrite(text);
            text = "Travel northeast from the town of Duskbell and seek out the old tower. Retrieve the locked oak box";
            lineNumber += 2;
            Thread.Sleep(500);
            Console.SetCursorPosition(31, 15 + lineNumber);
            DispWarehouse.TextWrite(text);
            text = "that is kept on an alter at the top of the tower. You'll konw it when you see it. It will be guarded";
            lineNumber += 1;
            Thread.Sleep(500);
            Console.SetCursorPosition(31, 15 + lineNumber);
            DispWarehouse.TextWrite(text);
            text = "by a powerful creature that must be defeated. Bring it back here to Gatterlen and return it to Clifton";
            lineNumber += 1;
            Thread.Sleep(500);
            Console.SetCursorPosition(31, 15 + lineNumber);
            DispWarehouse.TextWrite(text);
            text = "If you survive and are successful, you too can become a Slayer!";
            lineNumber += 1;
            Thread.Sleep(500);
            Console.SetCursorPosition(31, 15 + lineNumber);
            DispWarehouse.TextWrite(text);
            text = "Press any key to begin your journey...";
            lineNumber += 2;
            Thread.Sleep(500);
            Console.SetCursorPosition(31, 15 + lineNumber);
            DispWarehouse.TextWrite(text);
            Console.ReadKey(true);
            Console.Clear();
        }
        #endregion

        #region SecondStory
        public static void SecondStory()
        {
            string text = "As the final blow is struck the silence of the room becomes overbearing.";
            int lineNumber = 0;
            Console.SetCursorPosition(31, 15 + lineNumber);
            DispWarehouse.TextWrite(text);
            text = "You step over the corpse of the fallen enemy to claim your prize.";
            lineNumber += 1;
            Thread.Sleep(500);
            Console.SetCursorPosition(31, 15 + lineNumber);
            DispWarehouse.TextWrite(text);
            text = "Sitting on the lone pedastle in the room is a small wooden box.";
            lineNumber += 1;
            Thread.Sleep(500);
            Console.SetCursorPosition(31, 15 + lineNumber);
            DispWarehouse.TextWrite(text);
            text = "Not seing any signs of traps you pick up the box and open it.";
            lineNumber += 2;
            Thread.Sleep(1000);
            Console.SetCursorPosition(31, 15 + lineNumber);
            DispWarehouse.TextWrite(text);
            text = "It's empty...";
            lineNumber += 2;
            Thread.Sleep(500);
            Console.SetCursorPosition(31, 15 + lineNumber);
            DispWarehouse.TextWrite(text);
            text = "You frantically look around the room for signs of anything else that coule be what you're after.";
            lineNumber += 2;
            Thread.Sleep(500);
            Console.SetCursorPosition(31, 15 + lineNumber);
            DispWarehouse.TextWrite(text);
            text = "Finally after searching for hours and seeing nothing else of note in the room you resign yourself to leave.";
            lineNumber += 1;
            Thread.Sleep(500);
            Console.SetCursorPosition(31, 15 + lineNumber);
            DispWarehouse.TextWrite(text);
            text = "Press any key to continue...";
            lineNumber += 1;
            Thread.Sleep(500);
            Console.SetCursorPosition(31, 15 + lineNumber);
            DispWarehouse.TextWrite(text);
            Console.ReadKey(true);
            Console.Clear();

            text = "Eventually you make your way back to Gatterlen with the empty box hoping that the box itself is";
            lineNumber = 0;
            Thread.Sleep(500);
            Console.SetCursorPosition(31, 15 + lineNumber);
            DispWarehouse.TextWrite(text);
            text = "what Clifton was looking for. You ask around the taverns and usual adventurer hangouts but";
            lineNumber += 1;
            Thread.Sleep(500);
            Console.SetCursorPosition(31, 15 + lineNumber);
            DispWarehouse.TextWrite(text);
            text = "there is no sign of Clifton or any of the Slayers.";
            lineNumber += 2;
            Thread.Sleep(500);
            Console.SetCursorPosition(31, 15 + lineNumber);
            DispWarehouse.TextWrite(text);
            text = "A couple of days go by as you start looking for more work and you spot a pair of adventurers scanning";
            lineNumber += 1;
            Thread.Sleep(500);
            Console.SetCursorPosition(31, 15 + lineNumber);
            DispWarehouse.TextWrite(text);
            text = "the crowd. Their eyes locking on to yours the moment you notice them.";
            lineNumber += 2;
            Thread.Sleep(500);
            Console.SetCursorPosition(31, 15 + lineNumber);
            DispWarehouse.TextWrite(text);
            text = "As they approach you see the familiar symbol of the Slayers on their armor.";
            lineNumber += 2;
            Thread.Sleep(500);
            Console.SetCursorPosition(31, 15 + lineNumber);
            DispWarehouse.TextWrite(text);
            text = "They introduce themselves as Raewen and Wollheim, two of the founding members of The Slayers.";
            lineNumber += 1;
            Thread.Sleep(500);
            Console.SetCursorPosition(31, 15 + lineNumber);
            DispWarehouse.TextWrite(text);
            text = "You show them the box in hopes that it is good enough to secure your position";
            lineNumber += 1;
            Thread.Sleep(500);
            Console.SetCursorPosition(31, 15 + lineNumber);
            DispWarehouse.TextWrite(text);
            text = "but they begin laughing.";
            lineNumber += 1;
            Thread.Sleep(500);
            Console.SetCursorPosition(31, 15 + lineNumber);
            DispWarehouse.TextWrite(text);
            text = "The tower that you had gone to had been raided by one of their members secretly the same night";
            lineNumber += 2;
            Thread.Sleep(500);
            Console.SetCursorPosition(31, 15 + lineNumber);
            DispWarehouse.TextWrite(text);
            text = "that you had first met Clifton. They claim to have told him and that he must have just forgotten.";
            lineNumber += 1;
            Thread.Sleep(500);
            Console.SetCursorPosition(31, 15 + lineNumber);
            DispWarehouse.TextWrite(text);
            text = "The creature you slayed must have just been a squatter trying to start up a new clan.";
            lineNumber += 1;
            Thread.Sleep(500);
            Console.SetCursorPosition(31, 15 + lineNumber);
            DispWarehouse.TextWrite(text);
            text = "As consolation they give you a new task to prove yourself claiming that any Slayer has to be able";
            lineNumber += 1;
            Thread.Sleep(500);
            Console.SetCursorPosition(31, 15 + lineNumber);
            DispWarehouse.TextWrite(text);
            text = "to handle a known tough enemy.";
            lineNumber += 1;
            Thread.Sleep(500);
            Console.SetCursorPosition(31, 15 + lineNumber);
            DispWarehouse.TextWrite(text);
            text = "They tell you to go to a different tower and this time retrieve a magical Orb.";
            lineNumber += 1;
            Thread.Sleep(500);
            Console.SetCursorPosition(31, 15 + lineNumber);
            DispWarehouse.TextWrite(text);
            text = "Press any key to begin your second journey...";
            lineNumber += 2;
            Thread.Sleep(500);
            Console.SetCursorPosition(31, 15 + lineNumber);
            DispWarehouse.TextWrite(text);
            Console.ReadKey(true);
            Console.Clear();

        }
        #endregion

        #region ThirdStory
        public static void ThirdStory()
        {

        }
        #endregion

        #region FourthStory
        public static void FourthStory()
        {

        }
        #endregion

    }
}
