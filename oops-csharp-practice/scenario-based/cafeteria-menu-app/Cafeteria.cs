using System;

/*
    Class: Cafeteria

    This class handles the core functionality of the Cafeteria Menu App.
    It is responsible for displaying the available menu items and returning
    a selected item based on the user-provided index.

    Responsibilities:
    - Display the cafeteria menu with index numbers using DisplayMenu().
    - Validate the selected index and return the corresponding item using GetItemByIndex().
    - Prevent invalid access by checking array boundaries.

    Concepts Used:
    Arrays, Methods, Loops, Conditional Statements, and Encapsulation.
*/


namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.cafeteria_menu_app
{
    class Cafeteria
    {

        // Method to display the menu
        public void DisplayMenu(string[] items)
        {
            Console.WriteLine("======== Cafeteria Menu ========");
            for (int i = 0; i < items.Length; i++)
            {
                Console.WriteLine($"{i} : {items[i]}");
            }
        }

        // Method to get item by index
        public string GetItemByIndex(string[] orders, int idx)
        {
            if (idx >= 0 && idx < orders.Length)
                return orders[idx];

            return null;
        }
    }

}
