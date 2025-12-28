using System;

namespace BridgeLabzTraining.extras_csharp_built_in_functions.level_02
{
    class Factorial
    {
        public static void Caller()
        {
            int n = Input("Enter a number: ");

            if (n < 0)
            {
                Console.WriteLine("Negative numbers");
                return;
            }

            long factorial = Calculate(n);
            Display(n, factorial);
        }

        // Input
        static int Input(string msg)
        {
            Console.Write(msg);
            return int.Parse(Console.ReadLine());
        }

        static long Calculate(int n)
        {
            if (n == 0 || n == 1)
                return 1;

            return n * Calculate(n - 1);
        }

        // Output
        static void Display(int n, long result)
        {
            Console.WriteLine($"Factorial of {n} is: {result}");
        }
    }
}
