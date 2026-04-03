using System;

namespace BridgeLabzTraining.methods.level_02
{
    internal class Factors
    {
        // Factors
        public static int[] Find(int num)
        {
            int cnt = 0;

            
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    cnt++;
                }
            }

            int[] fac = new int[cnt];
            int idx = 0;

            
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    fac[idx] = i;
                    idx++;
                }
            }

            return fac;
        }

        // Factors sum
        public static int Sum(int[] fac)
        {
            int sum = 0;

            for (int i = 0; i < fac.Length; i++)
            {
                sum += fac[i];
            }

            return sum;
        }

        // Factors product
        public static long Product(int[] fac)
        {
            long p = 1;

            for (int i = 0; i < fac.Length; i++)
            {
                p *= fac[i];
            }

            return p;
        }

        // Factors sum of squares
        public static double SumOfSquares(int[] fac)
        {
            double sumOfSq = 0;

            for (int i = 0; i < fac.Length; i++)
            {
                sumOfSq += Math.Pow(fac[i], 2);
            }

            return sumOfSq;
        }

        // Calling the methods
        public static void Caller()
        {

            Console.Write("Enter number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            int[] fac = Find(num);

            for (int i = 0; i < fac.Length; i++)
            {
                Console.Write(fac[i] + " ");
            }
            Console.WriteLine();

            int sum = Sum(fac);
            long p = Product(fac);
            double sumOfSq = SumOfSquares(fac);

            Console.WriteLine($"Sum : {sum}");
            Console.WriteLine($"Product : {p}");
            Console.WriteLine($"Sum of squares : {sumOfSq}");
        }
    }
}
