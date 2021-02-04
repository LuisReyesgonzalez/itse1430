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
        static void Main ()  //(string[] args)
        {
            bool done = false;
            do
            {
                char option = DisplayMainMenu();
                //switch statement is equivalent to a series pf if-else-if with equlity checks
                // switch-statement :: =switch(E){case statement*[default]};
                //case statement ::=case E : S ;
                //default-statement ::= default :S;
                //if (option == 'A')
                //  AddMovie();
                // else if (option == 'V')
                //   ViewMovie();
                //else if (option == 'Q')
                //  done = true;
                // else
                //   DisplayError("Unknown command");
                switch (option)
                {
                    case 'A':AddMovie(); break;

                    case 'V': ViewMovie();
                    break;

                    case 'Q': done =true;
                    break;

                    default: DisplayError("Unknown Command"); break;
                };
            } while (!done);
        }

        // modifiers* T identifier ( [parameters] ) { S* }
        // function declaration - function signature that tells the compiler a function exists
        // function signature - T identifier ( parameters )
        // function definition - function declaration + implementation
        private static char DisplayMainMenu ()
        {
            //Display output - equivalent to printf, cout
            //Console.Write();
            Console.WriteLine("Movie Library");  //String literals are enclosed in double quotes
            Console.WriteLine("-------------");

            Console.WriteLine("A) dd Movie");
            Console.WriteLine("V) iew Movie");
            Console.WriteLine("Q) uit");

            //Console input
            do
            {
                string input = Console.ReadLine();  // string ReadLine ()                        

                //TODO: Validate input
                //if (input == "A" || input == "a")
                //   return 'A';
                //else if (input == "Q" || input == "q")
                //    return 'Q';
                // else if (input == "V" || input == "v")
                //    return 'V';
                switch (option)
                {
                    case "A":
                    case "a": return "A"; 
                    case "Q": 
                    case "q": return "Q";
                    case "V":
                    case "v": return "V";
                    

                    default: DisplayError("Unknown Command"); break;
                };
                DisplayError("Invalid option");
            } while (true);
        }

        // Get movie from user
        static void AddMovie ()
        {
            // title, release year, run length (min), description, rating
            Console.Write("Enter a title: ");
            title = Console.ReadLine();

            Console.Write("Enter an optional description: ");
            description = Console.ReadLine();

            Console.Write("Enter a release year: ");
            releaseYear = ReadInt32(1900);

            Console.Write("Enter the run length in minutes: ");
            runLength = ReadInt32(0);

            Console.Write("Enter the rating: ");
            rating = Console.ReadLine();

            Console.Write("Is a Classic (Y/N)? ");
            isClassic = ReadBoolean();

            ViewMovie();
        }

        static string title;
        static string description;
        static int releaseYear;
        static int runLength;
        static string rating;
        static bool isClassic;

        static void ViewMovie ()
        {
            //TODO: Format
            Console.WriteLine($"{title} ({releaseYear} minutes");
            if (runLength >0)
                Console.WriteLine($"Running Time:{runLength} mintutes");
            if (!String.IsNullOrEmpty(rating))
                Console.WriteLine($"MPAA Rating: {rating}");
            Console.WriteLine($"Classic?")

            Console.WriteLine(description);
           
           
            Console.WriteLine(isClassic);
        }

        // Reads a boolean value from the console.
        static bool ReadBoolean ()
        {
            do
            {
                //ConsoleKeyInfo key = Console.ReadKey();
                string input = Console.ReadLine();

                //TODO: Case does not matter
                // input == "Y" || "y" -: Not correct
                if (input == "Y" || input == "y")
                    return true;
                else if (input == "N" || input == "n")
                    return false;

                DisplayError("Please enter either Y or N");
            } while (true);
        }

        // Reads an integer value from the console.
        static int ReadInt32 ()
        {
            return ReadInt32(Int32.MinValue);
        }

        static int ReadInt32 ( int minimumValue )
        {
            // WHILE statement
            //  while (Eb) S;   
            //    S executes 0 or more times (pretest)
            // DO WHILE statement
            //  do S while (Eb) ;
            //    S executes at least once (posttest)
            // break statement
            //    only valid in loop constructs
            //    immediately exits the current loop
            // continue statement
            //    only valid in loop constructs
            //    immediately exits the current iteration and checks the loop again

            do
            {
                //type inferencing- complier infers type based upo the assignment
                //Keep prompting until valid value
                //string input = Console.ReadLine();
                var input = Console.ReadLine();

                //Fix so it doesn't crash if not integer, use TryParse instead
                //Convert string to int
                //int value = Int32.Parse(input);  //atoi - prefer TryParse

                // IF statement
                // if (Eb) S;
                // if (Eb) 
                //    St 
                // else 
                //    Sf;
                // if (Eb) 
                //    St 
                // else if (Eb)
                //    Stt;
                // else 
                //    Sf;
                //int result;
                //if (Int32.TryParse(input, out result))                
                if (Int32.TryParse(input, out var result))  //Inline variable declaration
                {
                    //Make sure it is at least minValue
                    if (result >= minimumValue)
                        return result;
                    else
                        DisplayError("Value must be at least " + minimumValue);
                } else
                    DisplayError("Value must be numeric");
            } while (true);
        }

        private static void DisplayError ( string message )
        {
            Console.WriteLine(message);
        }

        #region Demo Code
        void DemoString()
        {
            //conversion to string E.ToString
            //Comsole.WriteLine(10); => Console.WriteLine(10.ToString());
            int hours = 10;
            string hourString = hours.ToString();
            hourString= 10.ToString();
            //String Literals ""
            //escape sequence -/? inside a string literal, have special meaning to the compiler,generally produce a single character
            // \n-newline
            // \t-horizontal tab
            // \\-slash 
            // \" -double qute
            // \' single in character
            // \x## - hex code equivalent
            string stringLiteral = "Hello" + "World";
            stringLiteral ="hello\nWorld";

            //  Verbatim syntax - escape sequence ignored 
            string filePath = "C:\\Temp\\test.txt";
            string filePath2 = @"C:\Temp\test.txt";

            //empty string 
            //null and empty string are not the same
            string emptyString = "";
            string defaultString; //false
            //checking for empty
            bool isEmpty = emptyString =="";
            bool isEmpy2 = emptyString == ""||emptyString==null; ;// If empty or null
            bool isEmptyPreferred = String.IsNullOrEmpty(emptyString);//handles both
           
            //String concatenation
            string first = "Hello", second = "World";

            //start with 3 strings
            string concatOP=first +" "+ second;
            string concatfunction = String.Concat(first, " ", second);
            string joinfunction = String.Join(' ', first, second);
            
            //strings are immutable!!!!
            //10 +2 =12
            string imutableString = "Hello";
            imutableString += " "; //two strings: "Hello" , "Hello"
            imutableString += "World"; //three strings "Hello" , "Hello" , "Hello WOrld"

            //string formatting
            // The result of 4 + 5 = 9
            int x = 4, y = 5;
            int result = x+y;
            
            //1)
            string format1 = "The result of " + x + " + "  + y + " = " + (x+y);

            //2)
            string format2 = String.Format("The of {0} + {1} = {2}", x, y, (x+y));
            //Many message-like function have overloads that have a string and arguments and call string.Format automatically
            Console.WriteLine(format2);
            Console.WriteLine("The of {0} + {1} = {2}", x, y, (x+y));

            //3)String interpolation - let the compiler do it 
            //only works with string literals
            string format3 = $"The result of {x} + {y} = {x+y}";

            string formattedValue = x.ToString("00");
            decimal price = 8500;
            string priceString = price.ToString("C"); //$8,500.00

        }
        void DemoExpressions ()
        {
            //Arithmetic (op1 op op2)
            // op1 and op2 must be exact same type
            // If they are not then type coercion (compiler type casting - always safe)
            //     double + int = double + double = double
            int result = 4 + 5;
            result = 5 - 45;
            result = 8 * 5;
            result = 8 / 5;  // Int division: 1
            result = 8 % 5;  // result: 3  isEven ::= number % 2 == 0

            result = 4 + 6 * 5;  //4 + (6 * 5) = 34

            //Logical (bool op bool => bool)
            //   Not same = x && Y || z  (x && Y) || z not X && (Y || Z)
            bool logicalResult = true && true;  //Logical AND  
            logicalResult = true || true;       //Logical OR
            logicalResult = !true;              //Logical !

            // Relational (op1 rop op2 => bool)
            bool relationalResult = 10 > 20;
            relationalResult = 10 < 20;
            relationalResult = 10 >= 20;
            relationalResult = 10 <= 20;
            relationalResult = 10 != 20;   //Not equal
            relationalResult = 10 == 20;   //Equality

            // Conditional
            //    E ? Et : Ef
            //  if (E)
            //     Et
            //  else
            //     Ef
            //  Et and Ef must be the exact same type


            // Misc
            // assignment  lvalue = E
            //   right associative : evals the right side first and then the left
            logicalResult = relationalResult = false;

            // Prefix and postfix increment and decrements
            result = 5;
            int postfixinc = result++; // result += 1; original value of result
            int prefixinc = ++result;  // result += 1; result
            int postfixdec = result--;
            int prefixdec = --result;

            //Function calls
            //  Parameter ::= variable inside function definition used to store temporary value
            //  Argument ::= expression used to assign a value to a parameter 
            //  Kinds of parameters ::= Foo(x)  
            //    Input (pass by value) - copies the argument value into the parameter's memory location, two separate copies
            //         Foo(12);
            //    Input/Output (pass by reference) - temporarily share the same memory location for two different variables
            //         Foo(ref arg);
            //    Output - Function caller provides space but the function provides the value
            //         Foo(out arg);
            result = ReadInt32();
            result = Int32.Parse("123");
        }

        // Input parameter - T name
        // Input/Output parameter - ref T name
        // Output parameter - out T name
        void Foo ( int inputParameter, ref double ioParameter, out bool result )
        {
            result = false;
        }

        void DemoTypes ()
        {
            //Primitive types - types known by the compiler

            //integrals - signed
            // sbyte | 1 byte | -128 to 127             (SByte.TryParse/Parse)
            // short | 2 bytes | +-32K                  (Int16.TryParse/Parse)
            // int   | 4 bytes | +-2 billion | default  (Int32.TryParse/Parse)
            // long  | 8 bytes | really large | only for really large values (Int64.TryParse/Parse)
            sbyte sbyteValue = 10;  //int literal
            short shortValue = 10;  //int literal
            int hours = 20;
            long starsInGalaxy = 1_000_000_000;
            long anotherLong = 10L;  //Long literal

            //integrals - unsigned
            // byte   | 1 byte | 0 to 255               (Byte.TryParse/Parse)
            // ushort | 2 bytes | 0 to 64K              (UInt16.TryParse/Parse)
            // uint   | 4 bytes | 0 to 4 billion        (UInt32.TryParse/Parse)
            // ulong  | 8 bytes | really large          (UInt64.TryParse/Parse)
            byte byteCode = 0xAF;
            ushort shortCode = 0x1045;
            uint hourCode = 0x145678;
            ulong longCode = 0b0010_1010_1111;
            ulong ulongCode = 10UL; //ulong literal

            //floating point IEEE
            // float | 4 bytes | +-E38 | 7-9 precision  123.456789
            // double | 8 bytes | +-E308 | 15-17 precision | default
            // decimal | 80 bytes | currency (money) 
            float delta = 4.5F;     //Float literal         (Single.TryParse/Parse)
            double taxRate = 8.75;   //8E-10                (Double.TryParse/Parse)
            decimal payRate = 12.50M;   //Decimal literal   (Decimal.TryParse/Parse)

            //Textual
            // char | 2 bytes | Single character
            // string | * | Text
            char letter = 'A';                  //Char literals are single quoted
            string className = "ITSE 1430";     //String literals are double quoted

            //Miscellaneous
            // bool | 1 bit | true or false
            bool isPassing = true; //false                  (Boolean.TryParse/Parse)
            //int isOK = 1; //Wrong

            //Other (not primitive types)
            // DateTime | Date-time value
            // TimeSpan | Time of day or duration
            // Guid | Unique value
            DateTime today;
            TimeSpan duration;
            Guid uniqueId;
        }

        void DemoVariables ()
        {
            // variable-declaration ::= T id [ = E ] ;
            //   block-style declarations -> put all declarations at top of function, grouped together
            //   inline-style declaration -> declare variables as needed
            string textInput = "";
            //other code...
            //textInput = ""; //should always initialize variables as part of declaration

            // assignment-statement ::= id =  E ;
            //   id - must be an lvalue (left value)
            //   E - any rvalue (right value) provided it is type compatible
            //   operator precedence - order in which operators are evaluated 4 + 5 * 10 = 54
            //   operator associativity - which operand evaluates first (left, right) - right
            //textInput = "Hello";

            //All reads of variables must be definitely assigned
            //  Compiler must be able to verify that all possible code paths to the read ensure that
            //    variable is first written to
            string textInput2 = textInput;

            //MUltiple declarations
            //  variable-declaration ::= T id [ = E ] { , id [ = E ]}* ;
            int x = 10, y = 12;

            //Identifier rules
            // 1. Must start with letter or underscore 
            // 2. Consist of letters or digits or underscores
            // 3. Must be unique in scope
            // 4. Cannot be a keyword 

            //Variable name guidelines
            // nouns, descriptive (e.g. firstName, payRate, hours)
            // generally less than 15 characters long
            // are not single letters (e.g. x, y)
            // no abbreviations or acronyms unless they are well known (good: ok, bad: nbr, num)
            // USE camel casing (capitalize on word boundaries, lowercase first word - e.g. firstName, payRate, hours)

            //Function name guidelines
            // descriptive verbs (e.g. Get..., Display..., Calculate...)
            // Use Pascal casing
            // no abbreviations or acronyms unless they are well known (good: ok, bad: nbr, num)
        }

        //Data to collect - title, genre, release year, actors, runtime, director, rating
        // title, release year, run length (min), description, rating
        #endregion
    }
}