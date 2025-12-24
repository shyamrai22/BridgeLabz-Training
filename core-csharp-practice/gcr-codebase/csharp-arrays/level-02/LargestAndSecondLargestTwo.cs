using System;


namespace BridgeLabzTraining.arrays.level_02
{
    internal class LargestAndSecondLargestTwo
    {
        public static void CheckLargestAndSecondLargestTwo()
        {
            Console.Write("Enter the number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            
            int maxDig = 10;
            int[] nums = new int[maxDig];
            int idx = 0;

            // Store digits of the number 
            while (num != 0)
            {
                if (idx == maxDig)
                {
                    maxDig += 10;

                    int[] temp = new int[maxDig];

                    for (int i = 0; i < nums.Length; i++)
                    {
                        temp[i] = nums[i];
                    }

                    nums = temp;
                }

                nums[idx] = num % 10;
                num = num / 10;
                idx++;
            }

            int largestDig = 0;
            int secondLargestDig = 0;

            // Finding the result
            for (int i = 0; i < idx; i++)
            {
                if (nums[i] > largestDig)
                {
                    secondLargestDig = largestDig;
                    largestDig = nums[i];
                }
                else if (secondLargestDig < nums[i] && nums[i] != largestDig)
                {
                    secondLargestDig = nums[i];
                }
            }

            // Displaying the results
            Console.WriteLine("Largest digit: " + largestDig);
            Console.WriteLine("Second largest digit: " + secondLargestDig);
        }
    }
}