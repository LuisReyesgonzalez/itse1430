/*
 * ITSE 1430
 * Spring 2021
 * Sample Implementation
 */
using System;

namespace MovieLibrary
{
    class Program
    {
        static void Main()//(string[] args)
        {
            AddMovie();
            DisplayMainMenu();
        }

        //[modifiers* T identfier([parameters]) {S*}
        //function declaration -  functions signature that tells the compiler a function exists 
        //function signature- T identifier (parameters)
        //function definition- function eclaration + implementation
        private static void DisplayMainMenu ()
        {
            Console.WriteLine("Movie Library");
            Console.WriteLine("-------------");

            Console.WriteLine("A)dd Movie");
            Console.WriteLine("Q)uit");

            ///Console input 
            string input = console.ReadLine(); // string ReadLine()
                                               //TODO:Validate Input
                                               //TODO: REtun selected option
        }
            //Get movie from user
            static void AddMovie()
            {
                Console.WriteLine("Enter a title: ");
                string description = Console.ReadLine();

                Console.WriteLine("Enter an optional description: ");
                string description = Console.ReadLine();

                Console.WriteLine("Enter a release year: ");
                string description = Console.ReadLine();

            Console.WriteLine("Enter the run length in minutes: ");
            int runLength = ReadInt32();

            Console.WriteLine("Enter a rating ");
                string description = Console.ReadLine();

                Console.WriteLine("Is a Classsic (Y/N)? ");
            Boolean isClassic = ReadBoolean();
            

            }

            static bool ReadBoolean ()
        {
            ConsoleKeyInfo key = Console.ReadKey();
            //TODO: Handle min value
            return true;

        }

            static int ReadInt32()
            {

                string input = Console.ReadLine();

                //Convert string to int
                int value = Int32.Parse(input);

                return value;
            }
            //varaible declaration ::=T id;
           //string input;       //Variable Declaration, local scope
            
            
           //input= Console.ReadLine(); 




        void DemoTypes ()
        {
            //Primitive type- types known by the complier
            //intgrals- signed
            //sbyte ||  -128 to 127
            //short |2 bytes| +-32k 
            //int|4 bytes| 2 billion| default
            //long|8 bytes||only for for really large values
            
            sbyte sbyteValue = 10;
            short shortValue=10'
            int hours = 20;
            long starInGalaxy = 1_000_000_000;
            long anotherLong = 10L; //Long literal
            //intgrals- unsigned
            //byte ||  0 to 255
            //uhort |2 bytes| 0 to +64k 
            //uint|4 bytes| 0 to 4 billion| default
            //ulong|8 bytes||only for for really large value
            byte byteCode = 0xAF;
            ushort shortCode = 0x145678;
            ulong = 0b0010_1010_1111;

            //float point IEEE
            //decimal |80 bytes|currency
            float delta = 4.5F;
            double taxRate=8.75
            decimal payRate = 12.50M;

            //Textual 
            //char
            //string
            char letter = 'A';
            string className = "ITSE 1430";

            //miscellaneous
            //bool|1 bit| true or false
            bool isPassing = true;//false

            //other(not primitive types)
            //DateTime |Date=time value
            //TimeSpan| Time of dat or duration
            //Guid|Unique value
            DateTime today;
            TimeSpan duration;

        }

        void DemoVariables () 
        {
            string textInput = "";
            //textInput=""; other code
            //assignment statement  ::= id = E;
            //id- must be left value
            //E- any right value

            // textInput= "Hello";
            //All reads of variables must be definitely assigned
            //Compiler must be able to verify that
            string textInput2 = textInput;
            int x = 10, y = 12;
        
        
        }
        
        //Data to collect- title, genre,release year, actors,runtime,director ,rating
        //title,release year, run length (min),dewscription,rating

   }
}
