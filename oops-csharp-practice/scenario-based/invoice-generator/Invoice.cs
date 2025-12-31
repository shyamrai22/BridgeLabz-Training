using System;

/*
     * Invoice Generator Program
     * -------------------------
     * This program generates a simple invoice for freelancers.
     * It takes a single input string containing multiple tasks and their prices.
     *
     * Features:
     * - Splits the input string into individual tasks using commas.
     * - Extracts the amount (in INR) from each task.
     * - Calculates the total invoice amount.
     * - Displays all invoice items along with the total amount.
     *
     * Concepts Used:
     * - Strings and string manipulation
     * - Arrays
     * - Loops (foreach)
     * - Static methods
     *
     * Example Input:
     * "Logo Design - 3000 INR, Web Page - 4500 INR"
     *
     * Output:
     * Displays each task and the total invoice amount.
 */


namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.invoice_generator
{
    public class Invoice
    {
        // Method to parse the input and return an array of tasks
        public static string[] ParseInvoice(string input)
        {
            return input.Split(',');
        }

        // Method to calculate total amount from tasks
        public static int GetTotalAmount(string[] tasks)
        {
            int total = 0;

            foreach (string task in tasks)
            {
                string[] parts = task.Split('-');

                if (parts.Length == 2)
                {
                    string amountPart = parts[1].ToLower();
                    amountPart = amountPart.Replace("inr", "");
                    amountPart = amountPart.Trim();
                    int amount = int.Parse(amountPart);
                    total = total + amount;
                }
            }
            return total;
        }


        // Method to displays invoice details
        public static void DisplayInvoice(string input)
        {
            string[] tasks = ParseInvoice(input);
            int totalAmount = GetTotalAmount(tasks);

            Console.WriteLine("\nInvoice Details:");
            foreach (string task in tasks)
            {
                Console.WriteLine(task.Trim());
            }

            Console.WriteLine($"\nTotal Invoice Amount: {totalAmount} INR");
        }
    }

}
