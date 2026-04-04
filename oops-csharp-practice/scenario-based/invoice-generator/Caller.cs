using System;

/*
     * Caller Class (Entry Point)
     * --------------------------
     * This class acts as the entry point of the Invoice Generator application.
     * It provides a menu-driven console interface for the user.
     *
     * Features:
     * - Displays a menu with options to generate an invoice or exit.
     * - Accepts user input for invoice details.
     * - Calls the Invoice class to process and display invoice information.
     * - Uses a loop to allow repeated operations until the user exits.
     *
     * Concepts Used:
     * - Main method as program entry point
     * - while loop for menu repetition
     * - switch-case for menu handling
     * - Console input and output
 */


namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.invoice_generator
{
    class Caller
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n==============================");
                Console.WriteLine(" Freelancer Invoice Generator ");
                Console.WriteLine("==============================");
                Console.WriteLine("1. Generate Invoice");
                Console.WriteLine("2. Exit");
                Console.Write("Enter your choice: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("\nEnter invoice details: ");
                        Console.WriteLine("(Example: Logo Design - 3000 INR, Web Page - 4500 INR)");
                        string input = Console.ReadLine();

                        Invoice.DisplayInvoice(input);
                        break;

                    case "2":
                        Console.WriteLine("Exiting application...");
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }

}
