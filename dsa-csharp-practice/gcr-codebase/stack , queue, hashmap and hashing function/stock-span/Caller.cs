using System;

namespace BridgeLabzTraining.dsa_csharp_practice.stack___queue__hashmap_and_hashing_function.stock_span_problem
{
    class Caller
    {
        public static void Main(string[] args)
        {
            StockSpan stock = new StockSpan();

            int[] prices = { 99, 89, 69, 79, 69, 79, 89 };

            stock.CalculateSpan(prices);
        }
    }
}
