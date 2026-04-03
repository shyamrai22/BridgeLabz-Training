using System;

namespace BridgeLabzTraining.arrays.level_02
{
    internal class Bmi
    {
        public static void CalculateBmi()
        {
            // Input for number of people
            Console.Write("Enter number of persons: ");
            int n = int.Parse(Console.ReadLine());
            double[] h = new double[n];
            double[] w = new double[n];
            double[] bmi = new double[n];
            string[] status = new string[n];

            // Height and weight input
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nPerson {i + 1}:");
                Console.Write("Enter height : ");
                h[i] = double.Parse(Console.ReadLine());
                Console.Write("Enter weight : ");
                w[i] = double.Parse(Console.ReadLine());
            }

            // BMI and status
            for (int i = 0; i < n; i++)
            {
                double hInMeters = h[i] / 100;
                bmi[i] = w[i] / (hInMeters * hInMeters);


                if (bmi[i] <= 18.4)
                    status[i] = "Underweight";
                else if (bmi[i] <= 24.9)
                    status[i] = "Normal";
                else if (bmi[i] <= 39.9)
                    status[i] = "Overweight";
                else
                    status[i] = "Obese";
            }

            // Output
            Console.WriteLine(" BMI Report");

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Person {i + 1}");

                Console.WriteLine($"Height : {h[i]} m");

                Console.WriteLine($"Weight : {w[i]} kg");

                Console.WriteLine($"BMI    : {bmi[i]:F2}");

                Console.WriteLine($"Status : {status[i]}");
            }
        }
    }
}
