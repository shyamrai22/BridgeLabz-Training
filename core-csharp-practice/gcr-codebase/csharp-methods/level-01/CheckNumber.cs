using System;

namespace BridgeLabzTraining.methods.level_01
{
    internal class CheckNumber
    {
        // Check number status
        public static int CheckNum(int num)
        {
            if (num > 0)
                return 1;
            else if (num < 0)
                return -1;
            else
                return 0;
        }

        // Calling the method
        public static void Caller()
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            int res = CheckNum(num);

            if (res == 1)
                Console.WriteLine("Positive");

            else if (res == -1)
                Console.WriteLine("Negative");
            
            else
                Console.WriteLine("Zero");
        }
    }
}
