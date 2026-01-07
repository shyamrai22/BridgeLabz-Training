using System;

namespace BridgeLabzTraining.oops_csharp_practice.encapsulation_polymorphism_interface_and_abstract_class.banking_system
{
    class BankCaller
    {
        static void Main(string[] args)
        {
            BankAccount[] accounts = new BankAccount[5];
            int index = 0;

            accounts[index++] = new SavingsAccount("SA101", "Rahul", 50000);
            accounts[index++] = new CurrentAccount("CA202", "Anita", 80000);

            Console.WriteLine("BANK ACCOUNT DETAILS");
            Console.WriteLine();

            for (int i = 0; i < index; i++)
            {
                ProcessAccount(accounts[i]);
                Console.WriteLine("--------------------------------------");
            }
        }

        static void ProcessAccount(BankAccount account)
        {
            account.DisplayAccountDetails();

            double interest = account.CalculateInterest();
            Console.WriteLine($"Interest Earned : {interest}");

            if (account is ILoanable loanable)
            {
                loanable.ApplyForLoan(100000);
                Console.WriteLine($"Loan Eligibility: {loanable.CalculateLoanEligibility()}");
            }
            else
            {
                Console.WriteLine("Loan Facility  : Not Available");
            }
        }
    }
}
