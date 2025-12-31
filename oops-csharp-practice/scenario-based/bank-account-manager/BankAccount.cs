using System;

/*
     * Bank Account Manager System
     * ---------------------------------------
     * This class simulates a basic banking system using a 2D array to store account data.
     *
     * Features:
     * - Stores account number, account holder name, balance, and user PIN.
     * - Allows a bank manager (secured by a manager PIN) to:
     *      • View account details
     *      • Add or remove balance from any account
     * - Allows users (secured by individual PINs) to:
     *      • Credit money
     *      • Debit money
     *      • Check account balance
     *
     * Validations:
     * - Verifies account existence before any operation
     * - Ensures correct PIN authentication (manager/user)
     * - Prevents invalid transactions (negative amount, insufficient balance)
     *
     * Purpose:
     * - Demonstrates OOP concepts, access control, loops, conditionals,
     *   and basic data handling in C#.
 */


namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.bank_account_manager
{
    internal class BankAccount
    {
        private string BankManagerPin = "1432";
        private static string[,] BankAccounts = {
                                                    { "ACC001", "Shyam",   "50000", "1234" },
                                                    { "ACC002", "Amit",    "12000", "2345" },
                                                    { "ACC003", "Rohit",   "8000",  "3456" },
                                                    { "ACC004", "Neha",    "15000", "4567" },
                                                    { "ACC005", "Priya",   "3000",  "5678" },
                                                    { "ACC006", "Rahul",   "9500",  "6789" },
                                                    { "ACC007", "Ankit",   "20000", "7890" },
                                                    { "ACC008", "Sneha",   "7000",  "8901" },
                                                    { "ACC009", "Karan",   "11000", "9012" },
                                                    { "ACC010", "Pooja",   "4000",  "1122" },
                                                    { "ACC011", "Vikas",   "6000",  "2233" },
                                                    { "ACC012", "Riya",    "13000", "3344" },
                                                    { "ACC013", "Suman",   "9000",  "4455" },
                                                    { "ACC014", "Arjun",   "17000", "5566" },
                                                    { "ACC015", "Nisha",   "2500",  "6677" },
                                                    { "ACC016", "Manish",  "14500", "7788" },
                                                    { "ACC017", "Kavya",   "10000", "8899" },
                                                    { "ACC018", "Deepak",  "5500",  "9900" },
                                                    { "ACC019", "Isha",    "16000", "2468" },
                                                    { "ACC020", "Rakesh",  "7500",  "1357" }
                                                };

        // Method for bank manager to get account's info
        public void GetAccountInfo(string accountNumber)
        {
            Console.Write("Enter your pin (Manager) --> ");
            string pinEntered = Console.ReadLine();
            if (pinEntered != BankManagerPin)
            {
                Console.WriteLine("Invalid PIN!");
                return;
            }
            for (int i = 0; i < BankAccounts.GetLength(0); i++)
            {
                if (BankAccounts[i, 0].Equals(accountNumber, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("---------------------------------------");
                    Console.WriteLine($"Account number -> {BankAccounts[i, 0]}");
                    Console.WriteLine($"Account user -> {BankAccounts[i, 1]}");
                    Console.WriteLine($"Account balance -> {BankAccounts[i, 2]}");
                    Console.WriteLine("---------------------------------------");
                    return;
                }
            }
            Console.WriteLine("Account number entered does not exists!!");
            Console.WriteLine("Please, Try Again!!");
        }

        // Method for bank manager to change account's balance
        public void SetAccountInfo(string accountNumber)
        {
            Console.Write("Enter your pin (Manager) --> ");
            string pinEntered = Console.ReadLine();
            if (pinEntered != BankManagerPin)
            {
                Console.WriteLine("Invalid PIN!");
                return;
            }
            string ans = "";
            int accountIdx = -1;
            for (int i = 0; i < BankAccounts.GetLength(0); i++)
            {
                if (BankAccounts[i, 0].Equals(accountNumber, StringComparison.OrdinalIgnoreCase))
                {
                    accountIdx = i;
                    Console.WriteLine("---------------------------------------");
                    Console.WriteLine($"Account number -> {BankAccounts[i, 0]}");
                    Console.WriteLine($"Account user -> {BankAccounts[i, 1]}");
                    Console.WriteLine($"Account balance -> {BankAccounts[i, 2]}");
                    Console.WriteLine("---------------------------------------");
                    break;
                }
            }
            if (accountIdx == -1)
            {
                Console.WriteLine("Account number entered does not exists!!");
                Console.WriteLine("Please, Try Again!!");
                return;
            }
            int currentBalance = int.Parse(BankAccounts[accountIdx, 2]);
            Console.WriteLine("Do you want to add/remove (a/r) amount?");
            ans = Console.ReadLine().ToLower();

            if (ans == "a")
            {
                Console.Write("Enter amount to be credited -> ");
                int amountToBeAdded = int.Parse(Console.ReadLine());
                if (amountToBeAdded > 0)
                {
                    Console.WriteLine("---------------------------------------");
                    int updatedBalance = currentBalance + amountToBeAdded;
                    BankAccounts[accountIdx, 2] = updatedBalance.ToString();
                    Console.WriteLine("---------------------------------------");
                    Console.WriteLine($"Account number -> {BankAccounts[accountIdx, 0]}");
                    Console.WriteLine($"Account user -> {BankAccounts[accountIdx, 1]}");
                    Console.WriteLine($"Updated account balance -> {BankAccounts[accountIdx, 2]}");
                    Console.WriteLine("---------------------------------------");
                    return;
                }
                else
                {
                    Console.WriteLine("Amount enter cannot be processed");
                }

            }

            else if (ans == "r")
            {
                Console.Write("Enter amount to be debited -> ");
                int amountToBeRemoved = int.Parse(Console.ReadLine());
                if (amountToBeRemoved > 0 && amountToBeRemoved <= currentBalance)
                {
                    Console.WriteLine("---------------------------------------");
                    int updatedBalance = currentBalance - amountToBeRemoved;
                    BankAccounts[accountIdx, 2] = updatedBalance.ToString();
                    Console.WriteLine($"Updated balance -> {BankAccounts[accountIdx, 2]}");
                    return;
                }
                else
                {
                    Console.WriteLine("Amount enter cannot be processed");
                }
            }
        }

        // Method for the user to debit amount from their account
        public void Debit(string accountNumber)
        {
            int accountIdx = -1;

            for (int i = 0; i < BankAccounts.GetLength(0); i++)
            {
                if (BankAccounts[i, 0].Equals(accountNumber, StringComparison.OrdinalIgnoreCase))
                {
                    accountIdx = i;
                    break;
                }
            }

            if (accountIdx == -1)
            {
                Console.WriteLine("Account number entered does not exist!");
                return;
            }

            Console.Write("Enter your PIN (User) --> ");
            string pinEntered = Console.ReadLine();

            if (pinEntered != BankAccounts[accountIdx, 3])
            {
                Console.WriteLine("Invalid PIN!");
                return;
            }

            
            Console.WriteLine("---------------------------------------");
            Console.WriteLine($"Account number -> {BankAccounts[accountIdx, 0]}");
            Console.WriteLine($"Account user   -> {BankAccounts[accountIdx, 1]}");
            Console.WriteLine($"Account balance-> {BankAccounts[accountIdx, 2]}");
            Console.WriteLine("---------------------------------------");

            int currentBalance = int.Parse(BankAccounts[accountIdx, 2]);

            Console.Write("Enter amount to be debited -> ");
            int amountToBeRemoved = int.Parse(Console.ReadLine());

            if (amountToBeRemoved > 0 && amountToBeRemoved <= currentBalance)
            {
                int updatedBalance = currentBalance - amountToBeRemoved;
                BankAccounts[accountIdx, 2] = updatedBalance.ToString();

                Console.WriteLine("---------------------------------------");
                Console.WriteLine($"Amount debited -> {amountToBeRemoved}");
                Console.WriteLine($"Current balance -> {BankAccounts[accountIdx, 2]}");
                Console.WriteLine("---------------------------------------");
            }
            else
            {
                Console.WriteLine("Invalid amount or insufficient balance!");
            }
        }

        // Method for the user to credit amount to their account
        public void Credit(string accountNumber)
        {
            int accountIdx = -1;

            for (int i = 0; i < BankAccounts.GetLength(0); i++)
            {
                if (BankAccounts[i, 0].Equals(accountNumber, StringComparison.OrdinalIgnoreCase))
                {
                    accountIdx = i;
                    break;
                }
            }

            if (accountIdx == -1)
            {
                Console.WriteLine("Account number entered does not exist!");
                return;
            }

            Console.Write("Enter your PIN (User) --> ");
            string pinEntered = Console.ReadLine();

            if (pinEntered != BankAccounts[accountIdx, 3])
            {
                Console.WriteLine("Invalid PIN!");
                return;
            }

            Console.WriteLine("---------------------------------------");
            Console.WriteLine($"Account number -> {BankAccounts[accountIdx, 0]}");
            Console.WriteLine($"Account user   -> {BankAccounts[accountIdx, 1]}");
            Console.WriteLine($"Account balance-> {BankAccounts[accountIdx, 2]}");
            Console.WriteLine("---------------------------------------");

            int currentBalance = int.Parse(BankAccounts[accountIdx, 2]);

            Console.Write("Enter amount to be credited -> ");
            int amountToBeAdded = int.Parse(Console.ReadLine());

            if (amountToBeAdded > 0)
            {
                int updatedBalance = currentBalance + amountToBeAdded;
                BankAccounts[accountIdx, 2] = updatedBalance.ToString();

                Console.WriteLine("---------------------------------------");
                Console.WriteLine($"Amount credited -> {amountToBeAdded}");
                Console.WriteLine($"Current balance -> {BankAccounts[accountIdx, 2]}");
                Console.WriteLine("---------------------------------------");
            }
            else
            {
                Console.WriteLine("Invalid amount!");
            }
        }

        // Method for the user to check amount of their account
        public void CheckBalance(string accountNumber)
        {
            int accountIdx = -1;

            for (int i = 0; i < BankAccounts.GetLength(0); i++)
            {
                if (BankAccounts[i, 0].Equals(accountNumber, StringComparison.OrdinalIgnoreCase))
                {
                    accountIdx = i;
                    break;
                }
            }

            if (accountIdx == -1)
            {
                Console.WriteLine("Account number entered does not exist!");
                return;
            }

            Console.Write("Enter your PIN (User) --> ");
            string pinEntered = Console.ReadLine();

            if (pinEntered != BankAccounts[accountIdx, 3])
            {
                Console.WriteLine("Invalid PIN!");
                return;
            }

            Console.WriteLine("---------------------------------------");
            Console.WriteLine($"Account number -> {BankAccounts[accountIdx, 0]}");
            Console.WriteLine($"Account user   -> {BankAccounts[accountIdx, 1]}");
            Console.WriteLine($"Current balance-> {BankAccounts[accountIdx, 2]}");
            Console.WriteLine("---------------------------------------");
        }


    }
}
