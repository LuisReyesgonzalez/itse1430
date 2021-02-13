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
           
             

            bool done = false;
            do
            {
                char option = DisplayMainMenu();
                switch (option)
                {
                    case 'A': DepositMoney(); break;

                    case 'V':
                    WithdrawMoney();
                    break;

                    case 'Q':
                 
                    if (QuitOption()==true)
                    {
                        done= true;
                    }
                    else
                        DisplayMainMenu();
                    break;

                    default: DisplayError("Unknown Command"); break;
                };
            } while (!done);
        }

        

        static void AccountInfo ()
        {
            Console.Write("WELCOME\n");
            Console.Write("-------------------\n");
            Console.Write("Enter the name on the account: ");
             accountName = Console.ReadLine();
            Console.Write("Enter a account number (12 digits): ");
             accountNumber = ReadInt64(100000000001);
            Console.Write("Enter the starting balance: $");
             accountBalance = ReadDecimal();
        }
        static string accountName;
        static long accountNumber;
        static decimal accountBalance;
        static string priceString;
        private static char DisplayMainMenu ()
        {
            
            Console.WriteLine("What would you like to do today?");  
            Console.WriteLine("-------------");

            Console.WriteLine("A) Deposit Money");
            Console.WriteLine("B) Withdraw Money");
            Console.WriteLine("Q) uit");
            do
            {
                string input = Console.ReadLine();                         
                switch (input)
                {
                    case "A":
                    case "a": return 'A';
                    case "B":
                    case "b": return 'B';
                    case "Q":
                    case "q": return 'Q';


                    default: DisplayError("Unknown Command"); break;
                };
                DisplayError("Invalid option");
            } while (true);
        }
        private static void WithdrawMoney () 
        {
            Console.WriteLine( " Account Name: " + accountName + " Account number : "+ accountNumber + " Balance:" + accountBalance.ToString("C"));

            Console.WriteLine("Please enter the amount you will like to deposit: $ ");
             amountDeposit = ReadDecimal2();
            if (amountDeposit== 0)
            {
                return;
            }
            Console.Write("Enter an description: ");
            do
            {
                Description = Console.ReadLine();
                if (Description == "")
                    Console.WriteLine("The Description is required");
            } while (Description == "");

   


            Console.Write("Enter a Category (optional): ");
            category=Console.ReadLine();

            Console.Write("Enter the Check Number: ");
            checkNumber=ReadInt32();


            Console.Write("Enter the Date (MM/dd/YYYY): ");
            today= ReadDateTime();
            accountBalance -= amountWithdraw;
            Console.WriteLine("\n The amount being withdraw is " + amountWithdraw.ToString("C")+"\n" + "Description: " + Description +"\n" + "Category: " + category +"\n"+ "Check number: " + checkNumber+"\n");
            Console.WriteLine("Date:"+ today);
            Console.WriteLine("Updated Balance :"+ accountBalance.ToString("C"));
            Console.WriteLine("Updated Balance :"+ accountBalance.ToString("C"));

        }
        private static void DepositMoney ()
        {
            Console.WriteLine(" Account Name: " + accountName + " Account number : "+ accountNumber + " Balance:" + accountBalance.ToString("C"));
            
            Console.WriteLine("Please enter the amount you will like to deposit: ");
            amountDeposit = ReadDecimal2();
            if (amountDeposit== 0)
            { 
                    return;
            }

            Console.Write("Enter an description: ");
            do
            {
                Description = Console.ReadLine();
                if (Description == "")
                    Console.WriteLine("The Description is required");
            } while (Description == "");

            Console.Write("Enter a Category (optional): ");
            category=Console.ReadLine();
            Console.Write("Enter the Check Number (optional) : ");
            checkNumber=ReadInt32();

            Console.Write("Enter the Date (MM/dd/YYYY): ");
            today = ReadDateTime();
            accountBalance += amountDeposit;
            Console.WriteLine("\n The amount being deposited is " + amountDeposit.ToString("C")+"\n" + "Description: " + Description +"\n" + "Category: " + category +"\n"+ "Check number: " + checkNumber+"\n") ;
            Console.WriteLine("Date:"+ today);
            Console.WriteLine("Updated Balance :"+ accountBalance.ToString("C"));
        }
       static decimal amountWithdraw;
        static decimal amountDeposit;
        static string Description ="";
       static string category;
       static int checkNumber;
       static DateTime today; 


        private static bool QuitOption ()
        {
            Console.WriteLine(" Account Name: " + accountName + " Account number : "+ accountNumber + " Balance:" + accountBalance.ToString("C"));
            Console.WriteLine($"Do you want to Exit?\n Please enter Y or N ");
            do
            {
                string option = Console.ReadLine();
                if (String.Compare(option, "Y", true) == 0)
                    return true;
                else if (String.Compare(option, "N", true) == 0)
                    return false;

                DisplayError("Unknown Command");
            } while (true);
        
        }
        static long ReadInt64 ()
        {
            return ReadInt64(Int64.MinValue);
        }
        static int ReadInt32 () 
        {
            do
            {
                string input = Console.ReadLine();
                { //must be greater than 0
                    if (Int32.TryParse(input, out int result))
                    {
                        if (result>0)

                            return result;
                    } else
                        DisplayError("Value must be numeric");
                }
                    

            } while (true);
          }
        static DateTime ReadDateTime ()
        {
            do
            {
                string input = Console.ReadLine();
                {
                    if (DateTime.TryParse(input, out var value))
                        return value; 
                    else
                        DisplayError("Value must be numeric");
                }


            } while (true);
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
                    {
                       // decimal price = convertToDecimal;
                        //string priceString = price.ToString("C");
                        return convertToDecimal;
                    } else
                        DisplayError("Balance must be greater than 0.");
                } else

                    DisplayError("Value must be numeric");
                } while (true);
            

        }
        static decimal ReadDecimal2 ()
        {
            bool notZero = true;
            do
            {
                string input = Console.ReadLine();
                // var  convertToDecimal = Decimal.Parse(input);

                if (Decimal.TryParse(input, out decimal convertToDecimal))
                {

                    if (convertToDecimal > 0)
                    {
                        // decimal price = convertToDecimal;
                        //string priceString = price.ToString("C");
                        return convertToDecimal;
                    }
                    else
                    {
                        notZero = false;
                        
                        return 0;
                    }
                       
                } else

                    DisplayError("Value must be numeric");
                return 0;
            } while (notZero);


        }

        private static void DisplayError ( string message )
        {
            Console.WriteLine(message);
        }
    }
}


      
