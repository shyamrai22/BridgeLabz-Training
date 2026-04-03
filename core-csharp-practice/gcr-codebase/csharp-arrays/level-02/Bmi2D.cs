using System;

namespace BridgeLabzTraining.arrays.level_02
{
    internal class Bmi2D
    {
        public static void Calculation()
        {
            // Input for number of persons
            Console.Write("Enter number of persons: ");
            int num = int.Parse(Console.ReadLine());
            double[,] pData = new double[num, 3];
            string[] wStatus = new string[num];

            // Height and weight with validation
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine($"Person {i + 1}:");

                
                while (true)
                {
                    Console.Write("Enter height (in cm): ");
                    pData[i, 0] = double.Parse(Console.ReadLine());

                    if (pData[i, 0] > 0)
                        break;

                    Console.WriteLine("Height must be positive. Try again.");
                }

                
                while (true)
                {
                    Console.Write("Enter weight (in kg): ");
                    pData[i, 1] = double.Parse(Console.ReadLine());

                    if (pData[i, 1] > 0)
                        break;

                    Console.WriteLine("Weight must be positive. Try again.");
                }
            }

            // Calculation

            for (int i = 0; i < num; i++)
            {
                double hInMeters = pData[i, 0] / 100;
                pData[i, 2] = pData[i, 1] / (hInMeters * hInMeters);

                if (pData[i, 2] <= 18.4)
                    wStatus[i] = "Underweight";
                else if (pData[i, 2] <= 24.9)
                    wStatus[i] = "Normal";
                else if (pData[i, 2] <= 39.9)
                    wStatus[i] = "Overweight";
                else
                    wStatus[i] = "Obese";
            }

            // Output
            Console.WriteLine("BMI Report");

            for (int i = 0; i < num; i++)
            {
                Console.WriteLine($"Person {i + 1}");

                Console.WriteLine($"Height : {pData[i, 0]} cm");
                
                Console.WriteLine($"Weight : {pData[i, 1]} kg");
                
                Console.WriteLine($"BMI    : {pData[i, 2]:F2}");
                
                Console.WriteLine($"Status : {wStatus[i]}");
            }
        }
    }
}
