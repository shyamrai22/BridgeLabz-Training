using System;
using System.Collections.Generic;

namespace BridgeLabzTraining.dsa_csharp_practice.stack___queue__hashmap_and_hashing_function.sort_stack_using_recursion
{
    class SortStackUsingRecursion
    {
        // method to sort the stack
        public void SortStack(Stack<int> stack)
        {
            if (stack.Count == 0)
            {
                return;
            }

            int top = stack.Pop();

            SortStack(stack);

            InsertAtCorrectPosition(stack, top);
        }

        // method to insert element in sorted order
        private void InsertAtCorrectPosition(Stack<int> stack, int data)
        {
            if (stack.Count == 0 || stack.Peek() <= data)
            {
                stack.Push(data);
                return;
            }

            int top = stack.Pop();

            InsertAtCorrectPosition(stack, data);

            stack.Push(top);
        }
    }
}
