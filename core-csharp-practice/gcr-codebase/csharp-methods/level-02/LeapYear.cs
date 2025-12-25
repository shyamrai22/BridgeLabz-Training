using System;

namespace BridgeLabzTraining.methods.level_02
{
    internal class LeapYear
    {
        // Checking Leap Year
        public static bool CheckLeapYear(int y)
        {
            if (y < 1582)
                return false;

            if ((y % 4 == 0 && y % 100 != 0) || (y % 400 == 0))
                return true;

            return false;
        }

        // Calling the method
        public static void Caller()
        {
            Console.Write("Enter year: ");
            int y = Convert.ToInt32(Console.ReadLine());

            if (y < 1582)
            {
                Console.WriteLine("Enter a year greater than or equal to 1582");
                return;
            }

            bool res = CheckLeapYear(y);

            if (res)
            {
                Console.WriteLine("Year is a Leap Year");
            }
            else
            {
                Console.WriteLine("Not a Leap Year");
            }
        }
    }
}
