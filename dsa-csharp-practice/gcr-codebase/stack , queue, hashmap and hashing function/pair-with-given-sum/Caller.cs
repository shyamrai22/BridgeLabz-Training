using System;

namespace BridgeLabzTraining.dsa_csharp_practice.stack___queue__hashmap_and_hashing_function.pair_with_given_sum
{
    class Caller
    {
        public static void Main(string[] args)
        {
            PairWithGivenSum pair = new PairWithGivenSum();

            int[] arr = { 8, 7, 2, 5, 3, 1 };
            int target = 7;

            pair.CheckingPair(arr, target);
        }
    }
}
