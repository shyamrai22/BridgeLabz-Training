namespace BridgeLabzTraining.oops_csharp_practice.encapsulation_polymorphism_interface_and_abstract_class.banking_system
{
    public class SavingsAccount : BankAccount, ILoanable
    {
        public SavingsAccount(string accNo, string name, double balance)
            : base(accNo, name, balance)
        {
        }

        public override double CalculateInterest()
        {
            return balance * 0.04; 
        }

        public void ApplyForLoan(double amount)
        {
            Console.WriteLine($"Loan applied for amount: {amount}");
        }

        public double CalculateLoanEligibility()
        {
            return balance * 3; 
        }
    }
}
