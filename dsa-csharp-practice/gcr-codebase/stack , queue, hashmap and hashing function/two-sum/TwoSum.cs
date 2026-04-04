using System;
using System.Collections.Generic;

namespace BridgeLabzTraining.dsa_csharp_practice.stack___queue__hashmap_and_hashing_function.two_sum_problem
{
    class TwoSum
    {
        public void FindIdx(int[] nums, int target)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int req = target - nums[i];
                if (map.ContainsKey(req))
                {
                    Console.WriteLine("Indices found --> "
                        + map[req] + " and " + i);
                    return;
                }
                if (!map.ContainsKey(nums[i]))
                {
                    map[nums[i]] = i;
                }
            }
            Console.WriteLine("No indices found");
        }
    }
}
