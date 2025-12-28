using System;

namespace BridgeLabzTraining.extras_csharp_built_in_functions.level_02
{
    class FibonacciGenerator
    {
        public static void Caller()
        {
            int num = Input("Enter number of terms: ");

            if (num <= 0)
            {
                Console.WriteLine("Enter a positive number");
                return;
            }
            FibonacciGeneration(num);
        }

        // Input
        static int Input(string msg)
        {
            Console.Write(msg);
            return int.Parse(Console.ReadLine());
        }

        static void FibonacciGeneration(int num)
        {
            int a = 0, b = 1;

            Console.WriteLine("Sequence:");

            for (int i = 1; i <= num; i++)
            {
                Console.Write(a + " ");
                int nxt = a + b;
                a = b;
                b = nxt;
            }
            Console.WriteLine();
        }
    }
}
