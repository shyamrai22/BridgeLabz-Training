using System;
using System.Collections.Generic;

namespace BridgeLabzTraining.dsa_csharp_practice.stack___queue__hashmap_and_hashing_function.queue_using_two_stacks
{
    class QueueUsingTwoStacks
    {
        private Stack<int> stackEn = new Stack<int>();
        private Stack<int> stackDe = new Stack<int>();

        // Enqueue
        public void Enqueue(int data)
        {
            stackEn.Push(data);
            Console.WriteLine($"{data} enqueued");
        }

        // Dequeue
        public int Dequeue()
        {
            if (stackDe.Count == 0)
            {
                if (stackEn.Count == 0)
                {
                    Console.WriteLine("Empty");
                    return -1;
                }

                // Transfer elements to dequeue stack
                while (stackEn.Count > 0)
                {
                    stackDe.Push(stackEn.Pop());
                }
            }

            return stackDe.Pop();
        }
    }
}
