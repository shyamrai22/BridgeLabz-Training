using System;

namespace BridgeLabzTraining.methods.level_02
{
    internal class NaturalNumbers
    {
        // Sum using recursion
        public static int Recursion(int n)
        {
            if (n == 0)
                return 0;

            return n + Recursion(n - 1);
        }

        // Sum using formula 
        public static int Formula(int n)
        {
            return (n * (n + 1)) / 2;
        }

        // Calling the methods
        public static void Caller()
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            
            if (num <= 0)
            {
                Console.WriteLine("Please enter a valid number");
                return;
            }

            int recursiveSum = Recursion(num);
            int formulaSum = Formula(num);


            Console.WriteLine($"Using recursion: {recursiveSum}");
            Console.WriteLine($"Using formula: {formulaSum}");

            if (recursiveSum == formulaSum)
            {
                Console.WriteLine("Both results are equal");
            }
            else
            {
                Console.WriteLine("Results are not equal");
            }
        }
    }
}
