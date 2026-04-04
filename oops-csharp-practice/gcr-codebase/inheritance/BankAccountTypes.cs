using System;

namespace BridgeLabzTraining.oops_csharp_practice.inheritance
{
    // Superclass
    class BankAccount
    {
        public string AccountNumber;
        public double Balance;

        public BankAccount(string accountNumber, double balance)
        {
            AccountNumber = accountNumber;
            Balance = balance;
        }

        public virtual void DisplayAccount()
        {
            Console.WriteLine("Bank Account");
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"Account Number --> {AccountNumber}");
            Console.WriteLine($"Balance --> {Balance}");
        }
    }

    // SavingsAccount
    class SavingsAccount : BankAccount
    {
        public double InterestRate;

        public SavingsAccount(string accountNumber, double balance, double instRate) : base(accountNumber, balance)
        {
            InterestRate = instRate;
        }

        public override void DisplayAccount()
        {
            Console.WriteLine("Account Type --> Savings Account");
            DisplayDetails();
            Console.WriteLine($"Interest Rate --> {InterestRate}%");
            Console.WriteLine("----------------------------------");
        }
    }

    // CheckingAccount
    class CheckingAccount : BankAccount
    {
        public double WithdrawalLimit;

        public CheckingAccount(string accountNumber, double balance, double withdrawalLimit) : base(accountNumber, balance)
        {
            WithdrawalLimit = withdrawalLimit;
        }

        public override void DisplayAccount()
        {
            Console.WriteLine("Account Type --> Checking Account");
            DisplayDetails();
            Console.WriteLine($"Withdrawal Limit --> {WithdrawalLimit}");
            Console.WriteLine("--------------------------------------");
        }
    }

    // FixedDepositAccount
    class FixedDepositAccount : BankAccount
    {
        public int LockInPeriod;

        public FixedDepositAccount(string accountNumber, double balance, int lockInPeriod) : base(accountNumber, balance)
        {
            LockInPeriod = lockInPeriod;
        }

        public override void DisplayAccount()
        {
            Console.WriteLine("Account Type --> Fixed Deposit Account");
            DisplayDetails();
            Console.WriteLine($"Lock-in Period--> {LockInPeriod} months");
            Console.WriteLine("----------------------------------------");
        }
    }

    // Caller class
    class Caller
    {
        public static void Main(string[] args)
        {
            BankAccount[] bankAccounts =
            {
                new SavingsAccount("1001", 50000, 4.5),
                new CheckingAccount("2001", 30000, 20000),
                new FixedDepositAccount("3001", 100000, 24)
            };

            foreach (BankAccount accounts in bankAccounts)
            {
                accounts.DisplayAccount();
            }
        }
    }
}
