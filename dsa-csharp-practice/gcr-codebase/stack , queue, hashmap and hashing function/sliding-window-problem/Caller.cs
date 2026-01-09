using System;

namespace BridgeLabzTraining.dsa_csharp_practice.stack___queue__hashmap_and_hashing_function.sliding_window_maximum
{
    class Caller
    {
        public static void Main(string[] args)
        {
            SlidingWindowMaximum swm = new SlidingWindowMaximum();

            int[] arr = { 1, 3, -1, -3, 5, 3, 6, 7 };
            int k = 3;

            swm.FindMax(arr, k);
        }
    }
}
