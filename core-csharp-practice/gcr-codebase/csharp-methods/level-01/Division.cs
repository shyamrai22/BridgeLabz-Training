using System;

namespace BridgeLabzTraining.methods.level_01
{
    internal class Division
    {
        // Find remainder and quotient
        public static int[] FindRemainderAndQuotient(int num, int div)
        {
            int q = num / div;
            int r = num % div;

            return new int[] { q, r };
        }

        // Calling the method
        public static void Caller()
        {
            Console.Write("Enter the number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the divisor: ");
            int div = Convert.ToInt32(Console.ReadLine());

            int[] res = FindRemainderAndQuotient(num, div);

            Console.WriteLine($"Quotient : {res[0]}");
            Console.WriteLine($"Remainder : {res[1]}");
        }
    }
}
