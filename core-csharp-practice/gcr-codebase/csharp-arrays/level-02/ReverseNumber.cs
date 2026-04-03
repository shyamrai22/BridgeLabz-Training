using System;

namespace BridgeLabzTraining.arrays.level_02
{
    internal class ReverseNumber
    {
        public static void ReverseNum()
        {
            Console.Write("Enter a number to reverse: ");
            string numStr = Console.ReadLine();
            int number = Convert.ToInt32(numStr);
            int[] nums = new int[numStr.Length];
            int idx = 0;
            while (number > 0)
            {
                int digit = number % 10;
                nums[idx++] = digit;
                number /= 10;
            }
            Console.Write("Reversed number: ");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write(nums[i]);
            }

        }
    }
}
