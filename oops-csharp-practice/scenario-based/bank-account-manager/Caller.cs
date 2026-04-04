using System;

/*
     * Caller Class – Entry Point
     * ---------------------------------------
     * This class acts as the main entry point for the Bank Account Manager system.
     *
     * Responsibilities:
     * - Displays the welcome screen and role selection menu (Manager / User).
     * - Accepts account number input from the user.
     * - Redirects control to appropriate menus based on selected role.
     *
     * Manager Functions:
     * - View account information
     * - Modify (credit/debit) account balance
     *
     * User Functions:
     * - Check account balance
     * - Debit money
     * - Credit money
     *
     * Flow Control:
     * - Uses switch-case and looping menus for continuous interaction.
     * - Exits gracefully when the user selects the exit option.
     *
     * Purpose:
     * - Demonstrates program flow control, menu-driven logic,
     *   method invocation, and user interaction in C#.
 */


namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.bank_account_manager
{
    internal class Caller
    {
        public static void Main(string[] args)
        {
            BankAccount bnk = new BankAccount();

            Console.WriteLine("=================================");
            Console.WriteLine(" Welcome to Bank Account System ");
            Console.WriteLine("=================================");
            Console.WriteLine("1. Manager");
            Console.WriteLine("2. Guest (User)");
            Console.Write("Select your role (1/2): ");

            int role = int.Parse(Console.ReadLine());

            Console.Write("Enter Account Number: ");
            string accountNumber = Console.ReadLine();

            switch (role)
            {
                // MANAGER
                case 1:
                    bool exitManager = false;
                    while (!exitManager)
                    {
                        Console.WriteLine("\n----- Manager Menu -----");
                        Console.WriteLine("1. View Account Info");
                        Console.WriteLine("2. Modify Account Balance");
                        Console.WriteLine("3. Exit");
                        Console.Write("Enter choice: ");

                        int managerChoice = int.Parse(Console.ReadLine());

                        switch (managerChoice)
                        {
                            case 1:
                                bnk.GetAccountInfo(accountNumber);
                                break;

                            case 2:
                                bnk.SetAccountInfo(accountNumber);
                                break;

                            case 3:
                                exitManager = true;
                                Console.WriteLine("Exiting Manager Menu...");
                                break;

                            default:
                                Console.WriteLine("Invalid choice!");
                                break;
                        }
                    }
                    break;

                // GUEST / USER
                case 2:
                    bool exitUser = false;
                    while (!exitUser)
                    {
                        Console.WriteLine("\n----- User Menu -----");
                        Console.WriteLine("1. Check Balance");
                        Console.WriteLine("2. Debit");
                        Console.WriteLine("3. Credit");
                        Console.WriteLine("4. Exit");
                        Console.Write("Enter choice: ");

                        int userChoice = int.Parse(Console.ReadLine());

                        switch (userChoice)
                        {
                            case 1:
                                bnk.CheckBalance(accountNumber);
                                break;

                            case 2:
                                bnk.Debit(accountNumber);
                                break;

                            case 3:
                                bnk.Credit(accountNumber);
                                break;

                            case 4:
                                exitUser = true;
                                Console.WriteLine("Thank you for using our service!");
                                break;

                            default:
                                Console.WriteLine("Invalid choice!");
                                break;
                        }
                    }
                    break;

                default:
                    Console.WriteLine("Invalid role selection!");
                    break;
            }
        }
    }
}
