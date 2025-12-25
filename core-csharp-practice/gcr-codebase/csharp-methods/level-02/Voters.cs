using System;

namespace BridgeLabzTraining.methods.level_02
{
    internal class Voters
    {
        // Method to check if a student can vote
        public static bool CanVote(int a)
        {
            
            if (a < 0) return false;

            if (a >= 18) return true;

            return false;
        }

        // Calling the method
        public static void Caller()
        {
            int[] age = new int[10];

            for (int i = 0; i < age.Length; i++)
            {
                Console.Write($"Enter age of student {i + 1}: ");
                age[i] = Convert.ToInt32(Console.ReadLine());

                bool canVote = CanVote(age[i]);

                if (canVote)
                {
                    Console.WriteLine("Is eligible to vote");
                }
                else
                {
                    Console.WriteLine("Is not eligible to vote");
                }
            }
        }
    }
}
