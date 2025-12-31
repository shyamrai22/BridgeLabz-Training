using System;

/*
     * MathematicalOperations Class
     * ---------------------------------------
     * This class provides implementations of common mathematical operations
     * using basic control structures and recursion in C#.
     *
     * Features:
     * - Factorial: Calculates the factorial of a given number using a while loop.
     * - CheckPrime: Determines whether a number is prime by checking its divisors.
     * - GCD: Computes the Greatest Common Divisor (GCD) of two numbers.
     * - Fibonacci: Returns the nth Fibonacci number using recursion.
     *
     * Validations:
     * - Handles invalid inputs such as non-positive numbers where applicable.
     * - Uses conditional checks to ensure logical correctness.
     *
     * Purpose:
     * - Demonstrates loops, conditionals, recursion, and method design
     *   for practicing fundamental problem-solving in C#.
 */


namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.mathematical_operations
{
    internal class MathematicalOperations
    {

        // Method to calculate Factorial of a number
        public void Factorial(int num)
        {
            if(num <= 0)
            {
                Console.WriteLine("Enter valid number");
                return;
            }
            int fact = 1;
            int temp = num;
            while(temp > 0)
            {
                fact *= temp;
                temp--;
            }
            Console.WriteLine($"The factorial of {num}! --> {fact}");
        }

        // Method to check if a number is Prime
        public void CheckPrime(int num)
        {
            if(num <= 1 )
            {
                Console.WriteLine("Not a prime number");
                return;
            }
            for(int i = 2; i*i <= num/2; i++)
            {
                if(num%i == 0)
                {
                    Console.WriteLine("Not a prime number");
                    return;
                }
            }
            Console.WriteLine($"{num} is a prime number");
        }

        // Method to calculate GCD of two numbers
        public void GCD(int num1, int num2)
        {
            if (num1 <= 0 || num2 <= 0)
            {
                Console.WriteLine("Enter valid positive numbers");
                return;
            }
            int gcd = 1;
            for (int i = Math.Min(num1, num2); i >= 1; i--)
            {
                if (num1 % i == 0 && num2 % i == 0)
                {
                    gcd = i;
                    break;
                }
            }
            Console.WriteLine($"GCD of {num1} and {num2} is {gcd}");
        }

        // method to find the nth Fibonacci number
        public int Fibonacci(int n)
        {
            if (n < 0)
            {
                Console.WriteLine("Enter a non-negative number");
                return -1;
            }

            if (n <= 1)
                return n;

            return Fibonacci(n - 1) + Fibonacci(n -2);
        }



    }
}
