/*
 * Budget
 * ITSE 1430
 * Spring 2021
 * Luis Reyes
 */
using System;

namespace Budget
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Budget\nITSE 1430\nSpring 2021\nLuis Reyes\n");
            AccountInfo();
          
        }
        static void AccountInfo ()
        {
            Console.Write("WELCOME\n");
            Console.Write("-------------------\n");
            Console.Write("Enter the name on the account: ");
            string accountName = Console.ReadLine();
            Console.Write("Enter a account number (12 digits): ");
            long accountNumber = ReadInt64(100000000001);
            Console.Write("Enter the starting balance: $");
            decimal accountBalance = ReadDecimal();
        }

        static long ReadInt64 ()
        {
            return ReadInt64(Int64.MinValue);
        }
        static long ReadInt64 ( long minimumValue )
        {
            do
            {

                string input = Console.ReadLine();


                {

               
                    if (Int64.TryParse(input, out long result))
                    {
                        if (result >= minimumValue)
                            if (input.EndsWith( "0"))
                            {
                                DisplayError("Account number cannot end with 0.");
                            }
                           else
                                return result;
                        
                        else
                            DisplayError("Value must be at least 12 didgits and can not start with 0."  );
                      
                           
                    } else
                        DisplayError("Value must be numeric");
                } 
            } while (true);
         }
        static decimal ReadDecimal ()
            {
                do { 
                string input = Console.ReadLine();
                // var  convertToDecimal = Decimal.Parse(input);

                if (Decimal.TryParse(input, out decimal convertToDecimal))
                {
                    if (convertToDecimal>0)
                        return convertToDecimal;
                    else
                        DisplayError("Balance must be greater than 0.");
                } else

                    DisplayError("Value must be numeric");
                } while (true);


            }

        //Recording 4 
        //TO DO:
        //convert int to string // hint Try.parse Read.Int32

        private static void DisplayError ( string message )
        {
            Console.WriteLine(message);
        }
    }
}

      
