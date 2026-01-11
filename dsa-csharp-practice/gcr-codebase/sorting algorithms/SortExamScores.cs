using System;

namespace BridgeLabzTraining.dsa_csharp_practice.sorting_algorithms
{
    class SortExamScores
    {
        public static void SelectionSort(int[] arr)
        {
            int n = arr.Length;

            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;

                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[minIndex])
                        minIndex = j;
                }

                int temp = arr[minIndex];
                arr[minIndex] = arr[i];
                arr[i] = temp;
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

            SelectionSort(nums);

            Console.WriteLine("Sorted array of marks");
            for (int i = 0; i < n; i++)
            {
                Console.Write(nums[i] + " ");
            }
        }
    }
}
