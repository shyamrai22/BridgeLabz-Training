using System;

namespace BridgeLabzTraining.methods.level_01
{
    internal class SpringSeason
    {
        // Check Spring Season
        public static bool CheckSeason(int m, int d)
        {
            if ((m == 3 && d >= 20) || (m == 4) || (m == 5) || (m == 6 && d <= 20))
            {
                return true;
            }

            return false;
        }

        // Calling the method
        public static void Caller()
        {
            Console.Write("Enter month: ");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter day: ");
            int d = Convert.ToInt32(Console.ReadLine());

            bool res = CheckSeason(m, d);

            if (res)
                Console.WriteLine("Its a Spring Season");

            else
                Console.WriteLine("Not a Spring Season");
        }
    }
}
