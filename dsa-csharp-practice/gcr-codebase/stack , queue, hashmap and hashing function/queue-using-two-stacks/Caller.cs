using System;

namespace BridgeLabzTraining.dsa_csharp_practice.stack___queue__hashmap_and_hashing_function.queue_using_two_stacks
{
    class Caller
    {
        public static void Main(string[] args)
        {
            QueueUsingTwoStacks queue = new QueueUsingTwoStacks();

            queue.Enqueue(11);
            queue.Enqueue(12);
            queue.Enqueue(13);

            Console.WriteLine("Dequeued --> " + queue.Dequeue());
            Console.WriteLine("Dequeued --> " + queue.Dequeue());

            queue.Enqueue(14);

            Console.WriteLine("Dequeued --> " + queue.Dequeue());
            Console.WriteLine("Dequeued --> " + queue.Dequeue());
        }
    }
}
