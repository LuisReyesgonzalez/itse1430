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
                    case 'D':
                    character = null;
                    break;
                    case 'V':
                    break;

                    case 'Q':
                    done =true;
                    break;
                    default: DisplayError("Unknown Command"); break;
                };
            } while (!done);
        }

        /// <summary> Display the menu</summary>
        private static char DisplayMainMenu ()
        {
            Console.WriteLine("Welcome!");
            Console.WriteLine("-------------");
            Console.WriteLine("A) Add character");
            Console.WriteLine("V) View a character");
            Console.WriteLine("E) Edit a character");
            Console.WriteLine("D) Delete character");
            Console.WriteLine("Q) uit");
            do
            {
                string input = Console.ReadLine();
                switch (input)
                {
                    case "A":
                    case "a": AddCharacter(); return 'A';
                    case "D":
                    case "d": return 'D';
                    case "E":
                    case "e": DisplayEditMenu(); return 'E';
                    case "Q":
                    case "q": return 'Q';
                    case "V":
                    case "v": ViewCharacter(); return 'V';
                    default: DisplayError("Unknown Command"); break;
                };
                DisplayError("Invalid option");
            } while (true);
        }
        static Character character;
        static void AddCharacter ()
        {
            character=new Character();
            do
            {

                Console.Write("Enter Character Name: ");
                character.Name = Console.ReadLine();

            } while (!character.Validate(out var error));

            Console.Write("Choose your profession: ");
            character.profession=professionOption();

            Console.Write("Choose your race: ");
            character.race=raceOption();

            Console.Write("--------Attributes-------- ");
            Console.WriteLine("");
            Console.WriteLine("Please enter any number from 1-100 for each Attribute");
            Console.Write("Strength: ");
            character.Strength=ReadInt32();

            Console.Write("Intelligence: ");
            character.Intelligence=ReadInt32();

            Console.Write("Agility: ");
            character.Agility=ReadInt32();

            Console.Write("Constitution: ");
            character.Constitution=ReadInt32();

            Console.Write("Charisma:");
            character.Charisma=ReadInt32();

            Console.Write("Enter an optional Biography: ");
            character.Biography = Console.ReadLine();

        }
        /// <summary>Character info displayed </summary>
        static void ViewCharacter ()
        {
            if (character==null)
            {
                Console.WriteLine("A Character has not been created. Please create a Character. ");
                DisplayMainMenu();

            }
            Console.WriteLine("-------Character 1--------");
            Console.WriteLine("Name: "+character.Name);
            Console.WriteLine("Profession: "+character.profession);
            Console.WriteLine("Race: "+character.race);
            Console.WriteLine("Strength: "+character.Strength);
            Console.WriteLine("Intelligence: "+character.Intelligence);
            Console.WriteLine("Agility: "+character.Agility);
            Console.WriteLine("Constitution: "+ character.Constitution);
            Console.WriteLine("Charisma: "+character.Charisma);
            Console.WriteLine("Biography: "+character.Biography);
            Console.WriteLine();

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
                    case 'P': return "Priest";
                    case 'R': return "Rogue";
                    case 'W': return "Wizard";
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
                    case 'E': return "Elf";
                    case 'G': return "Gnome ";
                    case 'T': return "Half Elf";
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



        /// <summary> Display the character profession menu</summary>
        private static void DisplayEditMenu ()
        {

            Console.WriteLine("What would you like to edit");
            Console.WriteLine("-------------");
            Console.WriteLine("A) Name ");
            Console.WriteLine("B) Profession");
            Console.WriteLine("C) Race");
            Console.WriteLine("--------Attributes-------- ");
            Console.WriteLine("D) Strength");
            Console.WriteLine("E) Intelligence ");
            Console.WriteLine("F) Agility ");
            Console.WriteLine("G) Constitution ");
            Console.WriteLine("H) Charisma ");
            Console.WriteLine("J) Biography");
            Console.WriteLine("Q) Quit");
            string option = Console.ReadLine();
            do
            {
                switch (option)
                {
                    case "A":
                    case "a":
                    do
                    {

                        Console.Write("Enter Character Name: ");
                        character.Name = Console.ReadLine();

                    } while (!character.Validate(out var error));
                    break;

                    case "B":
                    case "b":
                    Console.Write("Choose your profession: ");
                    character.profession=professionOption();


                    break;
                    case "C":
                    case "c":
                    Console.Write("Choose your race: ");
                    character.race=raceOption();


                    break;
                    case "D":
                    case "d":
                    Console.Write("Strength: ");
                    character.Strength=ReadInt32();
                    
                    break;

                    case "E":
                    case "e":
                    Console.Write("Intelligence: ");
                    character.Intelligence=ReadInt32();
                    

                    break;

                    case "F":
                    case "f":
                    Console.Write("Agility: ");
                    character.Agility=ReadInt32();

                    break;
                    case "G":
                    case "g":
                    Console.Write("Constitution: ");
                    character.Constitution=ReadInt32();

                    break;
                    case "H":
                    case "h":
                    Console.Write("Charisma:");
                    character.Charisma=ReadInt32();

                   break;

                    case "J":
                    case "j":
                    Console.Write("Enter an optional Biography: ");
                    character.Biography = Console.ReadLine();

                    break;

                    case "Q":
                    case "q":
                    DisplayMainMenu();
                    break;
                    default: DisplayError("Unknown Command"); break;
                };
                ViewCharacter();
                DisplayEditMenu();
            } while (option != "A" && option != "a" && option != "B" && option != "b" && option != "C"  && option != "c" 
            && option!="D"  && option != "d" && option!="E" && option != "e"&& option!="F" && option != "f"&& option!="G"  && option != "g"&& option!="H" && option != "h"&& option!="I" && option != "i");
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
                        DisplayError("Value must be between " + minimumValue + " & "+ maxmumValue);
                  
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

