/// <summary>
/// Implements a smart checkout counter system using a queue to manage customers.
/// Maintains item prices and stock, allows customers to select items, processes
/// customers in FIFO order, calculates total bills, and displays available item prices.
/// </summary>


using System;
using System.Collections.Generic;

class CheckoutCounterUtility : ICheckout
{
    private Dictionary<string, int> itemPrices;
    private Dictionary<string, int> itemStock;

    private Queue<List<string>> customers;

    public CheckoutCounterUtility()
    {
        itemPrices = new Dictionary<string, int>
        {
            { "bread", 30 },
            { "butter", 10 },
            { "jam", 50 },
            { "coldrink", 100 },
            { "chips", 20 }
        };

        itemStock = new Dictionary<string, int>
        {
            { "bread", 10 },
            { "butter", 10 },
            { "jam", 10 },
            { "coldrink", 10 },
            { "chips", 10 }
        };

        customers = new Queue<List<string>>();
    }

    public void AddACustomer()
    {
        bool isAddingItems = true;
        List<string> selectedItems = new List<string>();

        while (isAddingItems)
        {
            Console.WriteLine("\nAvailable Items:");
            foreach (var item in itemStock)
            {
                if (item.Value > 0)
                {
                    Console.WriteLine($"- {item.Key}");
                }
            }

            Console.WriteLine("\n1. Choose Item");
            Console.WriteLine("2. Stop Choosing");

            if (!int.TryParse(Console.ReadLine(), out int option))
            {
                Console.WriteLine("Invalid input!");
                continue;
            }

            switch (option)
            {
                case 1:
                    Console.Write("Enter item name: ");
                    string itemName = Console.ReadLine()?.ToLower();

                    if (!itemPrices.ContainsKey(itemName))
                    {
                        Console.WriteLine("Item not found!");
                        break;
                    }

                    if (itemStock[itemName] <= 0)
                    {
                        Console.WriteLine("Item out of stock!");
                        break;
                    }

                    selectedItems.Add(itemName);
                    itemStock[itemName]--;
                    Console.WriteLine($"{itemName} added to cart.");
                    break;

                case 2:
                    isAddingItems = false;
                    Console.WriteLine("Order submitted.\n");
                    break;

                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }
        }

        if (selectedItems.Count == 0)
        {
            Console.WriteLine("Customer must select at least one item.");
            return;
        }

        customers.Enqueue(selectedItems);
        Console.WriteLine("Customer added to the queue.\n");
    }

    public void RemoveCustomer()
    {
        if (customers.Count == 0)
        {
            Console.WriteLine("No customers in queue.\n");
            return;
        }

        int totalBill = 0;
        List<string> customerItems = customers.Dequeue();

        foreach (string item in customerItems)
        {
            totalBill += itemPrices[item];
        }

        Console.WriteLine("Customer removed from the queue.");
        Console.WriteLine($"Total Bill Amount: {totalBill}\n");
    }

    public void FetchItemPrice()
    {
        Console.WriteLine("\nItem Prices:");
        foreach (var item in itemPrices)
        {
            Console.WriteLine($"{item.Key} : ₹{item.Value}");
        }
        Console.WriteLine();
    }
}
