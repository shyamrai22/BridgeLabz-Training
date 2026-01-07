namespace BridgeLabzTraining.oops_csharp_practice.encapsulation_polymorphism_interface_and_abstract_class.ecommerce_platform
{
    public class Groceries : Product
    {
        public Groceries(int id, string name, double price)
            : base(id, name, price)
        {
        }

        public override double CalculateDiscount()
        {
            return price * 0.05;
        }
    }
}
