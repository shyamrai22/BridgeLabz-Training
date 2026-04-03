using System;

namespace BridgeLabzTraining.extras_csharp_built_in_functions.level_02
{
    class CheckForPrime
    {
        public static void Caller()
        {
            int n = Input("Enter a num: ");
            bool prime = CheckingPrimeNum(n);

            if (prime)
                Console.WriteLine("Prime number");
            else
                Console.WriteLine("Not a Prime number");
        }

        // Input
        static int Input(string msg)
        {
            Console.Write(msg);
            return int.Parse(Console.ReadLine());
        }

        static bool CheckingPrimeNum(int n)
        {
            if (n <= 1)
                return false;

            for (int i = 2; i <= n / 2; i++)
            {
                if (n % i == 0)
                    return false;
            }

            return true;
        }
    }
}
