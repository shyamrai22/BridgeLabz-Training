using System;

namespace BridgeLabzTraining.methods.level_03
{
    internal class NumberCheckerThree
    {
        // Counting number of digits
        public static int Counts(int num)
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
            int cnt = Counts(num);
            int[] digs = new int[cnt];

            int tem = Math.Abs(num);
            for (int i = cnt - 1; i >= 0; i--)
            {
                digs[i] = tem % 10;
                tem /= 10;
            }

            return digs;
        }

        // Reversing the digit's array
        public static int[] ArrayReverse(int[] dig)
        {
            int[] rev = new int[dig.Length];

            for (int i = 0; i < dig.Length; i++)
            {
                rev[i] = dig[dig.Length - 1 - i];
            }

            return rev;
        }

        // Comparing two arrays
        public static bool Comparison(int[] nums1, int[] nums2)
        {
            if (nums1.Length != nums2.Length)
                return false;

            for (int i = 0; i < nums1.Length; i++)
            {
                if (nums1[i] != nums2[i])
                    return false;
            }

            return true;
        }

        // Checking Palindrome number
        public static bool Palindrome(int[] digs)
        {
            int[] rev = ArrayReverse(digs);
            return Comparison(digs, rev);
        }

        // Checking Duck Number
        public static bool DuckNumber(int[] digs)
        {

            for (int i = 0; i < digs.Length; i++)
            {
                if (digs[i] != 0)
                    return true;
            }

            return false;
        
        }

        // Calling above methods
        public static void Caller()
        {
            Console.Write("Enter the number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            int cnt = Counts(num);
            int[] digs = Storing(num);

            Console.WriteLine($"Number of digits: {cnt}");
            Console.Write("Digits: ");

            for (int i = 0; i < digs.Length; i++)
            {
                Console.Write(digs[i] + " ");
            }
            Console.WriteLine();

            int[] rev = ArrayReverse(digs);
            Console.Write("Reversed Digits: ");

            for (int i = 0; i < rev.Length; i++)
            {
                Console.Write(rev[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine($"Palindrome Number: {Palindrome(digs)}");
            Console.WriteLine($"Duck Number: {DuckNumber(digs)}");

        }
    }
}
