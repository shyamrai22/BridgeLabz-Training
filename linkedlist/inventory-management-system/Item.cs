using System;

namespace BridgeLabzTraining.dsa_csharp_practice.inventory_management_system
{
    class Item
    {
        private int itemId;
        private string itemName;
        private int quantity;
        private double price;

        public int ItemId
        {
            get { return itemId; }
            set { itemId = value; }
        }

        public string ItemName
        {
            get { return itemName; }
            set { itemName = value; }
        }

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public Item(int itemId, string itemName, int quantity, double price)
        {
            this.itemId = itemId;
            this.itemName = itemName;
            this.quantity = quantity;
            this.price = price;
        }

        public void Display()
        {
            Console.WriteLine(
                $"ID: {ItemId}, Name: {ItemName}, Qty: {Quantity}, Price: {Price}"
            );
        }
    }
}
