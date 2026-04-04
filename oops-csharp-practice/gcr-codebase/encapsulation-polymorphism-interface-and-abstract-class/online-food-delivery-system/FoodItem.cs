using System;

namespace BridgeLabzTraining.oops_csharp_practice.encapsulation_polymorphism_interface_and_abstract_class.online_food_delivery_system
{
    public abstract class FoodItem
    {
        private string itemName;
        protected double price;
        protected int quantity;

        public FoodItem(string itemName, double price, int quantity)
        {
            this.itemName = itemName;
            this.price = price;
            this.quantity = quantity;
        }

        public abstract double CalculateTotalPrice();

        public void GetItemDetails()
        {
            Console.WriteLine("Item Name : " + itemName);
            Console.WriteLine("Price    : " + price);
            Console.WriteLine("Quantity : " + quantity);
        }
    }
}
