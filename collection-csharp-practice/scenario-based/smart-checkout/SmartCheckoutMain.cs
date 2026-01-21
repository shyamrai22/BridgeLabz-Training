/// <summary>
/// Entry point of the Smart Checkout application.
/// Initializes the checkout menu and starts the menu-driven checkout system.
/// </summary>


using System;

class SmartCheckoutMain
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to checkout system.");
        CheckoutCounterMenu menu = new CheckoutCounterMenu();
        menu.CheckoutMenu();
    }
}

