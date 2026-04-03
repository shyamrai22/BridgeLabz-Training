using System;

namespace BridgeLabzTraining.arrays.level_02
{
    internal class LargestAndSecondLargest
    {
        public static void CheckLargestAndSecondLargest () 
        {
            // Input 
            Console.Write("Enter the number : ");
            string numStr = Console.ReadLine();
            int num = int.Parse(numStr);
            int[] nums = new int[numStr.Length];

            if (numStr.Length < 2)
            {
                Console.WriteLine("Second largest digit does not exist.");
                return;
            }

            for (int i=0; i < numStr.Length; i++) 
            {
                int dig = num % 10;
                nums[i] = dig;
                num = num / 10;

            }
            // Logic to find the largest and second largest element
            int largest = -1;
            int secondLargest = -1;

            for (int i=0;i < numStr.Length; i++) 
            {
                int temp = nums[i];
                if (temp > largest) 
                {
                    secondLargest = largest;
                    largest = temp;
                } 
                else if (temp > secondLargest && temp != largest) 
                {
                    secondLargest = temp;
                }
            }

            // Output
            Console.WriteLine($"Largest element is : {largest}");
            Console.WriteLine($"Second Largest element is : {secondLargest}");
        }
    }
}
