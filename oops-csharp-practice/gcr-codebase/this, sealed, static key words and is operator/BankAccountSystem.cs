using System;

namespace BridgeLabzTraining.oops_csharp_practice.this__sealed__static_key_words_and_is_operator
{
    class BankAccount
    {
        public static string bankName = "ABC Bank";
        private static int totalAccounts = 0;
        public readonly string AccountNumber;

        // instance variable
        public string AccountHolderName;

        // constructor using 'this' keyword
        public BankAccount(string accountHolderName, string accountNumber)
        {
            this.AccountHolderName = accountHolderName;   
            this.AccountNumber = accountNumber;           
            totalAccounts++;
        }

        // static method
        public static void GetTotalAccounts()
        {
            Console.WriteLine($"Total Accounts --> {totalAccounts}");
        }

        // instance method
        public void DisplayDetails(object obj)
        {
            // 'is' operator
            if (obj is BankAccount)
            {
                Console.WriteLine("============================");
                Console.WriteLine($"Bank Name      --> {bankName}");
                Console.WriteLine($"Account Holder --> {AccountHolderName}");
                Console.WriteLine($"Account Number --> {AccountNumber}");
                Console.WriteLine("============================");
            }
            else
            {
                Console.WriteLine("Object is not a BankAccount");
            }
        }
    }

    // Caller class
    class Caller
    {
        public static void Main(string[] args)
        {
            BankAccount account1 = new BankAccount("Shyam", "ABC1001");
            BankAccount account2 = new BankAccount("Daman", "ABC1002");

            account1.DisplayDetails(account1);
            account2.DisplayDetails(account2);
            BankAccount.GetTotalAccounts();
            object obj = "Not an account";
            account1.DisplayDetails(obj);
        }
    }
}
