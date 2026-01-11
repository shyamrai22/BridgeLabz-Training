using System;

namespace BridgeLabzTraining.dsa_csharp_practice.sorting_algorithms
{
    class SortEmployeeIds
    {

        public static void InsertionSort(int[] nums)
        {
            for(int i=1; i<nums.Length; i++)
            {
                int key = nums[i];
                int j = i - 1;

                while(j >= 0 && nums[j] > key)
                {
                    nums[j+1] = nums[j];
                    j--;
                }
                nums[j + 1] = key;
            }
        }

        public static void Main(string[] args)
        {
            Console.Write("Enter the length of the array --> ");
            int n = int.Parse(Console.ReadLine());
            int[] nums = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter number --> ");
                nums[i] = int.Parse(Console.ReadLine());
            }

            InsertionSort(nums);

            Console.WriteLine("Sorted array of marks");
            for (int i = 0; i < n; i++)
            {
                Console.Write(nums[i] + " ");
            }
        }
    }
}
