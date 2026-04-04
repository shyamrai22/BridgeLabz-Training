using System;
using System.Collections.Generic;

namespace BridgeLabzTraining.dsa_csharp_practice.stack___queue__hashmap_and_hashing_function.pair_with_given_sum
{
    class PairWithGivenSum
    {
        public void CheckingPair(int[] nums, int target)
        {
            Dictionary<int, bool> map = new Dictionary<int, bool>();
            for (int i = 0; i < nums.Length; i++)
            {
                int required = target - nums[i];
                if (map.ContainsKey(required))
                {
                    Console.WriteLine("Pair found --> "
                        + required + " + " + nums[i] + " = " + target);
                    return;
                }
                if (!map.ContainsKey(nums[i]))
                {
                    map[nums[i]] = true;
                }
            }
            Console.WriteLine("No pair");
        }
    }
}
