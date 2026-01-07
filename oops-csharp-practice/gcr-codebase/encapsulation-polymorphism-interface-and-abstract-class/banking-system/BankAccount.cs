using System;

namespace BridgeLabzTraining.oops_csharp_practice.encapsulation_polymorphism_interface_and_abstract_class.banking_system
{
    public abstract class BankAccount
    {
        private string accountNumber;
        private string holderName;
        protected double balance;

        public string GetAccountNumber()
        {
            return accountNumber;
        }

        public string GetHolderName()
        {
            return holderName;
        }

        public double GetBalance()
        {
            return balance;
        }

        public BankAccount(string accountNumber, string holderName, double balance)
        {
            this.accountNumber = accountNumber;
            this.holderName = holderName;
            this.balance = balance;
        }

        public void Deposit(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Invalid deposit amount.");
                return;
            }

            balance += amount;
            Console.WriteLine($"Deposited: {amount}");
        }

        public void Withdraw(double amount)
        {
            if (amount <= 0 || amount > balance)
            {
                Console.WriteLine("Invalid withdrawal.");
                return;
            }

            balance -= amount;
            Console.WriteLine($"Withdrawn: {amount}");
        }

        public abstract double CalculateInterest();

        public void DisplayAccountDetails()
        {
            Console.WriteLine($"Account Number : {accountNumber}");
            Console.WriteLine($"Holder Name    : {holderName}");
            Console.WriteLine($"Balance        : {balance}");
        }
    }
}
