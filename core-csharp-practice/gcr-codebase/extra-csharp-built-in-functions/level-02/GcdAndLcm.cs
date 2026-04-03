using System;

namespace BridgeLabzTraining.extras_csharp_built_in_functions.level_02
{
    class GcdAndLcm
    {
        public static void Caller()
        {
            int n1 = Input("Enter 1st number: ");
            int n2 = Input("Enter 2nd number: ");
            if (n1 <= 0 || n2 <= 0)
            {
                Console.WriteLine("Enter positive numbers only");
                return;
            }
            int gcd = GCD(n1, n2);
            int lcm = LCM(n1, n2, gcd);
            Display(n1, n2, gcd, lcm);
        }

        // Input
        static int Input(string msg)
        {
            Console.Write(msg);
            return int.Parse(Console.ReadLine());
        }

        static int GCD(int a, int b)
        {
            while (b != 0)
            {
                int rem = a % b;
                a = b;
                b = rem;
            }
            return a;
        }

        static int LCM(int a, int b, int gcd)
        {
            return (a * b) / gcd;
        }

        // Output
        static void Display(int a, int b, int gcd, int lcm)
        {
            Console.WriteLine($"GCD : {gcd}");
            Console.WriteLine($"LCM : {lcm}");
        }
    }
}
