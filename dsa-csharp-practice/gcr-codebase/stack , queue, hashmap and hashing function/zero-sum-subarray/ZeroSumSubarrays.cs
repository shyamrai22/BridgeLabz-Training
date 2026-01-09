using System;
using System.Collections.Generic;

namespace BridgeLabzTraining.dsa_csharp_practice.stack___queue__hashmap_and_hashing_function.zero_sum_subarrays
{
    class ZeroSumSubarrays
    {
        public void FindSubarr(int[] arr)
        {
            Dictionary<int, List<int>> map = new Dictionary<int, List<int>>();
            int sum = 0;
            map[0] = new List<int> { -1 };
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];

                if (map.ContainsKey(sum))
                {
                    foreach (int startIndex in map[sum])
                    {
                        Console.WriteLine("Subarray found from index "
                            + (startIndex + 1) + " to " + i);
                    }
                    map[sum].Add(i);
                }
                else
                {
                    map[sum] = new List<int> { i };
                }
            }
        }
    }
}
