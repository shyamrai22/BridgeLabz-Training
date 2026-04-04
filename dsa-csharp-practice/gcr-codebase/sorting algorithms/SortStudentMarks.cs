using System;

namespace BridgeLabzTraining.dsa_csharp_practice.sorting_algorithms
{
    class SortStudentMarks
    {
        public static void BubbleSort(int[] nums)
        {
            for(int i=0; i<nums.Length-1; i++)
            {
                for(int j=0; j<nums.Length-i-1; j++)
                {
                    if (nums[j] < nums[j+1])
                    {
                        int temp = nums[j+1];
                        nums[j+1] = nums[j];
                        nums[j] = temp;
                    }
                }
            }
        }

        public static void Main(string[] args)
        {
            Console.Write("Enter the length of the array --> ");
            int n = int.Parse(Console.ReadLine());
            int[] nums = new int[n];
            for(int i=0; i<n; i++)
            {
                Console.Write("Enter number --> ");
                nums[i] = int.Parse(Console.ReadLine());
            }

            BubbleSort(nums);

            Console.WriteLine("Sorted array of marks");
            for(int i=0; i<n; i++)
            {
                Console.Write(nums[i] + " ");
            }
        }
    }
}
