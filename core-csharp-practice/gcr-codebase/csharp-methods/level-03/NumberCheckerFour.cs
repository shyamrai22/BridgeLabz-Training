using System;

namespace BridgeLabzTraining.methods.level_03
{
    internal class NumberCheckerFour
    {
        // Checking Prime Number
        public static bool Prime(int n)
        {
            if (n <= 1)
                return false;

            for (int i = 2; i <= Math.Sqrt(n); i++)
            {

                if (n % i == 0)
                    return false;
            
            }

            return true;
        }

        // Checking Neon Number
        public static bool Neon(int n)
        {
            int sq = n * n;
            int sum = 0;

            while (sq > 0)
            {
                sum += sq % 10;
                sq /= 10;
            }

            return sum == n;
        }

        // Checking Spy Number
        public static bool Spy(int num)
        {
            int tem = Math.Abs(num);
            int sum = 0;
            int product = 1;

            while (tem > 0)
            {
                int dig = tem % 10;
                sum += dig;
                product *= dig;
                tem /= 10;
            }

            return sum == product;
        }

        // Checking Automorphic Number
        public static bool Automorphic(int n)
        {
            int sq = n * n;
            int tem = Math.Abs(n);

            while (tem > 0)
            {
                if (sq % 10 != tem % 10)
                    return false;


                sq /= 10;
                tem /= 10;

            }

            return true;

        }

        // Checking Buzz Number
        public static bool Buzz(int n)
        {
            return (n % 7 == 0) || (Math.Abs(n) % 10 == 7);
        }

        // Calling above methods
        public static void Caller()
        {
            Console.Write("Enter a number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Prime Number : {Prime(n)}");
            Console.WriteLine($"Neon Number : {Neon(n)}");
            Console.WriteLine($"Spy Number : {Spy(n)}");
            Console.WriteLine($"Automorphic Number : {Automorphic(n)}");
            Console.WriteLine($"Buzz Number : {Buzz(n)}");
        }
    }
}
