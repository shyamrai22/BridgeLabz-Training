/// <summary>
/// Provides a menu-driven interface for the smart checkout system.
/// Handles user interactions and delegates operations such as adding customers,
/// removing customers, and viewing item prices to the checkout implementation.
/// </summary>


using System;

class CheckoutCounterMenu
{
    private ICheckout checkoutSystem;

    public void CheckoutMenu()
    {
        checkoutSystem = new CheckoutCounterUtility();
        bool isRunning = true;

        while (isRunning)
        {
            Console.WriteLine("===== Checkout Counter Menu =====");
            Console.WriteLine("1. Add a customer");
            Console.WriteLine("2. Remove a customer");
            Console.WriteLine("3. View item prices");
            Console.WriteLine("4. Exit");

            Console.Write("Enter your choice: ");

            if (!int.TryParse(Console.ReadLine(), out int option))
            {
                Console.WriteLine("Invalid input!\n");
                continue;
            }

            switch (option)
            {
                case 1:
                    checkoutSystem.AddACustomer();
                    break;

                case 2:
                    checkoutSystem.RemoveCustomer();
                    break;

                case 3:
                    checkoutSystem.FetchItemPrice();
                    break;

                case 4:
                    isRunning = false;
                    Console.WriteLine("Exiting system...");
                    break;

                default:
                    Console.WriteLine("Invalid choice!\n");
                    break;
            }
        }
    }
}
