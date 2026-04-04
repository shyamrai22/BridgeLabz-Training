using System;

namespace BridgeLabzTraining.oops_csharp_practice.encapsulation_polymorphism_interface_and_abstract_class.ecommerce_platform
{
    public abstract class Product
    {
        private int productId;
        private string name;
        protected double price;

        public void SetProductId(int productId)
        {
            this.productId = productId;
        }

        public int GetProductId()
        {
            return productId;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return name;
        }

        public void SetPrice(double price)
        {
            this.price = price;
        }

        public double GetPrice()
        {
            return price;
        }

        public Product(int productId, string name, double price)
        {
            this.productId = productId;
            this.name = name;
            this.price = price;
        }

        public abstract double CalculateDiscount();

        public void DisplayProduct()
        {
            Console.WriteLine($"Product ID  : {productId}");
            Console.WriteLine($"Name        : {name}");
            Console.WriteLine($"Base Price  : {price}");
        }
    }
}
