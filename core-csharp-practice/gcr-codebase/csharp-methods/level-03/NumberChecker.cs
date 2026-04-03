using System;

namespace BridgeLabzTraining.methods.level_03
{
    internal class NumberChecker
    {
        // Counting number of digits
        public static int Counting(int num)
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
        public static int[] Storing(int num)
        {
            int cnt = Counting(num);
            int[] digs = new int[cnt];

            int tem = Math.Abs(num);
            for (int i = cnt - 1; i >= 0; i--)
            {
                digs[i] = tem % 10;
                tem /= 10;
            }

            return digs;
        }

        // Check Duck Number
        
        public static bool IsNumber(int[] digs)
        {
            for (int i = 0; i < digs.Length; i++)
            {

                if (digs[i] != 0)
                    return true;
            
            }

            return false;
        }

        // Checking Armstrong Number
        public static bool IsArmstrong(int nums, int[] digs)
        {
            int sum = 0;
            int pow = digs.Length;

            for (int i = 0; i < digs.Length; i++)
            {
                sum += (int)Math.Pow(digs[i], pow);
            }

            return sum == Math.Abs(nums);
        }

        // Finding largest and second-largest digits
        public static int[] LargestAndSecondLargest(int[] digs)
        {
            int l = Int32.MinValue;
            int sl = Int32.MinValue;

            for (int i = 0; i < digs.Length; i++)
            {
                if (digs[i] > l)
                {
                    sl = l;
                    l = digs[i];
                }
                else if (digs[i] > sl && digs[i] != l)
                {
                    sl = digs[i];
                }
            }

            return new int[] { l, sl };
        }

        // Finding smallest and second smallest digits
        public static int[] SmallestAndSecondSmallest(int[] digs)
        {
            int s = Int32.MaxValue;
            int ss = Int32.MaxValue;

            for (int i = 0; i < digs.Length; i++)
            {
                if (digs[i] < s)
                {
                    ss = s;
                    s = digs[i];
                }
                else if (digs[i] < ss && digs[i] != s)
                {
                    ss = digs[i];
                }
            }

            return new int[] { s, ss };
        }

        // Calling above methods
        public static void Caller()
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            int digCount = Counting(num);
            int[] digs = Storing(num);

            Console.WriteLine($"Number of digits: {digCount}");

            Console.Write("Digits: ");

            for (int i = 0; i < digs.Length; i++)
            {
                Console.Write(digs[i] + " ");
            }

            Console.WriteLine();

            Console.WriteLine($"Duck Number: {IsNumber(digs)}");
            Console.WriteLine($"Armstrong Number: {IsArmstrong(num, digs)}");

            int[] l = LargestAndSecondLargest(digs);
            Console.WriteLine($"Largest digit: {l[0]}");
            Console.WriteLine($"Second largest digit: {l[1]}");

            int[] s = SmallestAndSecondSmallest(digs);
            Console.WriteLine($"Smallest digit: {s[0]}");
            Console.WriteLine($"Second smallest digit: {s[1]}");
        }
    }
}
