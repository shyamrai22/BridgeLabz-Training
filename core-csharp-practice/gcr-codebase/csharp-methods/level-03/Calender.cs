using System;

namespace BridgeLabzTraining.methods.level_03
{
    internal class Calendar
    {
        
        public static string GetMonth(int m)
        {

            string[] months =
            {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"};
            return months[m - 1];

        }

        
        public static bool LeapYear(int y)
        {
            if (y % 400 == 0)
                return true;

            if (y % 100 == 0)
                return false;
            
            return y % 4 == 0;
        
        }

        
        public static int DaysInMonth(int m, int y)
        {
            int[] day =
            {
                31, 28, 31, 30, 31, 30,
                31, 31, 30, 31, 30, 31
            };

            if (m == 2 && LeapYear(y)) return 29;

            return day[m - 1];

        }

        
        public static int FirstDay(int m, int y)
        {
            int y0 = y - (14 - m) / 12;
            int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
            int m0 = m + 12 * ((14 - m) / 12) - 2;
            int d0 = (1 + x + (31 * m0) / 12) % 7;

            return d0;
        }

        // Calling above methods
        public static void Caller()
        {
            Console.Write("Enter a month: ");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter a year: ");
            int y = Convert.ToInt32(Console.ReadLine());

            string mName = GetMonth(m);
            int d = DaysInMonth(m, y);
            int fDay = FirstDay(m, y);

            Console.WriteLine();
            Console.WriteLine($"{mName} {y}");
            Console.WriteLine("Sun Mon Tue Wed Thu Fri Sat");

            
            for (int i = 0; i < fDay; i++)
            {
                Console.Write("    ");
            }

            // Output

            for (int day = 1; day <= d; day++)
            {

                Console.Write($"{day,3} ");
                if ((day + fDay) % 7 == 0) Console.WriteLine();
            
            }

            Console.WriteLine();

        }
    }
}
