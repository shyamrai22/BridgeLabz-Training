using System;

namespace BridgeLabzTraining.dsa_csharp_practice.inventory_management_system
{
    class Caller
    {
        static void Main(string[] args)
        {
            SinglyLinkedList inventory = new SinglyLinkedList();
            int choice;

            do
            {
                Console.WriteLine("--- Inventory Management System ---");
                Console.WriteLine("1. Add at Beginning");
                Console.WriteLine("2. Add at End");
                Console.WriteLine("3. Add at Position");
                Console.WriteLine("4. Remove by Item ID");
                Console.WriteLine("5. Update Quantity");
                Console.WriteLine("6. Search by Item ID");
                Console.WriteLine("7. Search by Item Name");
                Console.WriteLine("8. Total Inventory Value");
                Console.WriteLine("9. Sort Inventory");
                Console.WriteLine("10. Display All");
                Console.WriteLine("0. Exit");
                Console.Write("Enter choice: ");

                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                    case 2:
                    case 3:
                        Console.Write("Item ID: ");
                        int id = int.Parse(Console.ReadLine());
                        Console.Write("Item Name: ");
                        string name = Console.ReadLine();
                        Console.Write("Quantity: ");
                        int qty = int.Parse(Console.ReadLine());
                        Console.Write("Price: ");
                        double price = double.Parse(Console.ReadLine());

                        Item item = new Item(id, name, qty, price);

                        if (choice == 1)
                            inventory.AddAtBeginning(item);
                        else if (choice == 2)
                            inventory.AddAtEnd(item);
                        else
                        {
                            Console.Write("Position: ");
                            int pos = int.Parse(Console.ReadLine());
                            inventory.AddAtPosition(item, pos);
                        }
                        break;

                    case 4:
                        Console.Write("Item ID: ");
                        inventory.RemoveByItemId(int.Parse(Console.ReadLine()));
                        break;

                    case 5:
                        Console.Write("Item ID: ");
                        int iid = int.Parse(Console.ReadLine());
                        Console.Write("New Quantity: ");
                        inventory.UpdateQuantity(iid, int.Parse(Console.ReadLine()));
                        break;

                    case 6:
                        Console.Write("Item ID: ");
                        inventory.SearchById(int.Parse(Console.ReadLine()));
                        break;

                    case 7:
                        Console.Write("Item Name: ");
                        inventory.SearchByName(Console.ReadLine());
                        break;

                    case 8:
                        inventory.CalculateTotalValue();
                        break;

                    case 9:
                        Console.WriteLine("1. Sort by Name");
                        Console.WriteLine("2. Sort by Price");
                        Console.Write("Choice: ");
                        bool byName = int.Parse(Console.ReadLine()) == 1;

                        Console.WriteLine("1. Ascending");
                        Console.WriteLine("2. Descending");
                        Console.Write("Choice: ");
                        bool ascending = int.Parse(Console.ReadLine()) == 1;

                        inventory.Sort(byName, ascending);
                        break;

                    case 10:
                        inventory.DisplayAll();
                        break;

                    case 0:
                        Console.WriteLine("Exiting...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }

            } while (choice != 0);
        }
    }
}
