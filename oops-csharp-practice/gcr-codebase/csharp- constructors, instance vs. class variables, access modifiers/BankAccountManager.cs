using System;

namespace BridgeLabzTraining.oops_csharp_practice.csharp_constructors__instance_vs._class_variables__access_modifiers
{
    class BankAccount
    {

        public string accountNumber;
        protected string accountHolder;
        private double balance;

        // constructor
        public BankAccount(string accountNumber, string accountHolder, double balance)
        {
            this.accountNumber = accountNumber;
            this.accountHolder = accountHolder;
            this.balance = balance;
        }

        // Method to get balance
        public double GetBalance()
        {
            return balance;
        }

        // Method to deposit money
        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
            }
            else
            {
                Console.WriteLine("Invalid deposit amount");
            }
        }

        // Method to withdraw money
        public void Withdraw(double amount)
        {
            if (amount > 0 && amount <= balance)
            {
                balance -= amount;
            }
            else
            {
                Console.WriteLine("Invalid withdrawal amount");
            }
        }
    }

    class SavingsAccount : BankAccount
    {
        private double interestRate;

        public SavingsAccount(string accountNumber, string accountHolder, double balance, double interestRate)
            : base(accountNumber, accountHolder, balance)
        {
            this.interestRate = interestRate;
        }

        public void DisplayAccountDetails()
        {
            Console.WriteLine("============================");
            Console.WriteLine($"Account Number --> {accountNumber}");   
            Console.WriteLine($"Account Holder --> {accountHolder}");   
            Console.WriteLine($"Balance        --> ₹{GetBalance()}");    
            Console.WriteLine($"Interest Rate  --> {interestRate}%");
            Console.WriteLine("============================");
        }
    }

    // Caller class
    class Caller
    {
        public static void Main(string[] args)
        {
            SavingsAccount savings = new SavingsAccount("SB1001", "Shyam", 5000000, 1.5);

            savings.DisplayAccountDetails();
            savings.Deposit(10000);
            savings.Withdraw(5000);
            Console.WriteLine("Updated Balance --> " + savings.GetBalance());

        }
    }
}
