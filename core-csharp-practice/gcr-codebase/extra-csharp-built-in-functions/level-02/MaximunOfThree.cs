using System;

namespace BridgeLabzTraining.extras_csharp_built_in_functions.level_02
{
    class MaximumOfThree
    {
        public static void Caller()
        {
            int num1 = Input("Enter 1st number: ");
            int num2 = Input("Enter 2nd number: ");
            int num3 = Input("Enter 3rd number: ");

            int maximum = FindMax(num1, num2, num3);

            Console.WriteLine($"Maximum number is: {maximum}");
        }

        // Input
        static int Input(string message)
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine());
        }

        static int FindMax(int x, int y, int z)
        {
            int max = x;

            if (y > max)
                max = y;

            if (z > max)
                max = z;

            return max;
        }
    }
}
