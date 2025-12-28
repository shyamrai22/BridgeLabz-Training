using System;

namespace BridgeLabzTraining.extras_csharp_built_in_functions.level_01
{
    class DateFormatting
    {
        public static void Caller()
        {
            DateTime date = DateTime.Now;

            // Output

            Console.WriteLine("Date Formats:");
            Console.WriteLine(date.ToString("dd/MM/yyyy"));
            Console.WriteLine(date.ToString("yyyy-MM-dd"));
            Console.WriteLine(date.ToString("ddd, MMM dd, yyyy"));
        }
    }
}
