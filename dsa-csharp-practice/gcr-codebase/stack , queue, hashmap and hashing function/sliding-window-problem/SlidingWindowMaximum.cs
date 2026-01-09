using System;
using System.Collections.Generic;

namespace BridgeLabzTraining.dsa_csharp_practice.stack___queue__hashmap_and_hashing_function.sliding_window_maximum
{
    class SlidingWindowMaximum
    {
        public void FindMax(int[] arr, int j)
        {
            int n = arr.Length;
            LinkedList<int> queue = new LinkedList<int>();

            for (int i = 0; i < n; i++)
            {
                if (queue.Count > 0 && queue.First.Value <= i - j)
                {
                    queue.RemoveFirst();
                }

                while (queue.Count > 0 && arr[queue.Last.Value] <= arr[i])
                {
                    queue.RemoveLast();
                }

                queue.AddLast(i);

                if (i >= j - 1)
                {
                    Console.WriteLine($"Max --> {arr[queue.First.Value]}");
                }
            }
        }
    }
}
