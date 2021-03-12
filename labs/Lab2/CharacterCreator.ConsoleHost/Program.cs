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
            Console.WriteLine("A)");
            Console.WriteLine("V)");
            Console.WriteLine("Q) uit");
            //Console input
            do
            {
                string input = Console.ReadLine();
                switch (input)
                {
                    case "A":
                    case "a": return 'A';
                    case "Q":
                    case "q": return 'Q';
                    case "V":
                    case "v": return 'V';
                    default: DisplayError("Unknown Command"); break;
                };
                DisplayError("Invalid option");
            } while (true);
        }
        static void DisplayError ( string message )
        {
            Console.WriteLine(message);
        }

    }//end of program
   }

