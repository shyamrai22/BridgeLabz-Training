using System;

namespace BridgeLabzTraining.extras_csharp_built_in_functions.level_01
{
    class DateArithmetic
    {
        public static void Caller()
        {
            // Input
            Console.Write("Enter a date (yyyy-MM-dd): ");
            string str = Console.ReadLine();

            if (str == null)
                return;

            DateTime d = DateTime.Parse(str);
            d = d.AddDays(7);
            d = d.AddMonths(1);
            d = d.AddYears(2);
            d = d.AddDays(-21);

            // Output
            Console.WriteLine("Final Date : " + d.ToString("dd-MM-yyyy"));
        }
    }
}
