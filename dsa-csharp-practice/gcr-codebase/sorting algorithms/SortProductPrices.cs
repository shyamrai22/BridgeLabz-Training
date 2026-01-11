using System;

namespace BridgeLabzTraining.dsa_csharp_practice.sorting_algorithms
{
    class SortProductPrices
    {
        public static void QuickSort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int pivotIndex = Partition(arr, low, high);

                QuickSort(arr, low, pivotIndex - 1);
                QuickSort(arr, pivotIndex + 1, high);
            }
        }

        static int Partition(int[] arr, int low, int high)
        {
            int pivot = arr[high];
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            int t = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = t;

            return i + 1;
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

            QuickSort(nums, 0, nums.Length - 1);

            Console.WriteLine("Sorted array of marks");
            for (int i = 0; i < n; i++)
            {
                Console.Write(nums[i] + " ");
            }
        }
    }
}
