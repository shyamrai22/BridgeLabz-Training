using System;

namespace BridgeLabzTraining.dsa_csharp_practice.stack___queue__hashmap_and_hashing_function.longest_consecutive_sequence
{
    class Caller
    {
        public static void Main(string[] args)
        {
            LongestConsecutiveSequence seq = new LongestConsecutiveSequence();

            int[] nums = { 100, 4, 200, 300, 3, 2 };

            seq.FindLongestSeq(nums);
        }
    }
}
