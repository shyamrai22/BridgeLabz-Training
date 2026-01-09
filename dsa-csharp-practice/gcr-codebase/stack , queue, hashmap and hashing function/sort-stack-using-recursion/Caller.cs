using System;
using System.Collections.Generic;

namespace BridgeLabzTraining.dsa_csharp_practice.stack___queue__hashmap_and_hashing_function.sort_stack_using_recursion
{
    class Caller
    {
        public static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            SortStackUsingRecursion sorter = new SortStackUsingRecursion();

            stack.Push(30);
            stack.Push(10);
            stack.Push(20);
            stack.Push(5);

            sorter.SortStack(stack);

            Console.WriteLine("Sorted Stack");
            while (stack.Count > 0)
            {
                Console.WriteLine(stack.Pop());
            }
        }
    }
}
