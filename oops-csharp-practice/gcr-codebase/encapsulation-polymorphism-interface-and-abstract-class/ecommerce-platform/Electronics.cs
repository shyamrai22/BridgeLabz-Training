namespace BridgeLabzTraining.oops_csharp_practice.encapsulation_polymorphism_interface_and_abstract_class.ecommerce_platform
{
    public class Electronics : Product, ITaxable
    {
        public Electronics(int id, string name, double price)
            : base(id, name, price)
        {
        }

        public override double CalculateDiscount()
        {
            return price * 0.10;
        }

        public double CalculateTax()
        {
            return price * 0.15;
        }

        public string GetTaxDetails()
        {
            return "GST 15%";
        }
    }
}
