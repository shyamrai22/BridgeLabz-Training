using System;

namespace BridgeLabzTraining.dsa_csharp_practice.sorting_algorithms
{
    class SortStudentAge
    {
        public static void CountingSort(int[] ages)
        {
            int max = ages[0];

            for (int i = 1; i < ages.Length; i++)
            {
                if (ages[i] > max)
                {
                    max = ages[i];
                }
            }
            int[] cnt = new int[max + 1];

            for (int i = 0; i < ages.Length; i++)
            {
                cnt[ages[i]]++;
            }

            int idx = 0;
            
            for (int i = 0; i < cnt.Length; i++)
            {
                while (cnt[i] > 0)
                {
                    ages[idx++] = i;
                    cnt[i]--;
                }
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

            CountingSort(nums);

            Console.WriteLine("Sorted array of marks");
            for (int i = 0; i < n; i++)
            {
                Console.Write(nums[i] + " ");
            }
        }
    }
}
