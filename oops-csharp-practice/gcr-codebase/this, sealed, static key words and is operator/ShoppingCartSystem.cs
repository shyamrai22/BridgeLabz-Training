using System;

namespace BridgeLabzTraining.oops_csharp_practice.this__sealed__static_key_words_and_is_operator
{
    class Product
    {
        public static double Discount = 20.0; 
        public readonly int ProductID;

        // instance variables
        public string ProductName;
        public double Price;
        public int Quantity;

        // using 'this' keyword
        public Product(int productId, string productName, double price, int quantity)
        {
            this.ProductID = productId;      
            this.ProductName = productName;
            this.Price = price;
            this.Quantity = quantity;
        }

        // method to update discount
        public static void UpdateDiscount(double newDiscount)
        {
            if (newDiscount >= 0 && newDiscount <= 100)
            {
                Discount = newDiscount;
            }
            else
            {
                Console.WriteLine("Invalid discount percentage");
            }
        }

        // using 'is' operator
        public void DisplayDetails(object obj)
        {
            if (obj is Product)
            {
                double totalPrice = Price * Quantity;
                double discountedPrice = totalPrice - (totalPrice * Discount / 100);

                Console.WriteLine("============================");
                Console.WriteLine($"Product ID    --> {ProductID}");
                Console.WriteLine($"Product Name  --> {ProductName}");
                Console.WriteLine($"Price         --> {Price}");
                Console.WriteLine($"Quantity      --> {Quantity}");
                Console.WriteLine($"Discount      --> {Discount}%");
                Console.WriteLine($"Final Amount  --> {discountedPrice}");
                Console.WriteLine("============================");
            }
            else
            {
                Console.WriteLine("Object is not a Product");
            }
        }
    }

    // Caller class
    class Caller
    {
        public static void Main(string[] args)
        {
            Product product1 = new Product(1, "Laptop", 60000, 1);
            Product product2 = new Product(2, "Mouse", 800, 2);
            product1.DisplayDetails(product1);
            product2.DisplayDetails(product2);
            
            Product.UpdateDiscount(15);

            product1.DisplayDetails(product1);
            product2.DisplayDetails(product2);


            object obj = "Not a product";
            product1.DisplayDetails(obj);
        }
    }
}
