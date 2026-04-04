namespace BridgeLabzTraining.oops_csharp_practice.encapsulation_polymorphism_interface_and_abstract_class.online_food_delivery_system
{
    public class NonVegItem : FoodItem, IDiscountable
    {
        public NonVegItem(string name, double price, int quantity)
            : base(name, price, quantity)
        {
        }

        public override double CalculateTotalPrice()
        {
            return (price * quantity) + 50;
        }

        public double ApplyDiscount()
        {
            return CalculateTotalPrice() * 0.05;
        }

        public string GetDiscountDetails()
        {
            return "Non-Veg Discount 5%";
        }
    }
}
