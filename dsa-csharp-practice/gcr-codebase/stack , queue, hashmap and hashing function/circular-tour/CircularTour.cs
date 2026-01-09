using System;

namespace BridgeLabzTraining.dsa_csharp_practice.stack___queue__hashmap_and_hashing_function.circular_tour_problem
{
    class CircularTour
    {
        public int FindStart(int[] petrol, int[] distance)
        {
            int p = petrol.Length;
            int balance = 0;
            int def = 0;
            int start = 0;

            for (int i = 0; i < p; i++)
            {
                balance += petrol[i] - distance[i];
                if (balance < 0)
                {
                    def += balance;
                    start = i + 1;
                    balance = 0;
                }
            }
            if (balance + def >= 0)
            {
                return start;
            }
            return -1;
        }
    }
}
