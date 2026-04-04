namespace BridgeLabzTraining.oops_csharp_practice.encapsulation_polymorphism_interface_and_abstract_class.online_food_delivery_system
{
    public class VegItem : FoodItem, IDiscountable
    {
        public VegItem(string name, double price, int quantity)
            : base(name, price, quantity)
        {
        }

        public override double CalculateTotalPrice()
        {
            return price * quantity;
        }

        public double ApplyDiscount()
        {
            return CalculateTotalPrice() * 0.10;
        }

        public string GetDiscountDetails()
        {
            return "Veg Discount 10%";
        }
    }
}
