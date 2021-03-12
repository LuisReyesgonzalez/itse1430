/*
 * Character Creator
 * ITSE 1430
 * Spring 2021
 * Luis Reyes
 */
using System;

namespace CharacterCreator.ConsoleHost
{
    class Program
    {
        static void Main ()
        {
            bool done = false;
            do
            {
                char option = DisplayMainMenu();
                switch (option)
                {
                    case 'A': 
                    break;
                    case 'V':
                    break;
                    case 'Q':
                    done =true;
                    break;
                    default: DisplayError("Unknown Command"); break;
                };
            } while (!done);
        }//end of main

        /// <summary> Display the menu</summary>
        private static char DisplayMainMenu ()
        {
            Console.WriteLine();
            Console.WriteLine("-------------");
            Console.WriteLine("A)dd a character");
            Console.WriteLine("V)iew a character");
            Console.WriteLine("Q) uit");
            //Console input
            do
            {
                string input = Console.ReadLine();
                switch (input)
                {
                    case "A":
                    case "a": AddCharacter(); return 'A';
                    case "Q":
                    case "q": return 'Q';
                    case "V":
                    case "v": return 'V';
                    default: DisplayError("Unknown Command"); break;
                };
                DisplayError("Invalid option");
            } while (true);
        }
     
       static void AddCharacter ()
        {
            Character character = new Character();
            Console.Write("Enter Character Name: ");
            character.Name = Console.ReadLine();


            Console.Write("Enter an optional description: ");
            character.Description = Console.ReadLine();

            if (!character.Validate(out var message))
            {
                DisplayError("Character is not valid");
                return;
            };

        }
        /// <summary> Profession options for the user</summary>
        static void professionOption ()
        {
            bool done = false;
            do
            {
                char option = DisplayProfessionMenu();
                switch (option)
                {
                    case 'F':
                    break;
                    case 'H':
                    break;
                    case 'P':
                    break;
                    case 'R':
                    break;
                    case 'W':
                    break;
                    case 'Q':
                    done =true;
                    break;
                    default: DisplayError("Unknown Command"); break;
                };
            } while (!done);
        }

        /// <summary> Display the character profession menu</summary>
        private static char DisplayProfessionMenu ()
        {
            Console.WriteLine("Choose your character's profession");
            Console.WriteLine("-------------");
            Console.WriteLine("F) Fighter");
            Console.WriteLine("H) Hunter");
            Console.WriteLine("P) Priest");
            Console.WriteLine("R) Rogue");
            Console.WriteLine("W) Wizard");
            Console.WriteLine("Q) uit");
            //Console input
            do
            {
                string input = Console.ReadLine();
                switch (input)
                {
                    case "F":
                    case "f": ; return 'F';
                    case "H":
                    case "h": return 'H';
                    case "P":
                    case "p": return 'P';
                    case "R":
                    case "r": return 'R';
                    case "W":
                    case "w": return 'W';
                    case "Q":
                    case "q": return 'Q';
                    default: DisplayError("Unknown Command"); break;
                };
                DisplayError("Invalid option");
            } while (true);
        }

        /// <summary> Race options for the user</summary>
        static void raceOption ()
        {
            bool done = false;
            do
            {
                char option = DisplayRaceMenu();
                switch (option)
                {
                    case 'F':
                    break;
                    case 'H':
                    break;
                    case 'P':
                    break;
                    case 'R':
                    break;
                    case 'W':
                    break;
                    case 'Q':
                    done =true;
                    break;
                    default: DisplayError("Unknown Command"); break;
                };
            } while (!done);
        }

        /// <summary> Display the character race menu</summary>
        private static char DisplayRaceMenu ()
        {
            Console.WriteLine("Choose your character's race");
            Console.WriteLine("-------------");
            Console.WriteLine("D) Dwarf");
            Console.WriteLine("E) Elf");
            Console.WriteLine("G) Gnome");
            Console.WriteLine("T) Half Elf");
            Console.WriteLine("H) Human");
            Console.WriteLine("Q) uit");
            //Console input
            do
            {
                string input = Console.ReadLine();
                switch (input)
                {
                    case "D":
                    case "d":; return 'D';
                    case "E":
                    case "e": return 'E';
                    case "G":
                    case "g": return 'G';
                    case "T":
                    case "t": return 'T';
                    case "H":
                    case "h": return 'h';
                    case "Q":
                    case "q": return 'Q';
                    default: DisplayError("Unknown Command"); break;
                };
                DisplayError("Invalid option");
            } while (true);
        }


        static void DisplayError ( string message )
        {
            Console.WriteLine(message);
        }

    }
   }

