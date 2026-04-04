using System;

namespace BridgeLabzTraining.dsa_csharp_practice.stack___queue__hashmap_and_hashing_function.circular_tour_problem
{
    class Caller
    {
        public static void Main(string[] args)
        {
            CircularTour tour = new CircularTour();

            int[] petrol = { 4, 6, 7, 4 };
            int[] distance = { 6, 5, 3, 5 };

            int start = tour.FindStart(petrol, distance);

            if (start != -1)
            {
                Console.WriteLine("Start at pump --> " + start);
            }
            else
            {
                Console.WriteLine("No tour");
            }
        }
    }
}
