using System;

namespace BridgeLabzTraining.arrays.level_02
{
    internal class Friends
    {
        public static void Check()
        {
            string[] name = { "Amar", "Akbar", "Anthony" };

            double[] ages = new double[3];
            double[] heights = new double[3];

            // Input
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"\nEnter details for {name[i]}");

                Console.Write("Age: ");
                bool validAge = double.TryParse(Console.ReadLine(), out ages[i]);

                Console.Write("Height (in cm): ");
                bool validHeight = double.TryParse(Console.ReadLine(), out heights[i]);

                if (!validAge || !validHeight || ages[i] <= 0 || heights[i] <= 0)
                {
                    Console.WriteLine("Invalid input! Please enter valid values.");
                    i--;
                }
            }

            // Assume first as youngest and tallest initially
            int youngIdx = 0;
            int tallIdx = 0;

            // Find youngest and tallest
            for (int i = 1; i < 3; i++)
            {
                if (ages[i] < ages[youngIdx])
                {
                    youngIdx = i;
                }

                if (heights[i] > heights[tallIdx])
                {
                    tallIdx = i;
                }
            }

            // Output
            Console.WriteLine("\nResult");

            Console.WriteLine($"Youngest Friend : {name[youngIdx]} (Age: {ages[youngIdx]})");
            
            Console.WriteLine($"Tallest Friend  : {name[tallIdx]} (Height: {heights[tallIdx]} cm)");
        }
    }
}
