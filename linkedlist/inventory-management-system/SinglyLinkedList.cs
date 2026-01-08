using System;

namespace BridgeLabzTraining.dsa_csharp_practice.inventory_management_system
{
    class SinglyLinkedList
    {
        private Node head;

        // Add at beginning
        public void AddAtBeginning(Item item)
        {
            Node newNode = new Node(item);
            newNode.Next = head;
            head = newNode;
        }

        // Add at end
        public void AddAtEnd(Item item)
        {
            Node newNode = new Node(item);

            if (head == null)
            {
                head = newNode;
                return;
            }

            Node temp = head;
            while (temp.Next != null)
                temp = temp.Next;

            temp.Next = newNode;
        }

        // Add at position (1-based)
        public void AddAtPosition(Item item, int position)
        {
            if (position <= 1)
            {
                AddAtBeginning(item);
                return;
            }

            Node temp = head;
            for (int i = 1; i < position - 1 && temp != null; i++)
                temp = temp.Next;

            if (temp == null)
            {
                Console.WriteLine("Invalid position.");
                return;
            }

            Node newNode = new Node(item);
            newNode.Next = temp.Next;
            temp.Next = newNode;
        }

        // Remove by Item ID
        public void RemoveByItemId(int itemId)
        {
            if (head == null)
            {
                Console.WriteLine("Inventory empty.");
                return;
            }

            if (head.Data.ItemId == itemId)
            {
                head = head.Next;
                Console.WriteLine("Item removed.");
                return;
            }

            Node temp = head;
            while (temp.Next != null && temp.Next.Data.ItemId != itemId)
                temp = temp.Next;

            if (temp.Next == null)
            {
                Console.WriteLine("Item not found.");
                return;
            }

            temp.Next = temp.Next.Next;
            Console.WriteLine("Item removed.");
        }

        // Update quantity
        public void UpdateQuantity(int itemId, int newQuantity)
        {
            Node temp = head;
            while (temp != null)
            {
                if (temp.Data.ItemId == itemId)
                {
                    temp.Data.Quantity = newQuantity;
                    Console.WriteLine("Quantity updated.");
                    return;
                }
                temp = temp.Next;
            }
            Console.WriteLine("Item not found.");
        }

        // Search by ID
        public void SearchById(int itemId)
        {
            Node temp = head;
            while (temp != null)
            {
                if (temp.Data.ItemId == itemId)
                {
                    temp.Data.Display();
                    return;
                }
                temp = temp.Next;
            }
            Console.WriteLine("Item not found.");
        }

        // Search by Name
        public void SearchByName(string name)
        {
            Node temp = head;
            bool found = false;

            while (temp != null)
            {
                if (temp.Data.ItemName.Equals(name))
                {
                    temp.Data.Display();
                    found = true;
                }
                temp = temp.Next;
            }

            if (!found)
                Console.WriteLine("Item not found.");
        }

        // Total inventory value
        public void CalculateTotalValue()
        {
            double total = 0;
            Node temp = head;

            while (temp != null)
            {
                total += temp.Data.Price * temp.Data.Quantity;
                temp = temp.Next;
            }

            Console.WriteLine($"Total Inventory Value: {total}");
        }

        // Sort by Name or Price
        public void Sort(bool byName, bool ascending)
        {
            if (head == null)
                return;

            for (Node i = head; i.Next != null; i = i.Next)
            {
                for (Node j = i.Next; j != null; j = j.Next)
                {
                    bool condition;

                    if (byName)
                        condition = ascending
                            ? string.Compare(i.Data.ItemName, j.Data.ItemName) > 0
                            : string.Compare(i.Data.ItemName, j.Data.ItemName) < 0;
                    else
                        condition = ascending
                            ? i.Data.Price > j.Data.Price
                            : i.Data.Price < j.Data.Price;

                    if (condition)
                    {
                        Item temp = i.Data;
                        i.Data = j.Data;
                        j.Data = temp;
                    }
                }
            }

            Console.WriteLine("Inventory sorted.");
        }

        // Display all
        public void DisplayAll()
        {
            if (head == null)
            {
                Console.WriteLine("Inventory empty.");
                return;
            }

            Node temp = head;
            while (temp != null)
            {
                temp.Data.Display();
                temp = temp.Next;
            }
        }
    }
}
