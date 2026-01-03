using System;

/*
    Scenario: Cafeteria Menu App

    This program simulates a simple cafeteria ordering system where a fixed list of
    menu items is stored in an array. The menu is displayed with index numbers, and
    the user places an order by selecting an item using its index.

    Features:
    - Stores cafeteria items in a string array.
    - Displays the menu using a separate Cafeteria class.
    - Accepts user input to select an item by index.
    - Retrieves the selected item using a method.
    - Handles invalid index selection gracefully.

    Concepts Used:
    Arrays, Classes, Methods, User Input, and Conditional Statements.
*/


namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.cafeteria_menu_app
{
    internal class Caller
    {
        static void Main(string[] args)
        {
            // Array to store cafeteria items
            string[] cafeteriaMenu =    {
                                            "Sandwich",
                                            "Burger",
                                            "Pizza Slice",
                                            "Veg Puff",
                                            "Samosa",
                                            "French Fries",
                                            "Noodles",
                                            "Fried Rice",
                                            "Pasta",
                                            "Coffee"
                                        };

            Cafeteria cafeteria = new Cafeteria();

            // Display menu
            cafeteria.DisplayMenu(cafeteriaMenu);

            // Take user input
            Console.WriteLine();
            Console.Write("Enter item index to order -->  ");
            int index = int.Parse(Console.ReadLine());

            // Get item by index
            string selectedOrder = cafeteria.GetItemByIndex(cafeteriaMenu, index);

            if (selectedOrder != null)
                Console.WriteLine($"You ordered: {selectedOrder}");
            else
                Console.WriteLine("Invalid index!");
        }
    }
}
