using System;

namespace BridgeLabzTraining.oops_csharp_practice.encapsulation_polymorphism_interface_and_abstract_class.ecommerce_platform
{
    class ECommerceCaller
    {
        static void Main(string[] args)
        {
            Product[] products = new Product[5];
            int idx = 0;

            products[idx++] = new Electronics(201, "Laptop", 60000);
            products[idx++] = new Clothing(202, "Jacket", 3000);
            products[idx++] = new Groceries(203, "Rice", 1200);

            Console.WriteLine("FINAL PRICE DETAILS");
            Console.WriteLine();
            

            for (int i = 0; i < idx; i++)
            {
                PrintFinalPrice(products[i]);
                Console.WriteLine("--------------------------------------");
            }
        }

        static void PrintFinalPrice(Product product)
        {
            product.DisplayProduct();

            double discount = product.CalculateDiscount();
            double tax = 0;

            if (product is ITaxable taxable)
            {
                tax = taxable.CalculateTax();
                Console.WriteLine($"Tax Type --> {taxable.GetTaxDetails()}");
            }
            else
            {
                Console.WriteLine("Tax Type --> No Tax");
            }

            double finalPrice = product.GetPrice() + tax - discount;

            Console.WriteLine($"Discount   : {discount}");
            Console.WriteLine($"Tax        : {tax}");
            Console.WriteLine($"Final Price: {finalPrice}");
        }
    }
}
