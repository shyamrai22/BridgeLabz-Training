using System;

namespace BridgeLabzTraining.oops_csharp_practice.encapsulation_polymorphism_interface_and_abstract_class.online_food_delivery_system
{
    class FoodDeliveryCaller
    {
        static void Main(string[] args)
        {
            FoodItem[] items = new FoodItem[5];
            int index = 0;

            items[index++] = new VegItem("Paneer Butter Masala", 250, 2);
            items[index++] = new NonVegItem("Chicken Biryani", 300, 1);

            Console.WriteLine("ORDER DETAILS");
            Console.WriteLine();

            for (int i = 0; i < index; i++)
            {
                ProcessFoodItem(items[i]);
                Console.WriteLine("-----------------------------------");
            }
        }

        static void ProcessFoodItem(FoodItem item)
        {
            item.GetItemDetails();

            double totalPrice = item.CalculateTotalPrice();
            double discount = 0;

            if (item is IDiscountable discountable)
            {
                discount = discountable.ApplyDiscount();
                Console.WriteLine("Discount Type : " + discountable.GetDiscountDetails());
            }

            Console.WriteLine("Total Price   : " + totalPrice);
            Console.WriteLine("Discount      : " + discount);
            Console.WriteLine("Final Amount  : " + (totalPrice - discount));
        }
    }
}
