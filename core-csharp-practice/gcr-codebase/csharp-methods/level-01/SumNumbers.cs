using System;

namespace BridgeLabzTraining.methods.level_01
{
    internal class SumNumbers
    {
        // Sum
        public static int Sum(int num)
        {
            int sum = 0;

            for (int i = 1; i <= num; i++)
            {
                sum += i;
            }

            return sum;
        }

        // Calling the method
        public static void Caller()
        {
            Console.Write("Enter a value: ");
            int num = Convert.ToInt32(Console.ReadLine());

            int res = Sum(num);

            Console.WriteLine(res);
        }
    }
}
