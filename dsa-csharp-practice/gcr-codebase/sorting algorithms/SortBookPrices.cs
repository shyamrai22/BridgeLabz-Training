using System;

namespace BridgeLabzTraining.dsa_csharp_practice.sorting_algorithms
{
    class SortBookPrices
    {
        public static void MergeSort(int[] bookPrices, int left, int right)
        {
            if(left < right)
            {
                int mid = (left + right) / 2;
                MergeSort(bookPrices, left, mid);
                MergeSort(bookPrices, mid+1, right);

                Merge(bookPrices, left, mid, right);
            }
        }

        public static void Merge(int[] bookPrices, int left, int mid, int right)
        {
            int n1 = mid - left + 1;
            int n2 = right - mid;

            int[] l = new int[n1];
            int[] r = new int[n2];

            for(int i=0; i<n1; i++)
            {
                l[i] = bookPrices[left + i];
            }

            for(int i=0; i<n2; i++)
            {
                r[i] = bookPrices[i+mid+1];
            }

            int lIndex = 0, rIndex = 0, idx = left;

            while(lIndex < l.Length && rIndex < r.Length)
            {
                if (l[lIndex] <= r[rIndex])
                {
                    bookPrices[idx++] = l[lIndex++];
                }
                else
                {
                    bookPrices[idx++] = r[rIndex++];
                }
            }
            while(lIndex < n1)
            {
                bookPrices[idx++] = l[lIndex++];
            }
            while(rIndex < n2)
            {
                bookPrices[idx++] = r[rIndex++];
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

            MergeSort(nums, 0, nums.Length-1);

            Console.WriteLine("Sorted array of marks");
            for (int i = 0; i < n; i++)
            {
                Console.Write(nums[i] + " ");
            }
        }
    }
}
