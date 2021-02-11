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
            accountInfo();
          
        }
        static void accountInfo ()
        {

            // title, release year, run length (min), description, rating
            Console.Write("Enter the name on the account: ");
            accountName = Console.ReadLine();
            Console.Write("Enter a account number (12 digits): ");

        }
        static string accountName;
        static string accountNumber;
        //TO DO:
        //convert int to string // hint Try.parse Read.Int32
    }
}
