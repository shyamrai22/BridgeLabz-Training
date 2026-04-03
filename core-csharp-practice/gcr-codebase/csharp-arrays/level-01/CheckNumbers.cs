using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.arrays.level_01
{
    internal class CheckNumbers
    {
        public static void Check()
        {
            //taking input
            Console.WriteLine("Enter 5 numbers:");
            int[] nums = new int[5];
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = Convert.ToInt32(Console.ReadLine());
            }
            //checking for positive, negative and zero
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] < 0) 
                {
                    Console.WriteLine($"Number {nums[i]} is negative");
                }
                else if (nums[i] == 0)
                {
                    Console.WriteLine($"Number {nums[i]} is zero");
                }
                else
                {
                    //checking for odd and even numbers
                    if (nums[i] % 2 == 0) 
                    {
                        Console.WriteLine($"Number {nums[i]} is positive and even");
                    }
                    else 
                    {
                        Console.WriteLine($"Number {nums[i]} is positive and odd");
                    }
                }
            }
            //comparing first and last number of the array nums
            if (nums[0] < nums[nums.Length-1])
            {
                Console.WriteLine($"{nums[0]} is greater");
            }
            else if (nums[0] > nums[nums.Length - 1])
            {
                Console.WriteLine($"{nums[nums.Length - 1]} is greater");
            }
            else
            {
                Console.WriteLine("Both numbers are equal.");
            }

        }
    }
}
