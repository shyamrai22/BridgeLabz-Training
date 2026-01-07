namespace BridgeLabzTraining.oops_csharp_practice.encapsulation_polymorphism_interface_and_abstract_class.banking_system
{
    public class CurrentAccount : BankAccount
    {
        public CurrentAccount(string accNo, string name, double balance)
            : base(accNo, name, balance)
        {
        }

        public override double CalculateInterest()
        {
            return balance * 0.01; 
        }
    }
}
