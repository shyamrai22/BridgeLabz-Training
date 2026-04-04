using System;

namespace BridgeLabzTraining.dsa_csharp_practice.stack___queue__hashmap_and_hashing_function.zero_sum_subarrays
{
    class Caller
    {
        public static void Main(string[] args)
        {
            ZeroSumSubarrays zeroSum = new ZeroSumSubarrays();

            int[] arr = { 3, 4, -7, 3, 1, 3, -4, -2, -2 };

            zeroSum.FindSubarr(arr);
        }
    }
}
