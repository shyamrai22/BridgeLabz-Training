using System;

namespace BridgeLabzTraining.oops_csharp_practice.csharp_constructors__instance_vs._class_variables__access_modifiers
{
    class Product
    {
        // instance variables
        private string productName;
        private double price;

        // class variable
        private static int totalProducts = 0;

        // parameterized constructor
        public Product(string productName, double price)
        {
            this.productName = productName;
            this.price = price;
            totalProducts++;   
        }

        // instance method
        public void DisplayDetails()
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine($"Product Name --> {productName}");
            Console.WriteLine($"Price        --> {price}");
            Console.WriteLine("-------------------------");
        }

        // class method
        public static void DisplayTotalProducts()
        {
            Console.WriteLine($"Total Products Created --> {totalProducts}");
            Console.WriteLine("-------------------------");
        }
    }

    // Caller class
    class Caller
    {
        public static void Main(string[] args)
        {
            Product product1 = new Product("Laptop", 65000);
            Product product2 = new Product("Mouse", 800);
            Product product3 = new Product("Keyboard", 1500);

            product1.DisplayDetails();
            product2.DisplayDetails();
            product3.DisplayDetails();

            Product.DisplayTotalProducts();
        }
    }
}
