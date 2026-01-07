namespace BridgeLabzTraining.oops_csharp_practice.encapsulation_polymorphism_interface_and_abstract_class.ecommerce_platform
{
    public class Clothing : Product, ITaxable
    {
        public Clothing(int id, string name, double price)
            : base(id, name, price)
        {
        }

        public override double CalculateDiscount()
        {
            return price * 0.20;
        }

        public double CalculateTax()
        {
            return price * 0.05;
        }

        public string GetTaxDetails()
        {
            return "Tax 5%";
        }
    }
}
