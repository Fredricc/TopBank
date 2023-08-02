using System;

namespace TopBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //display title
            Console.WriteLine("***************TopBank Bank******************");
            Console.WriteLine("::Login Page::");

            //Declare to store username and password;
            string? userName = null, password = null;

            //read userName from Keyboard;
            Console.WriteLine("Username");
            userName = Console.ReadLine();

            if (userName != "")
            {
                //read password from Keyboard;
                Console.WriteLine("Password");
                password = Console.ReadLine();
            }
            else
            {
                //read userName from Keyboard;
                Console.WriteLine("Please enter Username first...");
                Console.WriteLine("Username");
                userName = Console.ReadLine();

                if (userName != "")
                {
                    //read password from Keyboard;
                    Console.WriteLine("Password");
                    password = Console.ReadLine();
                }
            }

            //Check username and password
            if( userName == "system" && password == "Freddy")
            {
                    //declare variable to store menu choice
                    int mainMenuChoice = -1;
                do
                {

                    Console.WriteLine("\n::: Main Menu here:::");
                    Console.WriteLine("1.Customers");
                    Console.WriteLine("2.Accounts");
                    Console.WriteLine("3.Funds Transfer");
                    Console.WriteLine("4.Funds Transfer Statement");
                    Console.WriteLine("5.Account Statement");
                    Console.WriteLine("0.Exit");

                    Console.WriteLine("Enter Choice:");
                    mainMenuChoice = int.Parse(Console.ReadLine());

                    //switch-case to check menu choice
                    switch (mainMenuChoice)
                    {
                        case 1: CustomersMenu(); break;
                        case 2: break; //TO DO:Display accounts menu
                        case 3: break; //TO DO:Display funds transfer menu
                        case 4: break; //TO DO:Display funds transfer statement menu
                        case 5: break; //TO DO:Display account menu
                    }
                }while (mainMenuChoice != 0);

            }
            else
            {
                System.Console.WriteLine("Invalid username or password");
            }

            //about to exit
            Console.WriteLine("Thank you! Visit again.");
            Console.ReadKey();
        }
    }
    static void CustomersMenu()
    {
        //variable to store customers menu choice
        int customerMenuChoice = -1;

        //do-while loop starts
        do
        {
            //print customers menu
            Console.WriteLine("\n:::Customers menu:::");
            Console.WriteLine("1. Add Customer");
            Console.WriteLine("2. Delete Customer");
            Console.WriteLine("3. Update Customer");
            Console.WriteLine("4. View Customers");
            Console.WriteLine("00. Back to Main Menu");

            //accept customers choice

        } while (customerMenuChoice != 0);
    }
}