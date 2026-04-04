namespace BridgeLabzTraining.oops_csharp_practice.encapsulation_polymorphism_interface_and_abstract_class.banking_system
{
    public interface ILoanable
    {
        void ApplyForLoan(double amount);
        double CalculateLoanEligibility();
    }
}
