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
            do
            {

                Console.Write("Enter Character Name: ");
                character.Name = Console.ReadLine();

            } while (!character.Validate(out var error));

            Console.Write("Choose your profession: ");
            character.profession=professionOption();

            Console.Write("Choose your race: ");
            character.race=raceOption();

            // Console.Write(character.profession);
            // Console.Write("Enter an optional description: ");
            // character.Description = Console.ReadLine();



        }
        /// <summary> Profession options for the user</summary>
        static string professionOption ()
        {
            char option = DisplayProfessionMenu();

            do
            {

                switch (option)
                {
                    case 'F': return "Fighter";
                    case 'H': return "Hunter";
                    case 'P':
                    return "Priest";

                    case 'R':
                    return "Rogue";

                    case 'W':
                    return "Wizard";
                    default: DisplayError("Unknown Command"); break;
                };
            } while (option != 'F'&& option != 'H' && option != 'P'&& option != 'R' && option!='W');
            return "";
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

            //Console input
            do
            {
                string input = Console.ReadLine();
                switch (input)
                {
                    case "F":
                    case "f": return 'F';
                    case "H":
                    case "h": return 'H';
                    case "P":
                    case "p": return 'P';
                    case "R":
                    case "r": return 'R';
                    case "W":
                    case "w": return 'W';
                    default: DisplayError("Unknown Command"); break;
                };
                DisplayError("Invalid option");
            } while (true);
        }

        /// <summary> Race options for the user</summary>
        static string raceOption ()
        {
            char option = DisplayRaceMenu();
            do
            {
                switch (option)
                {
                    case 'D': return "Dwarf ";
                    case 'E':return "Elf";
                    case 'G':return "Gnome ";
                    case 'T':return "Half Elf";
                    case 'H': return "Human ";
                    default: DisplayError("Unknown Command"); break;
                };
            } while (option != 'D'&& option != 'E' && option != 'G'&& option != 'T' && option!='H');
            return "";
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

            //Console input
            do
            {
                string input = Console.ReadLine();
                switch (input)
                {
                    case "D":
                    case "d": return 'D';
                    case "E":
                    case "e": return 'E';
                    case "G":
                    case "g": return 'G';
                    case "T":
                    case "t": return 'T';
                    case "H":
                    case "h": return 'H';
                    default: DisplayError("Unknown Command"); break;
                };
                DisplayError("Invalid option");
            } while (true);
        }

        static int ReadInt32 ( )
        {
            int minimumValue = 1;
            int maxmumValue = 100;
            do
            {
             
                var input = Console.ReadLine();

                             
                if (Int32.TryParse(input, out var result))  //Inline variable declaration
                {
                    //Make sure it is at least minValue
                    if (result >= minimumValue && result <= maxmumValue)
                        return result;
                    else
                        DisplayError("Value must be between" + minimumValue + " & "+ maxmumValue);
                  
                } else
                    DisplayError("Value must be numeric");
            } while (true);
        }


        static void DisplayError ( string message )
        {
            Console.WriteLine(message);
        }

    }
}

