using System;

/*
<summary>

This program analyzes a week’s hourly temperature data stored in a 2D array (float[7,24]).
It identifies the hottest and coldest day based on recorded temperatures and calculates
the average temperature for each day by processing all 24 hourly values.

</summary>
*/

namespace BridgeLabzTraining.scenario_based
{
    public class TemperatureAnalysis
    {
        // Method to find the hottest day
        public static int HottestDay(float[,] temps)
        {
            int hottestDay = 0;
            float maxTemp = temps[0, 0];

            for (int day = 0; day < temps.GetLength(0); day++)
            {
                for (int hour = 0; hour < temps.GetLength(1); hour++)
                {
                    if (temps[day, hour] > maxTemp)
                    {
                        maxTemp = temps[day, hour];
                        hottestDay = day;
                    }
                }
            }
            return hottestDay;
        }

        // Method to find the coldest day
        public static int ColdestDay(float[,] temps)
        {
            int coldestDay = 0;
            float minTemp = temps[0, 0];

            for (int day = 0; day < temps.GetLength(0); day++)
            {
                for (int hour = 0; hour < temps.GetLength(1); hour++)
                {
                    if (temps[day, hour] < minTemp)
                    {
                        minTemp = temps[day, hour];
                        coldestDay = day;
                    }
                }
            }
            return coldestDay;
        }

        // Method to calculate average temperature per day
        public static float[] AverageTemperaturePerDay(float[,] temps)
        {
            int days = temps.GetLength(0); // used to get length of rows/days (dimension-1)
            int hours = temps.GetLength(1); // used to get length of columns/hours (dimension-2)

            float[] averages = new float[days];

            for (int day = 0; day < days; day++)
            {
                float sum = 0;

                for (int hour = 0; hour < hours; hour++)
                {
                    sum += temps[day, hour];
                }

                averages[day] = sum / hours;
            }
            return averages;
        }

        // Method to call the above methods
        public static void Caller()
        {
            float[,] temperatures =
            {
                { 30,31,29,28,27,26,25,24,26,28,30,32,33,34,35,36,35,34,33,32,31,30,29,28 },
                { 25,26,24,23,22,21,20,21,23,25,27,28,29,30,31,32,31,30,29,28,27,26,25,24 },
                { 28,29,27,26,25,24,23,24,26,28,30,31,32,33,34,35,34,33,32,31,30,29,28,27 },
                { 26,27,25,24,23,22,21,22,24,26,28,29,30,31,32,33,32,31,30,29,28,27,26,25 },
                { 29,30,28,27,26,25,24,25,27,29,31,32,33,34,35,36,37,36,35,34,33,32,31,30 },
                { 24,25,23,22,21,20,19,20,22,24,26,27,28,29,30,31,30,29,28,27,26,25,24,23 },
                { 27,28,26,25,24,23,22,23,25,27,29,30,31,32,33,34,33,32,31,30,29,28,27,26 }
            };

            int hottestDay = HottestDay(temperatures);
            int coldestDay = ColdestDay(temperatures);
            float[] averages = AverageTemperaturePerDay(temperatures);

            Console.WriteLine("Hottest Day: Day " + (hottestDay + 1));
            Console.WriteLine("Coldest Day: Day " + (coldestDay + 1));

            for (int i = 0; i < averages.Length; i++)
            {
                Console.WriteLine($"Average temperature of Day {i + 1}: {averages[i]}");
            }
        }
    }
}
