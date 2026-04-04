using System;

namespace BridgeLabzTraining.dsa_csharp_practice.sorting_algorithms
{
    class SortJobApplicationBySalary
    {
        public static void HeapSort(int[] arr)
        {
            int n = arr.Length;

            for (int i = n / 2 - 1; i >= 0; i--)
                Heapify(arr, n, i);

            for (int i = n - 1; i > 0; i--)
            {
                int temp = arr[0];
                arr[0] = arr[i];
                arr[i] = temp;

                Heapify(arr, i, 0);
            }
        }

        public static void Heapify(int[] nums, int n, int i)
        {
            int biggest = i;
            int l = 2 * i + 1;
            int r = 2 * i + 2;

            if (l < n && nums[l] > nums[biggest])
                biggest = l;

            if (r < n && nums[r] > nums[biggest])
                biggest = r;

            if (biggest != i)
            {
                int swap = nums[i];
                nums[i] = nums[biggest];
                nums[biggest] = swap;

                Heapify(nums, n, biggest);
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

            HeapSort(nums);

            Console.WriteLine("Sorted array of marks");
            for (int i = 0; i < n; i++)
            {
                Console.Write(nums[i] + " ");
            }
        }
    }
}
