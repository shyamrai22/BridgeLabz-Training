using System;

/*
 * Caller Class – Mathematical Operations
 * ---------------------------------------
 * This class serves as the entry point for the Mathematical Operations program.
 *
 * Responsibilities:
 * - Displays a menu-driven interface for multiple mathematical operations.
 * - Accepts user input and routes execution to the appropriate method
 *   in the MathematicalOperations class.
 *
 * Supported Operations:
 * - Factorial calculation
 * - Prime number checking
 * - Greatest Common Divisor (GCD)
 * - Fibonacci number calculation
 *
 * Program Flow:
 * - Runs in a loop until the user chooses to exit.
 * - Uses switch-case for clean decision handling.
 * - Displays results directly to the console.
 *
 * Purpose:
 * - Demonstrates menu-driven programming, method invocation,
 *   and user interaction in C#.
 */


namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.mathematical_operations
{
    internal class Caller
    {
        public static void Main(string[] args)
        {
            MathematicalOperations ops = new MathematicalOperations();
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\n===============================");
                Console.WriteLine(" Mathematical Operations Menu ");
                Console.WriteLine("===============================");
                Console.WriteLine("1. Factorial");
                Console.WriteLine("2. Check Prime");
                Console.WriteLine("3. GCD");
                Console.WriteLine("4. Fibonacci");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter a number: ");
                        int factNum = int.Parse(Console.ReadLine());
                        ops.Factorial(factNum);
                        break;

                    case 2:
                        Console.Write("Enter a number: ");
                        int primeNum = int.Parse(Console.ReadLine());
                        ops.CheckPrime(primeNum);
                        break;

                    case 3:
                        Console.Write("Enter first number: ");
                        int num1 = int.Parse(Console.ReadLine());
                        Console.Write("Enter second number: ");
                        int num2 = int.Parse(Console.ReadLine());
                        ops.GCD(num1, num2);
                        break;

                    case 4:
                        Console.Write("Enter n: ");
                        int n = int.Parse(Console.ReadLine());
                        int fib = ops.Fibonacci(n);
                        Console.WriteLine($"Fibonacci({n}) --> {fib}");
                        break;

                    case 5:
                        exit = true;
                        Console.WriteLine("Exiting program...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice! Try again.");
                        break;
                }
            }
        }
    }
}
