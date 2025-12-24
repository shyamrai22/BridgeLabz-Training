using System;

namespace BridgeLabzTraining.arrays.level_02
{
    internal class Frequency
    {
        public static void NumberFrequency()
        {
            // Input

            Console.WriteLine("Enter a number : ");
            int a = Convert.ToInt32(Console.ReadLine());

            int[] nums = new int[10];
            int idx = 0;

            while (a > 0)
            {
                int dig = a % 10;
                nums[idx] = dig;
                a = a / 10;
                idx++;
            }
         
            int[] frequency = new int[idx];

            for (int i = 0; i < idx; i++)
            {
                bool counted = false;

                for (int k = 0; k < i; k++)
                {
                    if (nums[i] == nums[k])
                    {
                        counted = true;
                        break;
                    }
                }
                if (counted) continue;
                
                int cnt = 0;


                for (int j = 0; j < idx; j++)
                {
                    if (nums[i] == nums[j])
                    {
                        cnt++;
                    }
                }

                frequency[i] = cnt;

                Console.WriteLine($"digit : {nums[i]} | {frequency[i]} times");
            
            }
        }
    }
}