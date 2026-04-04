using System;

namespace BridgeLabzTraining.dsa_csharp_practice.stack___queue__hashmap_and_hashing_function.two_sum_problem
{
    class Caller
    {
        public static void Main(string[] args)
        {
            TwoSum twoSum = new TwoSum();
            int[] nums = { 2, 7, 11, 15 };
            int target = 18;
            twoSum.FindIdx(nums, target);
        }
    }
}
