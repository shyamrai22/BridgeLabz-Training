using System;
using System.Collections.Generic;

namespace BridgeLabzTraining.dsa_csharp_practice.stack___queue__hashmap_and_hashing_function.longest_consecutive_sequence
{
    class LongestConsecutiveSequence
    {
        public void FindLongestSeq(int[] nums)
        {
            HashSet<int> set = new HashSet<int>();

            foreach (int num in nums)
            {
                set.Add(num);
            }
            int longest = 0;
            foreach (int num in set)
            {
                if (!set.Contains(num - 1))
                {
                    int currNum = num;
                    int cnt = 1;
                    while (set.Contains(currNum + 1))
                    {
                        currNum++;
                        cnt++;
                    }
                    if (cnt > longest)
                    {
                        longest = cnt;
                    }
                }
            }
            Console.WriteLine($"Longest consecutive length --> {longest}");
        }
    }
}
