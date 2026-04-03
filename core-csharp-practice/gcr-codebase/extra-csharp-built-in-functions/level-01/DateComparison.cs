using System;

namespace BridgeLabzTraining.extras_csharp_built_in_functions.level_01
{
    class DateComparison
    {
        public static void Caller()
        {
            // Input
            Console.Write("Enter first date in (yyyy-MM-dd): ");
            string day1 = Console.ReadLine();
            Console.Write("Enter second date in (yyyy-MM-dd): ");
            string day2 = Console.ReadLine();

            if (day1 == null || day2 == null)
                return;

            DateTime d1 = DateTime.Parse(day1);
            DateTime d2 = DateTime.Parse(day2);
            int res = DateTime.Compare(d1, d2);
            
            //Output
            if (res < 0)
                Console.WriteLine("BEFORE");
            else if (res > 0)
                Console.WriteLine("AFTER");
            else
                Console.WriteLine("SAME");
        }
    }
}
