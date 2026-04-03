using System;

namespace BridgeLabzTraining.methods.level_03
{
    internal class NumberCheckerTwo
    {
        // Counting number of digits
        public static int Count(int num)
        {
            int cnt = 0;
            int tem = Math.Abs(num);

            if (tem == 0)
                return 1;

            while (tem > 0)
            {
                cnt++;
                tem /= 10;
            }

            return cnt;
        }

        // Storing digits in an array
        public static int[] Store(int num)
        {
            int cnt = Count(num);
            int[] digs = new int[cnt];

            int tem = Math.Abs(num);
            for (int i = cnt - 1; i >= 0; i--)
            {
                digs[i] = tem % 10;
                tem /= 10;
            }

            return digs;
        }

        // Sum of digits
        public static int Sum(int[] digs)
        {
            int sum = 0;

            for (int i = 0; i < digs.Length; i++)
            {
                sum += digs[i];
            }

            return sum;
        }

        // Sum of squares of digits
        public static double SumOfSquares(int[] digs)
        {
            double sumSq = 0;

            for (int i = 0; i < digs.Length; i++)
            {
                sumSq += Math.Pow(digs[i], 2);
            }

            return sumSq;
        }

        // Check Harshad number
        public static bool HarshadNumber(int num, int[] digs)
        {
            int sum = Sum(digs);

            if (sum == 0)
                return false;

            return Math.Abs(num) % sum == 0;
        }

        // Frequency of each digit
        public static int[,] Frequency(int[] digs)
        {
            int[,] frequency = new int[10, 2];

            
            for (int i = 0; i < 10; i++)
            {
                frequency[i, 0] = i;
                frequency[i, 1] = 0;
            }

            
            for (int i = 0; i < digs.Length; i++)
            {
                frequency[digs[i], 1]++;
            }

            return frequency;
        }

        // Calling above methods
        public static void Caller()
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            int cnt = Count(num);
            int[] digs = Store(num);

            Console.WriteLine($"Number of digits: {cnt}");

            Console.Write("Digits: ");
            for (int i = 0; i < digs.Length; i++)
            {
                Console.Write(digs[i] + " ");
            }
            Console.WriteLine();

            int sum = Sum(digs);
            double sumSq = SumOfSquares(digs);

            Console.WriteLine($"Sum of digits: {sum}");
            Console.WriteLine($"Sum of squares of digits: {sumSq}");
            Console.WriteLine($"Harshad Number: {HarshadNumber(num, digs)}");

            int[,] frequency = Frequency(digs);

            Console.WriteLine("Digit Frequency:");
            for (int i = 0; i < 10; i++)
            {
                if (frequency[i, 1] > 0)
                {
                    Console.WriteLine($"Digit {frequency[i, 0]} : {frequency[i, 1]}");
                }
            }

        }
    }
}
