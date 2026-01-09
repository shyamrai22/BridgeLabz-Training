using System;
using System.Collections.Generic;

namespace BridgeLabzTraining.dsa_csharp_practice.stack___queue__hashmap_and_hashing_function.stock_span_problem
{
    class StockSpan
    {
        public void CalculateSpan(int[] price)
        {
            int l = price.Length;
            int[] spans = new int[l];

            Stack<int> stack = new Stack<int>();

            // first day span is always 1
            spans[0] = 1;
            stack.Push(0);

            for (int i = 1; i < l; i++)
            {
                while (stack.Count > 0 && price[stack.Peek()] <= price[i])
                {
                    stack.Pop();
                }

                spans[i] = (stack.Count == 0) ? (i + 1) : (i - stack.Peek());

                stack.Push(i);
            }

            // Display
            for (int i = 0; i < l; i++)
            {
                Console.WriteLine($"Day {i + 1} -> Span = {spans[i]}");
            }
        }
    }
}
